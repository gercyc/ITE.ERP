namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Informacoes de rastro do produto
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdRastro {
    
        private string nLoteField;
    
        private string qLoteField;
    
        private string dFabField;
    
        private string dValField;
    
        private string cAgregField;

        /// <summary>
        /// Número do lote do produto.
        /// </summary>
        public string nLote {
            get {
                return this.nLoteField;
            }
            set {
                this.nLoteField = value;
            }
        }

        /// <summary>
        /// Quantidade de produto no lote.
        /// </summary>
        public string qLote {
            get {
                return this.qLoteField;
            }
            set {
                this.qLoteField = value;
            }
        }

        /// <summary>
        /// Data de fabricação/produção. FormatoAAAA-MM-DD
        /// </summary>
        public string dFab {
            get {
                return this.dFabField;
            }
            set {
                this.dFabField = value;
            }
        }

        /// <summary>
        /// Data de validade. Informar o último dia do mês caso a validade não especifique o dia. Formato AAAA-MM-DD
        /// </summary>
        public string dVal {
            get {
                return this.dValField;
            }
            set {
                this.dValField = value;
            }
        }
    
        /// <summary>
        /// 
        /// </summary>
        public string cAgreg {
            get {
                return this.cAgregField;
            }
            set {
                this.cAgregField = value;
            }
        }
    }
}