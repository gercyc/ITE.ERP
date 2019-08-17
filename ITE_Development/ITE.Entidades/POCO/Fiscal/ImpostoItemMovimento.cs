
using ITE.Entidades.Enumeradores.RegraFiscalEnum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Fiscal
{
    [Table("ImpostoItemMovimento")]
    public class ImpostoItemMovimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdItemImposto { get; set; }
        public int IdImposto { get; set; }
        public int IdItem { get; set; }
        public int? IdCst { get; set; }
        public decimal BaseCalculo { get; set; }
        public decimal Aliquota { get; set; }
        public decimal ValorImposto { get; set; }
        
        //1 - Tributado, 2 Isento ou ñ tributado, ou 3 - Outros
        
        public TypeTipoLancImposto TpSitImposto { get; set; }

        [ForeignKey("IdItem")]
        public virtual ItemMovimento NotaFiscalItem { get; set; }

        [ForeignKey("IdCst")]
        public virtual SituacaoTributaria SituacaoTributaria { get; set; }

        [ForeignKey("IdImposto")]
        public virtual TipoImposto TipoImposto { get; set; }

      
        public ImpostoItemMovimento()
        {

        }
        public decimal CalcularVlrImposto()
        {
            return ValorImposto = (this.BaseCalculo * this.Aliquota) / 100;
        }

        public void Update(ImpostoItemMovimento item)
        {
            this.Aliquota = item.Aliquota;
            this.BaseCalculo = item.BaseCalculo;
            this.TipoImposto = item.TipoImposto;
            this.SituacaoTributaria = item.SituacaoTributaria;
            this.IdCst = item.IdCst;
            this.IdImposto = item.IdImposto;
            this.TpSitImposto = item.TpSitImposto;
            this.ValorImposto = item.ValorImposto;
        }
        public ImpostoItemMovimento Clone()
        {
            return (ImpostoItemMovimento)this.MemberwiseClone();
        }
    }
}
