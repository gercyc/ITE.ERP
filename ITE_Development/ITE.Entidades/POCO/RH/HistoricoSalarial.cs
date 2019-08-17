using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH
{


    [Table("HistoricoSalarial")]
    public class HistoricoSalarial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHistoricoSalario { get; set; }

        public int IdFuncionario { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Informe o motivo da alteração do salário")]
        [StringLength(100)]
        public string Motivo { get; set; }

        [ForeignKey("IdFuncionario")]
        public virtual Funcionario Funcionario { get; set; }

        public HistoricoSalarial(decimal salario, string motivo)
        {
            this.Data = DateTime.Today;
            this.Salario = salario;
            this.Motivo = motivo;

        }
        public HistoricoSalarial()
        {

        }


    }
}
