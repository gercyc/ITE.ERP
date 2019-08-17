using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;

namespace ITE.Entidades.POCO.Fiscal
{
    [Table("RegrasFiscais")]
    public class RegraFiscal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRegraFiscal { get; set; }

        [StringLength(5, ErrorMessage = "Informe um código de ao menos 5 caracteres! ", MinimumLength = 5)]
        public string CodigoRegraFiscal { get; set; }

        [StringLength(80, ErrorMessage = "Informe o mínimo de 10 caracteres para descrição do Tipo de Movimento", MinimumLength = 10)]
        public string DescricaoRegraFiscal { get; set; }

        public TypeDirecao TipoNatureza { get; set; }
        public TypeTipoDevolucao TipoDevolucao { get; set; }

        public virtual ICollection<ImpostosRegraFiscal> ImpostosRegraFiscal { get; set; }

        public bool MovimentaEstoque { get; set; }
        public string BaseLegal { get; set; }

        public RegraFiscal()
        {
            this.ImpostosRegraFiscal = new HashSet<ImpostosRegraFiscal>();
        }
        public void Update (RegraFiscal novo)
        {
            this.BaseLegal = novo.BaseLegal;
            this.CodigoRegraFiscal = novo.CodigoRegraFiscal;
            this.DescricaoRegraFiscal = novo.DescricaoRegraFiscal;
            this.MovimentaEstoque = novo.MovimentaEstoque;
            this.TipoDevolucao = novo.TipoDevolucao;
            this.TipoNatureza = novo.TipoNatureza;
        }
        public override string ToString()
        {
            return this.CodigoRegraFiscal + " - " + this.DescricaoRegraFiscal;
        }
    }
}
