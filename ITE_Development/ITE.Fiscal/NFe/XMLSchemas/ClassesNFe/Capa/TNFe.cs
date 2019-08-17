using System;
using System.Xml.Serialization;

namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Tipo Nota Fiscal Eletrônica. 
    /// Esta é a classe principal que contem todos os elementos da nota fiscal
    /// eletronica
    /// </summary>
    [Serializable]
    [XmlRoot("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    //[XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFe {
    
        private TNFeInfNFe infNFeField;
    
        private TNFeInfNFeSupl infNFeSuplField;
    
        private SignatureType signatureField;

        /// <summary>
        /// Informações da Nota Fiscal eletrônica
        /// </summary>
        public TNFeInfNFe infNFe {
            get {
                return this.infNFeField;
            }
            set {
                this.infNFeField = value;
            }
        }

        /// <summary>
        /// Informações suplementares Nota Fiscal
        /// </summary>
        public TNFeInfNFeSupl infNFeSupl {
            get {
                return this.infNFeSuplField;
            }
            set {
                this.infNFeSuplField = value;
            }
        }
    
        /// <summary>
        /// Assinatura eletronica
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
    }
}