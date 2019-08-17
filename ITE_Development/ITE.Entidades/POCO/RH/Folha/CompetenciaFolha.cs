using ITE.Entidades.Enumeradores;
using ITE.Entidades.Enumeradores.RHEnum;
using ITSolution.Framework.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.RH.Folha
{
    /// <summary>
    /// Controle das competencias. Modulo folha de pagamento. Registro principal
    ///
    /// </summary>
    /// 
    [Table("CompetenciaFolha")]
    public class CompetenciaFolha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCompetencia { get; set; } //pk da tabela, unico
        public DateTime DataInicialCompetencia { get; set; }
        public DateTime DataFinalCompetencia { get; set; }
        public string Periodo { get; set; }
        public decimal? ValorLiquidoFechamento { get; set; }
        public DateTime? DataFechamento { get; set; }
        public TypeStatusCompetencia Status { get; set; }
        public TypeTipoFechamentoFolha TipoFechamento { get; set; }
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<FuncionarioCompetencia> FuncionariosCompetencia { get; set; }

        public CompetenciaFolha()
        {
            this.FuncionariosCompetencia = new HashSet<FuncionarioCompetencia>();
        }
        /// <summary>
        /// Adicionar uma nova competencia para edição
        /// </summary>
        /// <param name="periodo"></param>
        /// <param name="usuario"></param>
        public CompetenciaFolha(DateTime periodo, Usuario usuario, TypeTipoFechamentoFolha tipoFechamento)
        {
            this.FuncionariosCompetencia = new HashSet<FuncionarioCompetencia>();
            this.DataInicialCompetencia = DataUtil.GetDataInicialDoMes(periodo.Month);
            this.DataFinalCompetencia = DataUtil.GetDataFinalDoMes(periodo.Month);
            this.Periodo = periodo.ToString("MM/yyyy");

            //if(periodo.Month.ToString().Length > 1)
            //{
            //    this.Periodo = "0" + this.Periodo;
            //}
            this.IdUsuario = usuario.IdUsuario;
            this.Status = TypeStatusCompetencia.EmEdicao;
            this.TipoFechamento = tipoFechamento;
        }

        public void Update(CompetenciaFolha novo, 
            List<FuncionarioCompetencia> funcsRemovidos, 
            List<FichaFinanceiraFuncionario> movsRemovidos)
        {

        }
    }
}
