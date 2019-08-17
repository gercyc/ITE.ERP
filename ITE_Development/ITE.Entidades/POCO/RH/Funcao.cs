
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH
{

    [Table("Funcao")]
    public class Funcao
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFuncao { get; set; }

        [Display(Name = "Nome da Função")]
        [Required(ErrorMessage = "Nome da Função não foi informado")]
        [StringLength(100, MinimumLength = 4)]
        public string NomeFuncao { get; set; }

        [Display(Name = "Código da função")]
        [Required(ErrorMessage = "Código da Função não foi informado")]
        [StringLength(50, MinimumLength = 1)]
        public string CodigoFuncao { get; set; }

        public int? CBO { get; set; }

        //virtual removido => nao sera carregado
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<HistoricoFuncao> HistoricoFuncao { get; set; }
        public Funcao()
        {
            this.Funcionarios = new HashSet<Funcionario>();
            this.HistoricoFuncao = new HashSet<HistoricoFuncao>();
        }
        public Funcao(string nome, string codigo, int cbo)
        {
            this.NomeFuncao = nome;
            this.CodigoFuncao = codigo;
            this.CBO = cbo;
        }
        public void Update(Funcao funcaoNova)
        {
            this.NomeFuncao = funcaoNova.NomeFuncao;
            this.CodigoFuncao = funcaoNova.CodigoFuncao;
            this.CBO = funcaoNova.CBO;
        }

        public override string ToString()
        {
            return this.NomeFuncao;
        }
    }
}
