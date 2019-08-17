using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Financeiro
{
    [Table("CreditoCliente")]
    public class CreditoCliente
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdCredito { get; set; }
        
        [Display(Name = "Cliente")]
        //[Range(1, int.MaxValue, ErrorMessage = "Cliente não informado ao realizar crédito")]
        public int IdCliFor { get; set; }

        [ForeignKey("IdCliFor")]
        public virtual CliFor CliFor { get; set; }

        [Required]
        public DateTime DataCredito { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Não possivél gerar um crédito de valor 0.")]
        public decimal ValorCredito { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string Historico { get; set; }

        public CreditoCliente()
        {

        }
        public CreditoCliente(CliFor cliFor, Decimal valorCredito, String historico = null)
        {
            this.ValorCredito = valorCredito;
            this.DataCredito = DateTime.Now;
            this.Historico = historico;
            this.IdCliFor = cliFor != null ? cliFor.IdCliFor : 0;
        }

        public override string ToString()
        {
            return CliFor + "\nCrédito: " + ValorCredito + "\nData do crédito:" + DataCredito;
        }
    }
}
