using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.Fiscal.NFe
{
    public class LoteEnvioNFe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLoteNfe { get; set; }
        public string NumeroLote { get; set; }
        //Xml do lote com todas as NFes
        public string ConteudoLote { get; set; }


    }
}
