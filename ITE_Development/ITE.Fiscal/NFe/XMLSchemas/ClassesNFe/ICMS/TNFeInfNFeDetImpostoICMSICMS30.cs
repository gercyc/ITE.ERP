namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Tributação pelo ICMS
    ///30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS30
    {

        private Torig origField;

        private string cSTField;

        private TypeModalidadeBaseCalculoICMS modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string vBCFCPSTField;

        private string pFCPSTField;

        private string vFCPSTField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMSField;

        /// <summary>
        ///Origem da mercadoria ICMS 30: 
        ///0 - Nacional 
        ///1 - Estrangeira - Importação direta 
        ///2 - Estrangeira - Adquirida no mercado interno
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
        /// Código da situação tributária CST ICMS
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
        /// Modalidade de determinação da BC do ICMS:
        /// 0 - Margem Valor Agregado(%);
        /// 1 - Pauta(valor);
        /// 2 - Preço Tabelado Máximo(valor);
        /// 3 - Valor da Operação.
        /// </summary>
        public TypeModalidadeBaseCalculoICMS modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        /// <summary>
        /// Percentual da Margem de Valor Adicionado ICMS ST
        /// </summary>
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        /// <summary>
        /// Percentual de redução da BC ICMS ST
        /// </summary>
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        /// <summary>
        /// Valor da BC do ICMS ST
        /// </summary>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <summary>
        /// Alíquota do ICMS ST
        /// </summary>
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        /// <summary>
        /// Valor do ICMS ST
        /// </summary>
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        /// <summary>
        /// Valor da Base de cálculo do FCP.
        /// </summary>
        public string vBCFCPST
        {
            get
            {
                return this.vBCFCPSTField;
            }
            set
            {
                this.vBCFCPSTField = value;
            }
        }

        /// <summary>
        /// Valor da Base de cálculo do FCP retido por substituicao tributaria.
        /// </summary>
        public string pFCPST
        {
            get
            {
                return this.pFCPSTField;
            }
            set
            {
                this.pFCPSTField = value;
            }
        }

        /// <summary>
        /// Percentual de FCP retido por substituição tributária.
        /// </summary>
        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

        /// <summary>
        /// Valor do FCP retido por substituição tributária.
        /// </summary>
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        /// <summary>
        /// Motivo da desoneração do ICMS:3-Uso na agropecuária;9-Outros;12-Fomento agropecuário
        /// </summary>
        public TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }
    }
}