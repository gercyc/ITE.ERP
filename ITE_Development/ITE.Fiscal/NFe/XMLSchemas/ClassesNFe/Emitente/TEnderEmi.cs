namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Endereço do Emitente: Tipo Dados do Endereço do Emitente  // 24/10/08 - desmembrado / tamanho mínimo
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEnderEmi
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private string ufField;

        private string cEPField;

        private string cPaisField;

        private bool cPaisFieldSpecified;

        private string xPaisField;

        private bool xPaisFieldSpecified;

        private string foneField;

        /// <summary>
        /// Logradouro
        /// </summary>
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        /// <summary>
        /// Número
        /// </summary>
        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        /// <summary>
        /// Complemento
        /// </summary>
        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        /// <summary>
        /// Bairro
        /// </summary>
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        /// <summary>
        /// Código do município. Utilizar código IBGE
        /// </summary>
        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        /// <summary>
        /// Nome do município
        /// </summary>        
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        /// <summary>
        /// Sigla da UF
        /// </summary>
        public string UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <summary>
        /// CEP - NT 2011/004
        /// </summary>
        public string CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        /// <summary>
        /// Código do país. Sempre será 1058 (Brasil)
        /// </summary>
        public string cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = "1058";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cPaisSpecified
        {
            get
            {
                return this.cPaisFieldSpecified;
            }
            set
            {
                this.cPaisFieldSpecified = value;
            }
        }

        /// <summary>
        /// Nome do país
        /// </summary>
        public string xPais
        {
            get
            {
                return this.xPaisField;
            }
            set
            {
                this.xPaisField = "Brasil";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xPaisSpecified
        {
            get
            {
                return this.xPaisFieldSpecified;
            }
            set
            {
                this.xPaisFieldSpecified = value;
            }
        }

        /// <summary>
        /// Preencher com Código DDD + número do telefone (v.2.0)
        /// </summary>
        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }
    }
}