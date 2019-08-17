using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH
{


    [Table("HistoricoDepartamento")]
    public  class HistoricoDepartamento
    {              

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHistoricoDepartamento { get; set; }

        public int IdFuncionario { get; set; }

        public int IdDepartamento { get; set; }

        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Informe o motivo da alteração do departamento")]
        [StringLength(100)]
        public string Motivo { get; set; }

        [ForeignKey("IdFuncionario")]
        public virtual Funcionario Funcionario { get; set; }

        [ForeignKey("IdDepartamento")]
        public virtual Departamento Departamento { get; set; }

        public HistoricoDepartamento(int idDepto, string motivo)
        {
            this.Data = DateTime.Today;
            this.IdDepartamento = idDepto;
            this.Motivo = motivo;
        }

        public HistoricoDepartamento(Departamento departamento, string motivo)
        {
            this.Data = DateTime.Today;
            this.IdDepartamento = departamento != null ? departamento.IdDepartamento : 0;
            this.Motivo = motivo;
        }

        public HistoricoDepartamento()
        {

        }

    }
}
