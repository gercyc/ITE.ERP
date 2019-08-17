namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoDevol {
    
        private string pDevolField;
    
        private TNFeInfNFeDetImpostoDevolIPI iPIField;
    
        /// <remarks/>
        public string pDevol {
            get {
                return this.pDevolField;
            }
            set {
                this.pDevolField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeDetImpostoDevolIPI IPI {
            get {
                return this.iPIField;
            }
            set {
                this.iPIField = value;
            }
        }
    }
}