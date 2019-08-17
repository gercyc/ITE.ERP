namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeEmit
    {

        private string tipoDocEmitenteField;
        
        private string xNomeField;

        private string xFantField;

        private TEnderEmi enderEmitField;

        private string ieField;

        private string iESTField;

        private string imField;

        private string cNAEField;

        private TipoDocumentoEmitente tipoDocumentoEmitente;

        private TNFeInfNFeEmitCRT cRTField;

        /// <summary>
        /// Informar CPF ou CNPJ
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("TipoDocumentoEmitente")]
        public string TipoDocEmitente
        {
            get
            {
                return this.tipoDocEmitenteField;
            }
            set
            {
                this.tipoDocEmitenteField = value;
            }
        }
        /// <summary>
        /// Tipo de documento do destinatario
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocumentoEmitente TipoDocumentoEmitente
        {
            get
            {
                return this.tipoDocumentoEmitente;
            }
            set
            {
                this.tipoDocumentoEmitente = value;
            }
        }

        /// <summary>
        /// Razão Social ou Nome do emitente
        /// </summary>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        /// <summary>
        /// Nome fantasia
        /// </summary>
        public string xFant
        {
            get
            {
                return this.xFantField;
            }
            set
            {
                this.xFantField = value;
            }
        }

        /// <summary>
        /// Endereco do emitente
        /// </summary>
        public TEnderEmi enderEmit
        {
            get
            {
                return this.enderEmitField;
            }
            set
            {
                this.enderEmitField = value;
            }
        }

        /// <summary>
        /// Inscrição Estadual do Emitente
        /// </summary>
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        /// <summary>
        /// Inscricao Estadual do Substituto Tributário
        /// </summary>
        public string IEST
        {
            get
            {
                return this.iESTField;
            }
            set
            {
                this.iESTField = value;
            }
        }

        /// <summary>
        /// Inscrição Municipal
        /// </summary>
        public string IM
        {
            get
            {
                return this.imField;
            }
            set
            {
                this.imField = value;
            }
        }

        /// <summary>
        /// CNAE Fiscal
        /// </summary>
        public string CNAE
        {
            get
            {
                return this.cNAEField;
            }
            set
            {
                this.cNAEField = value;
            }
        }

        /// <summary>
        /// Código de Regime Tributário. 
        ///Este campo será obrigatoriamente preenchido com:
        ///1 – Simples Nacional;
        ///2 – Simples Nacional – excesso de sublimite de receita bruta;
        ///3 – Regime Normal.
        /// </summary>
        public TNFeInfNFeEmitCRT CRT
        {
            get
            {
                return this.cRTField;
            }
            set
            {
                this.cRTField = value;
            }
        }
    }
}