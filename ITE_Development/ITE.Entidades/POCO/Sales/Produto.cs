using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.POCO.TI;
using ITE.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using ITE.Entitidades.Enumeradores.FiscalEnum;

namespace ITE.Entidades.POCO.Sales
{
    [Serializable]
    [Table("Produto")]
    public class Produto
    {
        [Key]//pk
        [Column]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Código de Barras não foi informado")]
        [StringLength(200)]
        [Display(Name = "Código Barras")]
        public string CodigoBarras { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        [StringLength(200, MinimumLength = 3)]
        [Index(IsUnique = true)]  //Restricao UNIQUE
        public string DescricaoProduto { get; set; }

        [Required]
        [Display(Name = "Preço Compra")]
        public decimal PrecoCompra { get; set; }

        [Required]
        [Display(Name = "Preço Venda")]
        public decimal PrecoVenda { get; set; }

        [Required]
        [Display(Name = "Quantidade do produto")]
        public decimal QuantidadeProduto { get; set; }

        [Display(Name = "Margem Lucro")]
        public decimal MargemLucro { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Data Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Required]
        [Display(Name = "Status Produto")]
        [Column("StatusProduto")]
        public TypeStatusProduto StatusProduto { get; set; }

        [Display(Name = "Tipo Item")]
        public TypeItemProduto TipoItemProduto { get; set; }

        [Display(Name = "Foto Produto")]
        public byte[] FotoProduto { get; set; }

        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        public int IdCategoriaProduto { get; set; }

        [ForeignKey("IdCategoriaProduto")]
        public virtual CategoriaProduto CategoriaProduto { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Unidade de medida não foi informada.")]
        public int IdUnidadeMedidaProduto { get; set; }

        [ForeignKey("IdUnidadeMedidaProduto")]
        public virtual UnidadeMedida UnidadeMedida { get; set; }


        [Display(Name = "Tipo Item (EFD)")]
        public TypeTipoItemEFD IdentificacaoProduto { get; set; }

        [Display(Name = "Código NCM")]
        [StringLength(8)]
        public string CodigoNCM { get; set; }

        public virtual AtributoProduto Atributos { get; set; }

        public virtual ICollection<AlteracaoProduto> AlteracoesProduto { get; set; }

        public virtual ICollection<TransacoesProduto> TransacoesProduto { get; set; }

        //Removi o virtual para perfomace
        public ICollection<ItemVenda> ItensVenda { get; set; }

        public ICollection<ItemMovimento> NotasFiscaisItens { get; set; }

        public ICollection<ItemManutencao> ItensManutencao { get; set; }

        #region Nao mapeado - Utilizado somente para controle interno

        [NotMapped]
        public Image Image
        {
            get
            {
                switch (this.StatusProduto)
                {
                    case TypeStatusProduto.Ativo:

                        if (this.TipoItemProduto == TypeItemProduto.Servico)
                            return Properties.Resources.properties_16x16;

                        return Properties.Resources.flag_success;

                    case TypeStatusProduto.Invativo:
                        return Properties.Resources.index_16x16;

                    case TypeStatusProduto.SemEstoque:
                        return Properties.Resources.about_16x16;

                    default:
                        return Properties.Resources.flag_notice;
                }
            }
        }

        #endregion Nao mapeado - Utilizado somente para controle interno

        public Produto()
        {
            this.Atributos = new AtributoProduto();
            this.ItensVenda = new HashSet<ItemVenda>();
            this.AlteracoesProduto = new HashSet<AlteracaoProduto>();
            this.TransacoesProduto = new HashSet<TransacoesProduto>();
            this.NotasFiscaisItens = new HashSet<ItemMovimento>();
            this.DataCadastro = DateTime.Now;
            this.CodigoBarras = "";
        }

        public Produto Clone()
        {
            return (Produto)this.MemberwiseClone();
        }

        public Produto(String desc, CategoriaProduto cat, UnidadeMedida unMedida,
            String codigoBarras, TypeItemProduto tpProduto,
            decimal precoVenda, decimal quantidade, byte[] foto, TypeStatusProduto status)
            : this()
        {
            this.DescricaoProduto = desc;
            this.IdCategoriaProduto = cat != null ? cat.IdCategoriaProduto : 0;
            this.IdUnidadeMedidaProduto = unMedida != null ? unMedida.IdUnidadeMedida : 0;
            this.PrecoVenda = precoVenda;
            this.QuantidadeProduto = quantidade;
            this.FotoProduto = foto;
            this.StatusProduto = status;

            this.CodigoBarras = codigoBarras;
            this.TipoItemProduto = tpProduto;

            if (this.TipoItemProduto == TypeItemProduto.Servico)
            {
                this.QuantidadeProduto = 1;//sempre 1
            }

        }


        public Produto(String desc, decimal precoCompra, decimal precoVenda, decimal quantidade,
            TypeStatusProduto status, String obs)
        {
            this.DescricaoProduto = desc;
            //this.IdCategoriaProduto = cat != null ? cat.IdCategoriaProduto : 0;
            //this.IdUnidadeMedidaProduto = unMedida != null ? unMedida.IdUnidadeMedida : 0;

            this.PrecoVenda = precoVenda;
            this.PrecoCompra = precoCompra;
            //this.MargemLucro = margemLucro;

            this.QuantidadeProduto = quantidade;
            //this.FotoProduto = foto;
            this.StatusProduto = status;
            this.Observacao = obs;
        }

        /// <summary>
        /// Calcula a margem de lucro pelo preco que o produto está sendo vendido
        /// </summary>
        /// <returns></returns>
        public decimal CalcularMargemLucro(decimal precoVenda, decimal precoCompra)
        {

            //https://blog.contaazul.com/saiba-como-calcular-a-margem-de-lucro-de-um-produto-e-da-empresa
            if (precoCompra == 0) return 100;
            decimal margem = 0;
            try
            {
                decimal lucro = precoVenda - precoCompra;
                margem = (lucro / precoVenda) * 100;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Convert.ToDecimal(margem.ToString("N2"));
        }
        //Calcula o preco que o produto deve ser vendido a partir da margem informada
        public decimal CalcularMargemSobPrecoCompra(decimal precoCompra, decimal margemLucro)
        {
            //Regra de 3
            //PrecoCompra      100%
            //x                Margem
            var lucro = (precoCompra * margemLucro) / 100;

            return precoCompra + lucro;
        }

        public decimal CalculaTotalProduto(decimal preco, decimal quantidadeProduto)
        {
            return preco * quantidadeProduto;
        }

        /// <summary>
        /// Atualizar o produto atual com o produto informado
        /// </summary>
        /// <param name="produto"></param>
        public void Update(Produto produto)
        {
            this.IdCategoriaProduto = produto.IdCategoriaProduto;
            this.IdUnidadeMedidaProduto = produto.IdUnidadeMedidaProduto;
            this.CodigoNCM = produto.CodigoNCM;
            this.IdentificacaoProduto = produto.IdentificacaoProduto;

            if (produto.CategoriaProduto != null)
            {

                this.IdCategoriaProduto = produto.CategoriaProduto != null
                    ? produto.CategoriaProduto.IdCategoriaProduto
                    : produto.IdCategoriaProduto;

            }
            if (produto.UnidadeMedida != null)
            {
                this.IdUnidadeMedidaProduto = produto.UnidadeMedida != null
                    ? produto.UnidadeMedida.IdUnidadeMedida
                    : produto.IdUnidadeMedidaProduto;
            }
            this.DescricaoProduto = produto.DescricaoProduto;
            this.QuantidadeProduto = produto.QuantidadeProduto;
            this.StatusProduto = produto.StatusProduto;
            this.PrecoCompra = produto.PrecoCompra;
            this.PrecoVenda = produto.PrecoVenda;

            this.MargemLucro = produto.CalcularMargemLucro(produto.PrecoVenda, produto.PrecoCompra);

            if (this.PrecoVenda == 0 && MargemLucro != 0 && this.PrecoVenda != 0)
            {
                this.PrecoVenda = produto.PrecoCompra + (this.PrecoCompra * this.MargemLucro);
            }
            this.FotoProduto = produto.FotoProduto;

            this.TipoItemProduto = produto.TipoItemProduto;
            this.CodigoBarras = produto.CodigoBarras;

            if (this.QuantidadeProduto == 0)
                this.StatusProduto = TypeStatusProduto.Ativo;

            if (this.QuantidadeProduto == 0 && this.TipoItemProduto == TypeItemProduto.Produto)
            {
                this.StatusProduto = TypeStatusProduto.SemEstoque;
            }

            if (this.TipoItemProduto == TypeItemProduto.Servico)
            {
                //sempre 1
                this.QuantidadeProduto = 1;
                this.StatusProduto = TypeStatusProduto.Ativo;
            }


            //atualiza os atributos
            this.Atributos.Update(produto);

        }

        public override string ToString()
        {
            /*return this.DescricaoProduto + " 1x " + this.QuantidadeProduto.ToString("N3") +
                " " + this.PrecoVenda.ToString("N2") + " = " +
                this.CalculaTotalProduto(this.PrecoVenda, this.QuantidadeProduto).ToString("N2");*/

            return DescricaoProduto;
        }

    }
}
