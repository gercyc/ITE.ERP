namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Dados dos totais da NF-e
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotal {
    
        private TNFeInfNFeTotalICMSTot iCMSTotField;
    
        private TNFeInfNFeTotalISSQNtot iSSQNtotField;
    
        private TNFeInfNFeTotalRetTrib retTribField;

        /// <summary>
        /// Totais referentes ao ICMS
        /// </summary>
        public TNFeInfNFeTotalICMSTot ICMSTot {
            get {
                return this.iCMSTotField;
            }
            set {
                this.iCMSTotField = value;
            }
        }

        /// <summary>
        /// Totais referentes ao ISSQN
        /// </summary>
        public TNFeInfNFeTotalISSQNtot ISSQNtot {
            get {
                return this.iSSQNtotField;
            }
            set {
                this.iSSQNtotField = value;
            }
        }

        /// <summary>
        /// Retenção de Tributos Federais
        /// </summary>
        public TNFeInfNFeTotalRetTrib retTrib {
            get {
                return this.retTribField;
            }
            set {
                this.retTribField = value;
            }
        }
    }
}