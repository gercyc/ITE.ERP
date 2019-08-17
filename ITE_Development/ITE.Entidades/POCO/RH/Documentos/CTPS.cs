using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH.Documentos
{
    /// <summary>
    /// Usado como atributo Embbeded
    /// </summary>
    public class CTPS
    {
        [Column("NumeroPis")]
        [StringLength(50)]
        public string NumeroPis { get; set; }

        [Column("NumeroCTPS")]
        [StringLength(50)]
        public string NumeroCTPS { get; set; }

        [Column("SerieCTPS")]
        [StringLength(50)]
        public string SerieCTPS { get; set; }

        [Column("DataEmissaoCTPS", TypeName = "date")]
        public DateTime? DataEmissaoCTPS { get; set; }

        [Column("EstadoEmissaoCTPS")]
        [StringLength(5)]
        public string EstadoEmissaoCTPS { get; set; }

        public CTPS()
        {

        }
        public override string ToString()
        {
            return this.NumeroCTPS;
        }

    }
}
