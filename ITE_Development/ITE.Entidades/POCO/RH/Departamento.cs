using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH
{
    [Table("Departamento")]
    public class Departamento
    {
        public Departamento()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDepartamento { get; set; }

        [Required(ErrorMessage = "Nome do Departamento não foi informado")]
        [Display(Name = "Nome do Departamento")]
        [StringLength(100, MinimumLength = 4)]
        public string NomeDepartamento { get; set; }

        //virtual removido => nao sera carregado
        public ICollection<Funcionario> Funcionarios { get; set; }

        //virtual removido => nao sera carregado
        public ICollection<HistoricoDepartamento> HistoricoDepartamentos { get; set; }


        public Departamento(string Nome)
        {
            this.NomeDepartamento = Nome;
        }
        public void Update(Departamento depto)
        {
            this.NomeDepartamento = depto.NomeDepartamento;
        }

        public override string ToString()
        {
            return this.NomeDepartamento;
        }
    }
}
