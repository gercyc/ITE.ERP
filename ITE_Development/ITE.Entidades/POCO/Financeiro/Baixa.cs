using ITE.Entidades.POCO.Financeiro;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.Financeiro.POCO
{
    [Table("Baixa")]
    public class Baixa
    {

        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdBaixa { get; set; }

        [Required]
        [Display(Name = "Valor pago")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Valor pago deve ser no minímo 0.01")]
        public Decimal ValorBaixa { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Lançamento")]
        public int IdLancamento { get; set; }

        [Display(Name = "Data da baixa")]
        public DateTime DataBaixa { get; set; }

        [ForeignKey("IdLancamento")]
        public virtual LancamentoFinanceiro LancamentoFinanceiro { get; set; }

        public Baixa()
        {
            
        }
        public Baixa(decimal valorBaixa, int idLancamento, DateTime dataBaixa)
        {
            this.ValorBaixa = valorBaixa;
            this.IdLancamento = idLancamento;
            this.DataBaixa = dataBaixa;
        }
    }
}
