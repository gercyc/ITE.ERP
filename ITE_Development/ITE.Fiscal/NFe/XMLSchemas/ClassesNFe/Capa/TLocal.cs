namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Tipo Dados do Local de Retirada ou Entrega // 24/10/08 - tamanho mínimo // v2.0
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TLocal {
    
        private string descTipoDocLocalEntregaRetiradaField;
    
        private TipoDocLocalEntregaRetirada itemElementNameField;
    
        private string xLgrField;
    
        private string nroField;
    
        private string xCplField;
    
        private string xBairroField;
    
        private string cMunField;
    
        private string xMunField;
    
        private string ufField;
    
        /// <summary>
        /// 
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("TipoDocLocalEntregaRetirada")]
        public string DescTipoDocLocalEntregaRetirada
        {
            get {
                return this.descTipoDocLocalEntregaRetiradaField;
            }
            set {
                this.descTipoDocLocalEntregaRetiradaField = value;
            }
        }

        /// <summary>
        /// Tipo de documento do local de entrega ou retirada
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocLocalEntregaRetirada TipoDocLocalEntregaRetirada
        {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }

        /// <summary>
        /// Logradouro
        /// </summary>
        public string xLgr {
            get {
                return this.xLgrField;
            }
            set {
                this.xLgrField = value;
            }
        }

        /// <summary>
        /// Número
        /// </summary>
        public string nro {
            get {
                return this.nroField;
            }
            set {
                this.nroField = value;
            }
        }

        /// <summary>
        /// Complemento
        /// </summary>
        public string xCpl {
            get {
                return this.xCplField;
            }
            set {
                this.xCplField = value;
            }
        }

        /// <summary>
        /// Bairro
        /// </summary>
        public string xBairro {
            get {
                return this.xBairroField;
            }
            set {
                this.xBairroField = value;
            }
        }

        /// <summary>
        /// Código do município (utilizar a tabela do IBGE)
        /// </summary>
        public string cMun {
            get {
                return this.cMunField;
            }
            set {
                this.cMunField = value;
            }
        }

        /// <summary>
        /// Nome do município
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
    }
}