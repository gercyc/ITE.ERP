using ITE.Entidades.Enumeradores.CEEnums;
using ITSolution.Framework.Web.Bacen;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.CE
{
    [Table("CotacaoCusteio")]
    public class CotacaoCusteio
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdCotacaoCusteio { get; set; }

        public long IdCusteio { get; set; }

        public DateTime DataCotacao { get; set; }

        public TypeTipoCotacao TipoCotacao { get; set; }

        public decimal ValorMoeda { get; set; }

        public int IdMoeda { get; set; }

        [ForeignKey("IdMoeda")]
        public virtual Moeda Moeda { get; set; }

        [ForeignKey("IdCusteio")]
        public virtual Custeio Custeio { get; set; }

        public void Update(CotacaoCusteio novo)
        {
            IdCusteio = novo. IdCusteio;
            IdMoeda = novo.IdMoeda;
            DataCotacao = novo. DataCotacao;
            TipoCotacao = novo. TipoCotacao;
            ValorMoeda = novo. ValorMoeda;
        }
    }
}
