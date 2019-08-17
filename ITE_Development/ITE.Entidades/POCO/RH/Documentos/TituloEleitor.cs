using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH.Documentos
{
    /// <summary>
    /// Usado como atributo Embbeded
    /// </summary>
    public class TituloEleitor
    {
        [Column("NumeroTituloEleitor")]
        [StringLength(50)]
        public string NumeroTituloEleitor { get; set; }

        [Column("ZonaEleitoral")]
        [StringLength(50)]
        public string ZonaEleitoral { get; set; }

        [Column("SecaoEleitoral")]
        [StringLength(50)]
        public string SecaoEleitoral { get; set; }

        [Column("DataEmissaoTituloEleitor", TypeName = "date")]
        public DateTime? DataEmissaoTituloEleitor { get; set; }

        [Column("UfEmissaoTituloEleitor")]
        [StringLength(50)]
        public string UfEmissaoTituloEleitor { get; set; }

        public TituloEleitor()
        {

        }
        public override string ToString()
        {
            return this.NumeroTituloEleitor;
        }
    }
}
