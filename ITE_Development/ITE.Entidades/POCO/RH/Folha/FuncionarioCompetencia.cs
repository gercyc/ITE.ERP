using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ITE.Entidades.POCO.RH.Folha
{
    /// <summary>
    /// Funcionarios que movimentaram a competencia. 
    /// </summary>
    [Table("FuncionarioCompetencia")]
    public class FuncionarioCompetencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFuncionarioCompetencia { get; set; } //pk da tabela, unico

        public int IdCompetencia { get; set; }

        [ForeignKey("IdCompetencia")]
        public virtual CompetenciaFolha Competencia { get; set; }

        public int IdFuncionario { get; set; }
  
        [ForeignKey("IdFuncionario")]
        public virtual Funcionario Funcionario { get; set; }

        public decimal ValorFgts { get; set; }

        public decimal ValorBaseInss { get; set; }

        public decimal ValorBaseIrrf { get; set; }

        public decimal ValorAliquotaIrrf { get; set; }

        /// <summary>
        /// Obtem o valor liquido do pagamento do periodo
        /// </summary>
        [NotMapped]
        public decimal ValorLiquido
        {
            get
            {
                var provento = 0M;
                var desconto = 0M;

                this.FichaFinanceiraFuncionario.ToList().ForEach(ficha =>
                {

                    provento += ficha.Proventos != null ? ficha.Proventos.Value : 0M;
                    desconto += ficha.Descontos != null ? ficha.Descontos.Value : 0M;
                });
                var liquido = (provento - desconto);
                return liquido;
            }
        }

        public virtual ICollection<FichaFinanceiraFuncionario> FichaFinanceiraFuncionario { get; set; }

        public FuncionarioCompetencia(Funcionario funcionario)
        {
            this.FichaFinanceiraFuncionario = new HashSet<FichaFinanceiraFuncionario>();
            this.Funcionario = funcionario;
            this.IdFuncionario = funcionario.IdFuncionario;
        }

        public FuncionarioCompetencia()
        {
            this.FichaFinanceiraFuncionario = new HashSet<FichaFinanceiraFuncionario>();
        }
        public override string ToString()
        {
            return this.Funcionario.NomeFuncionario;
        }

        public void Update(FuncionarioCompetencia funcionarioCompetencia, List<FichaFinanceiraFuncionario> eventosRemovidos = null)
        {
            foreach (var fichaFuncionario in funcionarioCompetencia.FichaFinanceiraFuncionario)
            {
                if (fichaFuncionario.IdFichaFinanFunc == 0)
                {
                    fichaFuncionario.FuncionarioCompetencia = null;
                    fichaFuncionario.Evento = null;
                    this.FichaFinanceiraFuncionario.Add(fichaFuncionario);
                }
            }
        }
    }
}
