using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Sales
{
    [Table("ItemVenda")]
    public class ItemVenda 
    {
        [Key]//pk
        [Column(Order = 0)]
        //nao sera auto increment
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Venda")]
        public int IdVenda { get; set; }

        [ForeignKey("IdVenda")]
        public virtual Venda Venda { get; set; }

        [Key]
        [Column(Order = 1)]
        //nao sera auto increment
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdProduto { get; set; }

        [ForeignKey("IdProduto")]
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

        public ItemVenda() { }

        public ItemVenda(Venda venda)
        {
            this.IdVenda = venda.IdVenda;
        }
        public ItemVenda(Produto produto)
        {
            this.IdProduto = produto != null ? produto.IdProduto : 0;
            this.Produto = produto;
            this.ValorUnitario = produto.PrecoVenda;
            this.Quantidade = produto.QuantidadeProduto;
            this.TotalItem = Quantidade * ValorUnitario;

            if (produto.TipoItemProduto == Enumeradores.TypeItemProduto.Servico
                && produto.QuantidadeProduto == 0)
            {
                this.TotalItem = produto.PrecoVenda;
            }
        }

        public ItemVenda Clone()
        {
            return (ItemVenda)this.MemberwiseClone();
        }
        /// <summary>
        /// Atualiza o item com base no produto informado
        /// </summary>
        /// <param name="item"></param>
        public void Update(ItemVenda item)
        {
            this.IdProduto = item.Produto != null ? item.Produto.IdProduto : 0;
            this.ValorUnitario = item.Produto.PrecoVenda;
            this.Quantidade = item.Produto.QuantidadeProduto;
            this.TotalItem = Quantidade * ValorUnitario;

            if (item.Quantidade == 0)
                this.TotalItem = ValorUnitario;
            else
                this.TotalItem = Quantidade * ValorUnitario;
        }
        /// <summary>
        /// Atualiza o item com base nos dados do item
        /// </summary>
        /// <param name="item"></param>
        public void UpdateItem(ItemVenda item)
        {
            this.IdProduto = item.Produto != null ? item.Produto.IdProduto : 0;
            this.ValorUnitario = item.ValorUnitario;
            this.Quantidade = item.Quantidade;
            this.TotalItem = item.TotalItem;
            
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

                : IdProduto + "=>"+ Quantidade.ToString("N3") +
                  " x " + ValorUnitario.ToString("N2") + " = " +
                    TotalItem.ToString("N2");

        }

    }
}
