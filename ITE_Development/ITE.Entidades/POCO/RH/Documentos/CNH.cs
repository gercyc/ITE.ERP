using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH.Documentos
{
    /// <summary>
    /// Usado como atributo Embbeded
    /// </summary>
    public class CNH
    {
        [Column("NumeroRegistroCNH")]
        [StringLength(50)]
        public string NumeroRegistroCNH { get; set; }

        [Column("ValidadeCNH", TypeName = "date")]
        public DateTime? ValidadeCNH { get; set; }

        [Column("CategoriaCNH")]
        [StringLength(5)]
        public string CategoriaCNH { get; set; }

        [Column("DataPrimeiraHabCNH", TypeName = "date")]
        public DateTime? DataPrimeiraHabCNH { get; set; }

        [Column("OrgaoEmissoCNH")]
        [StringLength(50)]
        public string OrgaoEmissoCNH { get; set; }

        public CNH()
        {

        }
        public override string ToString()
        {
            return this.NumeroRegistroCNH;
        }
    }
}
