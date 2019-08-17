using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace ITE.Entidades.POCO.Fiscal
{
    [Table("SitTribut")]
    public class SituacaoTributaria
    {

        [Key]
        public int IdCst { get; set; }

        [Required]
        [StringLength(3)]
        public string CodigoCst { get; set; }

        [Required]
        [StringLength(255)]
        public string DescricaoCst { get; set; }

        public int IdImposto { get; set; }
        
        [ForeignKey("IdImposto")]
        public virtual TipoImposto TipoImposto { get; set; }

        //public ICollection<NotaFiscalItemImposto> NotasFiscaisItemImposto { get; set; }


        public SituacaoTributaria()
        {
            //this.NotasFiscaisItemImposto = new HashSet<NotaFiscalItemImposto>();
        }

        public void Update(SituacaoTributaria novo)
        {
            this.CodigoCst = novo.CodigoCst;
            this.DescricaoCst = novo.DescricaoCst;
            this.IdImposto = novo.IdImposto;
        }
        public SituacaoTributaria(string codigoCst, string descricaoCst, TipoImposto imposto)
        {
            this.CodigoCst = codigoCst;
            this.DescricaoCst = descricaoCst;
            this.IdImposto = imposto.IdImposto;
        }
        public override string ToString()
        {
            return this.CodigoCst;
        }
    }
}
