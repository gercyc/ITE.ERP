using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH.Documentos
{
    public class RegistroGeral
    {

        //[Required]
        [Column("NumeroRG")]
        [StringLength(20)]
        public string NumeroRG { get; set; }

        [Column("DataExpedicao")]
        public DateTime? DataExpedicao { get; set; }

        [Column("OrgaoEmissorRG")]
        [StringLength(50)]
        public string OrgaoEmissorRG { get; set; }

        [Column("Naturalidade")]
        [StringLength(50)]
        public string Naturalidade { get; set; }

        [Column("NomeMae")]
        [StringLength(50)]
        public string NomeMae { get; set; }

        [Column("NomePai")]
        [StringLength(50)]
        public string NomePai { get; set; }

        public RegistroGeral()
        {

        }

        public override string ToString()
        {
            return this.NumeroRG;
        }
    }
}
