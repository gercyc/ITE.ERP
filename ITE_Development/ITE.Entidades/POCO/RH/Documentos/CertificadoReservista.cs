using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH.Documentos
{
    /// <summary>
    /// Usado como atributo Embbeded
    /// </summary>
    public class CertificadoReservista
    {
        [Column("NumeroCertReservista")]
        [StringLength(50)]
        public string NumeroCertReservista { get; set; }

        [Column("CategoriaMilitar")]
        [StringLength(50)]
        public string CategoriaMilitar { get; set; }

        [Column("CircunscricaoMilitar")]
        [StringLength(50)]
        public string CircunscricaoMilitar { get; set; }

        [Column("RegiaoMilitar")]
        [StringLength(50)]
        public string RegiaoMilitar { get; set; }

        [Column("DataEmissaoCertificado", TypeName = "date")]
        public DateTime? DataEmissaoCertificado { get; set; }

        [Column("OrgaoEmissorCert")]
        [StringLength(50)]
        public string OrgaoEmissorCert { get; set; }

        [Column("SituacaoMilitar")]
        [StringLength(50)]
        public string SituacaoMilitar { get; set; }

        public CertificadoReservista()
        {

        }

        public override string ToString()
        {
            return this.NumeroCertReservista;
        }
    }
}
