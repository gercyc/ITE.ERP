namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Tributação pelo ICMS
    /// 60 - ICMS cobrado anteriormente por substituição tributária
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS60
    {

        private Torig origField;

        private string cSTField;

        private string vBCSTRetField;

        private string pSTField;

        private string vICMSSTRetField;

        private string vBCFCPSTRetField;

        private string pFCPSTRetField;

        private string vFCPSTRetField;

        /// <summary>
        /// Origem da mercadoria ICMS 20: 
        /// 0 - Nacional 
        /// 1 - Estrangeira - Importação direta 
        /// 2 - Estrangeira - Adquirida no mercado interno
        /// </summary>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <summary>
        /// Tributação pelo ICMS 
        ///60 - ICMS cobrado anteriormente por substituição tributária
        /// </summary>
        public string CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <summary>
        /// Valor da BC do ICMS ST retido anteriormente
        /// </summary>
        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        /// <summary>
        /// Aliquota suportada pelo consumidor final.
        /// </summary>
        public string pST
        {
            get
            {
                return this.pSTField;
            }
            set
            {
                this.pSTField = value;
            }
        }

        /// <summary>
        /// Valor do ICMS ST retido anteriormente
        /// </summary>
        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }

        /// <summary>
        /// Valor da Base de cálculo do FCP retido anteriormente por ST.
        /// </summary>
        public string vBCFCPSTRet
        {
            get
            {
                return this.vBCFCPSTRetField;
            }
            set
            {
                this.vBCFCPSTRetField = value;
            }
        }

        /// <summary>
        /// Percentual de FCP retido anteriormente por substituição tributária.
        /// </summary>
        public string pFCPSTRet
        {
            get
            {
                return this.pFCPSTRetField;
            }
            set
            {
                this.pFCPSTRetField = value;
            }
        }

        /// <summary>
        /// Valor do FCP retido por substituição tributária.
        /// </summary>
        public string vFCPSTRet
        {
            get
            {
                return this.vFCPSTRetField;
            }
            set
            {
                this.vFCPSTRetField = value;
            }
        }
    }
}