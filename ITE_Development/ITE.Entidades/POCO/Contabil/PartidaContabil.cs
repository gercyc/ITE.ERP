using ITSolution.Framework.Web.Bacen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.Contabil
{
    public class PartidaContabil
    {

        [Key]//pk
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPartida { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdLancamentoContabil { get; set; }
        public int SequencialPartida { get; set; }
        public Nullable<int> IdCentroCusto { get; set; }
        public Nullable<int> IdContaContabilDeb { get; set; }
        public Nullable<int> IdContaContabilCred { get; set; }
        public int IdMoeda { get; set; }
        public decimal ValorPartida { get; set; }
        public Nullable<int> IdMoeda2 { get; set; }
        public decimal ValorPartida2 { get; set; }
        public Nullable<int> IdHistoricoPadrao { get; set; }
        public string Historico { get; set; }
        public Nullable<int> IdCliFor { get; set; }
        public string LocalizacaoFisDoc { get; set; }

        [ForeignKey("IdLancamentoContabil")]
        public virtual LancamentoContabil LancamentoContabil { get; set; }
        [ForeignKey("IdCentroCusto")]
        public virtual CentroCusto CentroCusto { get; set; }
        [ForeignKey("IdContaContabilDeb")]
        public virtual ContaContabil ContaContabilDebito { get; set; }
        [ForeignKey("IdContaContabilCred")]
        public virtual ContaContabil ContaContabilCredito { get; set; }
        [ForeignKey("IdMoeda")]
        public virtual Moeda MoedaPrincipal { get; set; }
        [ForeignKey("IdMoeda2")]
        public virtual Moeda MoedaEstrangeira { get; set; }
        [ForeignKey("IdCliFor")]
        public virtual CliFor Participante { get; set; }

        public PartidaContabil()
        {

        }
        
        public void Update(PartidaContabil nova)
        {

            this.ValorPartida = nova.ValorPartida;
            this.ValorPartida2 = nova.ValorPartida2;
            this.LocalizacaoFisDoc = nova.LocalizacaoFisDoc;
            this.Historico = nova.Historico;
            

            if (nova.CentroCusto != null)
            {
                this.CentroCusto = nova.CentroCusto;
                this.IdCentroCusto = nova.IdCentroCusto;
            }

            if (nova.ContaContabilDebito != null)
            {
                this.ContaContabilDebito = nova.ContaContabilDebito;
                this.IdContaContabilDeb = nova.IdContaContabilDeb;
            }

            if (nova.ContaContabilCredito != null)
            {
                this.ContaContabilCredito = nova.ContaContabilCredito;
                this.IdContaContabilCred = nova.IdContaContabilCred;
            }

            if (nova.MoedaPrincipal != null)
            {
                this.MoedaPrincipal = nova.MoedaPrincipal;
                this.IdMoeda = nova.IdMoeda;
            }

            if (nova.MoedaEstrangeira != null)
            {
                this.MoedaEstrangeira = nova.MoedaEstrangeira;
                this.IdMoeda2 = nova.IdMoeda2;
            }

            if (nova.Participante != null)
            {
                this.Participante = nova.Participante;
                this.IdCliFor = nova.IdCliFor;
            }

        }
    }
}
