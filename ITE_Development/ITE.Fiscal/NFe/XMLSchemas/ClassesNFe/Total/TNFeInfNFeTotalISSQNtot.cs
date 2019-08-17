namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Totais referentes ao ISSQN
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalISSQNtot {
    
        private string vServField;
    
        private string vBCField;
    
        private string vISSField;
    
        private string vPISField;
    
        private string vCOFINSField;
    
        private string dCompetField;
    
        private string vDeducaoField;
    
        private string vOutroField;
    
        private string vDescIncondField;
    
        private string vDescCondField;
    
        private string vISSRetField;
    
        private TNFeInfNFeTotalISSQNtotCRegTrib cRegTribField;
    
        private bool cRegTribFieldSpecified;
    
        /// <summary>
        /// 
        /// </summary>
        public string vServ {
            get {
                return this.vServField;
            }
            set {
                this.vServField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string vBC {
            get {
                return this.vBCField;
            }
            set {
                this.vBCField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string vISS {
            get {
                return this.vISSField;
            }
            set {
                this.vISSField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string vPIS {
            get {
                return this.vPISField;
            }
            set {
                this.vPISField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string vCOFINS {
            get {
                return this.vCOFINSField;
            }
            set {
                this.vCOFINSField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string dCompet {
            get {
                return this.dCompetField;
            }
            set {
                this.dCompetField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string vDeducao {
            get {
                return this.vDeducaoField;
            }
            set {
                this.vDeducaoField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string vOutro {
            get {
                return this.vOutroField;
            }
            set {
                this.vOutroField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string vDescIncond {
            get {
                return this.vDescIncondField;
            }
            set {
                this.vDescIncondField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string vDescCond {
            get {
                return this.vDescCondField;
            }
            set {
                this.vDescCondField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string vISSRet {
            get {
                return this.vISSRetField;
            }
            set {
                this.vISSRetField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TNFeInfNFeTotalISSQNtotCRegTrib cRegTrib {
            get {
                return this.cRegTribField;
            }
            set {
                this.cRegTribField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cRegTribSpecified {
            get {
                return this.cRegTribFieldSpecified;
            }
            set {
                this.cRegTribFieldSpecified = value;
            }
        }
    }
}