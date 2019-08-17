namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicProcRef {
    
        private string nProcField;
    
        private TNFeInfNFeInfAdicProcRefIndProc indProcField;
    
        /// <remarks/>
        public string nProc {
            get {
                return this.nProcField;
            }
            set {
                this.nProcField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeInfAdicProcRefIndProc indProc {
            get {
                return this.indProcField;
            }
            set {
                this.indProcField = value;
            }
        }
    }
}