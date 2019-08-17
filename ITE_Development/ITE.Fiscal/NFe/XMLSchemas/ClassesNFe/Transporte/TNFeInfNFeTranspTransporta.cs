using ITE.Entidades.Enumeradores.NFeEnum;

namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Dados do transportador
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspTransporta {
    
        private string cpfCnpjTransportadorField;
    
        private TypeTipoDocumentoNFe tipoDocumentoTransportadorField;
    
        private string xNomeField;
    
        private string ieField;
    
        private string xEnderField;
    
        private string xMunField;
    
        private string ufField;
    
        private bool ufFieldSpecified;
    
        /// <summary>
        /// CPF ou CNPJ. Conforme o tipo de documento selecionado
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("TipoDocumentoTransportador")]
        public string CpfCnpjTransportador {
            get {
                return this.cpfCnpjTransportadorField;
            }
            set {
                this.cpfCnpjTransportadorField = value;
            }
        }

        /// <summary>
        /// Tipo de documento do transportador. CPF ou CNPJ
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TypeTipoDocumentoNFe TipoDocumentoTransportador {
            get {
                return this.tipoDocumentoTransportadorField;
            }
            set {
                this.tipoDocumentoTransportadorField = value;
            }
        }

        /// <summary>
        /// Razão Social ou nome do transportador
        /// </summary>
        public string xNome {
            get {
                return this.xNomeField;
            }
            set {
                this.xNomeField = value;
            }
        }

        /// <summary>
        /// Inscrição Estadual (v2.0)
        /// </summary>
        public string IE {
            get {
                return this.ieField;
            }
            set {
                this.ieField = value;
            }
        }

        /// <summary>
        /// Endereço completo. Inclui ender. completo, compl, num, bairro
        /// </summary>
        public string xEnder {
            get {
                return this.xEnderField;
            }
            set {
                this.xEnderField = value;
            }
        }

        /// <summary>
        /// Nome do munícipio
        /// </summary>
        public string xMun {
            get {
                return this.xMunField;
            }
            set {
                this.xMunField = value;
            }
        }
    
        /// <summary>
        /// Sigla da UF
        /// </summary>
        public string UF {
            get {
                return this.ufField;
            }
            set {
                this.ufField = value;
            }
        }
    
        /// <summary>
        /// 
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UFSpecified {
            get {
                return this.ufFieldSpecified;
            }
            set {
                this.ufFieldSpecified = value;
            }
        }
    }
}