namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeExporta {
    
        private TUfEmi uFSaidaPaisField;
    
        private string xLocExportaField;
    
        private string xLocDespachoField;
    
        /// <remarks/>
        public TUfEmi UFSaidaPais {
            get {
                return this.uFSaidaPaisField;
            }
            set {
                this.uFSaidaPaisField = value;
            }
        }
    
        /// <remarks/>
        public string xLocExporta {
            get {
                return this.xLocExportaField;
            }
            set {
                this.xLocExportaField = value;
            }
        }
    
        /// <remarks/>
        public string xLocDespacho {
            get {
                return this.xLocDespachoField;
            }
            set {
                this.xLocDespachoField = value;
            }
        }
    }
}