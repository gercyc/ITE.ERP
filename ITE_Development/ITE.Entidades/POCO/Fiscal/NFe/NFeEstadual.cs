using ITE.Entidades.Enumeradores.NFeEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.Fiscal.NFe
{
    [Table("NfeEstadual")]
    public class NFeEstadual
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNfe { get; set; }
        public int IdMovimento { get; set; }
        public string ChaveAcesso { get; set; }
        public string XmlNfe { get; set; }
        public TypeStatusEnvioNFe StatusXml { get; set; }
        public int? IdLoteEnvio { get; set; }
        [ForeignKey("IdMovimento")]
        public virtual Movimento Movimento { get; set; }
        

        [NotMapped]
        public Image ImageStatusNfe
        {
            get
            {
                if (this.StatusXml == TypeStatusEnvioNFe.XmlGerado)
                    return ITE.Entidades.Properties.Resources.xml_gerado;
                else if (this.StatusXml == TypeStatusEnvioNFe.XmlInvalido)
                    return ITE.Entidades.Properties.Resources.flag_error;
                else if (this.StatusXml == TypeStatusEnvioNFe.XmlValido)
                    return ITE.Entidades.Properties.Resources.xml_valido;
                else if (this.StatusXml == TypeStatusEnvioNFe.Assinada)
                    return ITE.Entidades.Properties.Resources.xml_assinado;
                else 
                    return ITE.Entidades.Properties.Resources.index_16x16;
            }
        }
    }
}
