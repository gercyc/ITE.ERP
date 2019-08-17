namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDI {
    
        private string nDIField;
    
        private string dDIField;
    
        private string xLocDesembField;
    
        private TUfEmi uFDesembField;
    
        private string dDesembField;
    
        private TNFeInfNFeDetProdDITpViaTransp tpViaTranspField;
    
        private string vAFRMMField;
    
        private TNFeInfNFeDetProdDITpIntermedio tpIntermedioField;
    
        private string cNPJField;
    
        private TUfEmi uFTerceiroField;
    
        private bool uFTerceiroFieldSpecified;
    
        private string cExportadorField;
    
        private TNFeInfNFeDetProdDIAdi[] adiField;
    
        /// <remarks/>
        public string nDI {
            get {
                return this.nDIField;
            }
            set {
                this.nDIField = value;
            }
        }
    
        /// <remarks/>
        public string dDI {
            get {
                return this.dDIField;
            }
            set {
                this.dDIField = value;
            }
        }
    
        /// <remarks/>
        public string xLocDesemb {
            get {
                return this.xLocDesembField;
            }
            set {
                this.xLocDesembField = value;
            }
        }
    
        /// <remarks/>
        public TUfEmi UFDesemb {
            get {
                return this.uFDesembField;
            }
            set {
                this.uFDesembField = value;
            }
        }
    
        /// <remarks/>
        public string dDesemb {
            get {
                return this.dDesembField;
            }
            set {
                this.dDesembField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeDetProdDITpViaTransp tpViaTransp {
            get {
                return this.tpViaTranspField;
            }
            set {
                this.tpViaTranspField = value;
            }
        }
    
        /// <remarks/>
        public string vAFRMM {
            get {
                return this.vAFRMMField;
            }
            set {
                this.vAFRMMField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeDetProdDITpIntermedio tpIntermedio {
            get {
                return this.tpIntermedioField;
            }
            set {
                this.tpIntermedioField = value;
            }
        }
    
        /// <remarks/>
        public string CNPJ {
            get {
                return this.cNPJField;
            }
            set {
                this.cNPJField = value;
            }
        }
    
        /// <remarks/>
        public TUfEmi UFTerceiro {
            get {
                return this.uFTerceiroField;
            }
            set {
                this.uFTerceiroField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UFTerceiroSpecified {
            get {
                return this.uFTerceiroFieldSpecified;
            }
            set {
                this.uFTerceiroFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public string cExportador {
            get {
                return this.cExportadorField;
            }
            set {
                this.cExportadorField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("adi")]
        public TNFeInfNFeDetProdDIAdi[] adi {
            get {
                return this.adiField;
            }
            set {
                this.adiField = value;
            }
        }
    }
}