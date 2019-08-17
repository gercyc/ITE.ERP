using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;

namespace ITE.Entidades.POCO.Fiscal
{
    [Table("ImpostosRegraFiscal")]
    public class ImpostosRegraFiscal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdImpostoRegraFical { get; set; }
        public int IdRegraFiscal { get; set; }
        public int IdImposto { get; set; }
        public int? IdCst { get; set; }
        public decimal Aliquota { get; set; }
        public string EnquadramentoIPI { get; set; }

        public TypeTipoTributacaoICMS TipoTributacaoICMS { get; set; }
        public TypeTipoTributacaoIPI TipoTributacaoIPI { get; set; }
        public TypeTipoLancImposto TipoLancImposto { get; set; }
        public TypeOperacaoTributariaICMS OperacaoTributariaICMS { get; set; }


        [ForeignKey("IdRegraFiscal")]
        public virtual RegraFiscal RegraFiscal { get; set; }
        [ForeignKey("IdImposto")]
        public virtual TipoImposto TipoImposto { get; set; }
        [ForeignKey("IdCst")]
        public virtual SituacaoTributaria SituacaoTributaria { get; set; }

        public void Update (ImpostosRegraFiscal novo)
        {
            this.Aliquota = novo.Aliquota;
            this.IdImposto = novo.IdImposto;
            this.TipoImposto = novo.TipoImposto;
            this.IdCst = novo.IdCst;
            this.SituacaoTributaria = novo.SituacaoTributaria;
            this.TipoLancImposto = novo.TipoLancImposto;
            //this.TipoMovimento = novo.TipoMovimento;
            this.TipoTributacaoICMS = novo.TipoTributacaoICMS;
            this.TipoTributacaoIPI = novo.TipoTributacaoIPI;
        }
        public void UpdateEf(ImpostosRegraFiscal novo)
        {
            this.Aliquota = novo.Aliquota;
            this.IdImposto = novo.IdImposto;
            //this.TipoImposto = novo.TipoImposto;
            this.IdCst = novo.IdCst;
            //this.SituacaoTributaria = novo.SituacaoTributaria;
            this.TipoLancImposto = novo.TipoLancImposto;
            this.RegraFiscal = novo.RegraFiscal;
            this.TipoTributacaoICMS = novo.TipoTributacaoICMS;
            this.TipoTributacaoIPI = novo.TipoTributacaoIPI;
        }


    }
}
