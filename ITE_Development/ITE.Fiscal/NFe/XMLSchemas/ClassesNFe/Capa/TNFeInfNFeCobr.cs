namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobr {
    
        private TNFeInfNFeCobrFat fatField;
    
        private TNFeInfNFeCobrDup[] dupField;
    
        /// <remarks/>
        public TNFeInfNFeCobrFat fat {
            get {
                return this.fatField;
            }
            set {
                this.fatField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dup")]
        public TNFeInfNFeCobrDup[] dup {
            get {
                return this.dupField;
            }
            set {
                this.dupField = value;
            }
        }
    }
}