using ITE.Entidades.Enumeradores;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Fiscal
{
    [Table("TipoImposto")]
    public class TipoImposto
    {

        [Key]
        public int IdImposto { get; set; }

        [Required]
        [StringLength(10)]
        public string CodigoImposto { get; set; }

        [Required]
        [StringLength(100)]
        public string DescricaoImposto { get; set; }

        public TypeAliquotaImposto TipoAliquota { get; set; }
        public decimal Aliquota { get; set; }

        //removido virtual nao sera carregado
        public ICollection<ImpostoItemMovimento> NotasFiscaisItemImposto { get; set; }

        public virtual ICollection<SituacaoTributaria> SituacaoTributaria { get; set; }
        public ICollection<ImpostosRegraFiscal> ImpostosRegraFiscal { get; set; }

        public TipoImposto()
        {
            //this.NotasFiscaisItemImposto = new HashSet<NotaFiscalItemImposto>();
            this.SituacaoTributaria = new HashSet<SituacaoTributaria>();
        }

        public TipoImposto(string codigo, string descImposto, TypeAliquotaImposto tipoAliquota, decimal aliquota = 0M)
        {
            this.CodigoImposto = codigo;
            this.DescricaoImposto = descImposto;
            this.TipoAliquota = tipoAliquota;
            this.Aliquota = aliquota;
        }
 
        public void Update(TipoImposto novo)
        {
            this.CodigoImposto = novo.CodigoImposto;
            this.DescricaoImposto = novo.DescricaoImposto;
            this.TipoAliquota = novo.TipoAliquota;
            this.Aliquota = novo.Aliquota;
        }

        public override string ToString()
        {
            return this.CodigoImposto;
        }
    }
}
