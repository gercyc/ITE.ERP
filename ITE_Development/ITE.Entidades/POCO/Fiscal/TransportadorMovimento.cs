using ITE.Entidades.Enumeradores.NFeEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.Fiscal
{
    [Table("NfeTransportadorMovimento")]
    public class TransportadorMovimento
    {

        public TransportadorMovimento()
        {

        }

        [Key]
        public int IdMovimento { get; set; }
        public int? IdCliForTransportador { get; set; }
        public string RazaoSocialTransportador { get; set; }
        public TypeTipoDocumentoNFe TipoDocTransportador { get; set; }
        public string InscricaoEstadualTransportador { get; set; }
        public string EnderecoTransportador { get; set; }
        public string MunicipioTransportador { get; set; }
        public string UFTransportador { get; set; }
        public string CpfCnpjTransportador { get; set; }

        [ForeignKey("IdMovimento")]
        public virtual Movimento Movimento { get; set; }
        [ForeignKey("IdCliForTransportador")]
        public virtual CliFor Transportador { get; set; }

        public void Update(TransportadorMovimento novo)
        {
            this.EnderecoTransportador = novo.EnderecoTransportador;
            this.IdCliForTransportador = novo.IdCliForTransportador;
            this.InscricaoEstadualTransportador = novo.InscricaoEstadualTransportador;
            this.MunicipioTransportador = novo.MunicipioTransportador;
            this.UFTransportador = novo.UFTransportador;
            this.RazaoSocialTransportador = novo.RazaoSocialTransportador;
            this.TipoDocTransportador = novo.TipoDocTransportador;
            this.CpfCnpjTransportador = novo.CpfCnpjTransportador;

            if (this.EnderecoTransportador.Length > 60)
                this.EnderecoTransportador = this.EnderecoTransportador.Substring(0, 60);
        }

    }
}
