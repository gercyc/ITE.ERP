using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Sales
{
    [Serializable]
    [Table("AlteracaoProduto")]

    public class AlteracaoProduto
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAlteracao { get; set; }

        [Column("IdProduto")]
        public int IdProduto { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoAlteracao { get; set; }

        public decimal? PercentualDescontoPromocao { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataAlteracao { get; set; }

        public decimal PrecoVendaAnterior { get; set; }

        public decimal PrecoCompraAnterior { get; set; }
        
        public decimal QtdAnterior { get; set; }

        [ForeignKey("IdProduto")]
        public virtual Produto Produto { get; set; }

        public AlteracaoProduto()
        {

        }
        public AlteracaoProduto(Int32 IdProduto, String tipoAlteracao,
            Decimal percentualDesconto, DateTime dataAlteracao, Decimal precoVendaAnterior,
            Decimal precoCompraAnterior, Decimal qtdAnterior)
        {
            this.IdProduto = IdProduto;
            this.TipoAlteracao = tipoAlteracao;
            this.PercentualDescontoPromocao = percentualDesconto;
            this.DataAlteracao = dataAlteracao;
            this.PrecoVendaAnterior = precoVendaAnterior;
            this.PrecoCompraAnterior = precoCompraAnterior;
            this.QtdAnterior = qtdAnterior;
        }
    }
}
