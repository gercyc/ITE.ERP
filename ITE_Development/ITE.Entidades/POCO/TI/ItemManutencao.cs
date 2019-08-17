using ITE.Entidades.POCO.Sales;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.TI
{
    [Serializable]
    [Table("ItemManutencao")]
    public class ItemManutencao
    {
        [Key]//pk
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//nao sera auto increment
        [Display(Name = "Manutencao")]
        public int IdManutencao { get; set; }

        [ForeignKey("IdManutencao")]
        public virtual Manutencao Manutencao { get; set; }

        [Key]//pk
        [Column(Order = 1)]//nao sera auto increment        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Nullable<int> IdProdutoManutencao { get; set; }

        [ForeignKey("IdProdutoManutencao")]
        public virtual Produto Produto { get; set; }

        [Required]
        [Display(Name = "Valor unitário")]
        public Decimal ValorUnitario { get; set; }

        [Required]
        [Display(Name = "Quantidade")]
        public Decimal Quantidade { get; set; }

        [Required]
        [Display(Name = "Desconto %")]
        public Decimal Desconto { get; set; }

        [Required]
        [Display(Name = "Total do Item")]
        public Decimal TotalItem { get; set; }

        public ItemManutencao() { }

        public ItemManutencao(Manutencao Manutencao)
        {
            this.IdManutencao = Manutencao.IdManutencao;
        }
        public ItemManutencao(Produto produto)
        {
            this.IdProdutoManutencao = produto != null ? produto.IdProduto : 0;
            this.Produto = produto;
            this.ValorUnitario = produto.PrecoVenda;
            this.Quantidade = produto.QuantidadeProduto;
            this.TotalItem = Quantidade * ValorUnitario;

            if(produto.TipoItemProduto == Enumeradores.TypeItemProduto.Servico
                && produto.QuantidadeProduto == 0)
            {
                this.TotalItem = produto.PrecoVenda;
            }
        }

        public ItemManutencao Clone()
        {
            return (ItemManutencao)this.MemberwiseClone();
        }

        public void Update(ItemManutencao item)
        {
            this.IdProdutoManutencao = item.Produto != null ? item.Produto.IdProduto : 0;
            this.ValorUnitario = item.Produto.PrecoVenda;
            this.Quantidade = item.Produto.QuantidadeProduto;

            if (item.Quantidade == 0)
                this.TotalItem = ValorUnitario;
            else
                this.TotalItem = Quantidade * ValorUnitario;

        }

        public override string ToString()
        {
            return Produto != null
                ? Produto.DescricaoProduto + "  " + Produto.QuantidadeProduto.ToString("N3") +
                  " x " + Produto.PrecoVenda.ToString("N2") + " = " +
                    Produto.CalculaTotalProduto(Produto.PrecoVenda, Produto.QuantidadeProduto).ToString("N2")

                //retorna vazio
                : "";
        }

    }
}
