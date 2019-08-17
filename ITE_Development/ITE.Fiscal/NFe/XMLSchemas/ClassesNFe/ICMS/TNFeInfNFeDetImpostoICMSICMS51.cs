namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Tributção pelo ICMS 51 - Diferido
    ///51 - Diferimento
    ///A exigência do preenchimento das informações do ICMS diferido fica à critério de cada UF.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS51
    {

        private Torig origField;

        private string cSTField;

        private TypeModalidadeBaseCalculoICMS modBCField;

        private bool modBCFieldSpecified;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSOpField;

        private string pDifField;

        private string vICMSDifField;

        private string vICMSField;

        private string vBCFCPField;

        private string pFCPField;

        private string vFCPField;

        /// <summary>
        ///Origem da mercadoria ICMS 20: 
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
        /// Tributção pelo ICMS
        ///20 - Com redução de base de cálculo
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
        ///0 - Margem Valor Agregado(%);
        ///1 - Pauta(valor);
        ///2 - Preço Tabelado Máximo(valor);
        ///3 - Valor da Operação.
        /// </summary>
        public TypeModalidadeBaseCalculoICMS modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <summary>
        /// Ignorado. verificar se podera ser removido da classe
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modBCSpecified
        {
            get
            {
                return this.modBCFieldSpecified;
            }
            set
            {
                this.modBCFieldSpecified = value;
            }
        }

        /// <summary>
        /// Percentual de redução da BC
        /// </summary>
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        /// <summary>
        /// Valor da BC do ICMS
        /// </summary>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <summary>
        /// Alíquota do imposto
        /// </summary>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <summary>
        /// Valor do ICMS da Operação
        /// </summary>
        public string vICMSOp
        {
            get
            {
                return this.vICMSOpField;
            }
            set
            {
                this.vICMSOpField = value;
            }
        }

        /// <summary>
        /// Percentual do diferemento
        /// </summary>
        public string pDif
        {
            get
            {
                return this.pDifField;
            }
            set
            {
                this.pDifField = value;
            }
        }

        /// <summary>
        /// Valor do ICMS da diferido
        /// </summary>
        public string vICMSDif
        {
            get
            {
                return this.vICMSDifField;
            }
            set
            {
                this.vICMSDifField = value;
            }
        }

        /// <summary>
        /// Valor do ICMS
        /// </summary>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <summary>
        /// Valor da Base de cálculo do FCP.
        /// </summary>
        public string vBCFCP
        {
            get
            {
                return this.vBCFCPField;
            }
            set
            {
                this.vBCFCPField = value;
            }
        }

        /// <summary>
        /// Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        public string pFCP
        {
            get
            {
                return this.pFCPField;
            }
            set
            {
                this.pFCPField = value;
            }
        }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }
    }
}