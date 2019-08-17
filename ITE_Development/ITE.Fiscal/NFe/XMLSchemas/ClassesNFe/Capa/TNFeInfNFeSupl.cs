namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeSupl {
    
        private string qrCodeField;
    
        private string urlChaveField;
    
        /// <remarks/>
        public string qrCode {
            get {
                return this.qrCodeField;
            }
            set {
                this.qrCodeField = value;
            }
        }
    
        /// <remarks/>
        public string urlChave {
            get {
                return this.urlChaveField;
            }
            set {
                this.urlChaveField = value;
            }
        }
    }
}