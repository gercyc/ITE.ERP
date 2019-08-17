namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Identificação do Destinatário
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDest
    {

        private string tipodocumentoField;

        private TipoDocumentoDestinatario itemElementNameField;

        private string xNomeField;

        private TEndereco enderDestField;

        private TNFeInfNFeDestIndIEDest indIEDestField;

        private string ieField;

        private string iSUFField;

        private string imField;

        private string emailField;

        /// <summary>
        /// Informar CPF ou CNPJ
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("idEstrangeiro", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("TipoDocumentoDestinatario")]
        public string TipoDocumento
        {
            get
            {
                return this.tipodocumentoField;
            }
            set
            {
                this.tipodocumentoField = value;
            }
        }

        /// <summary>
        /// Tipo de documento do destinatario
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocumentoDestinatario TipoDocumentoDestinatario
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
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
        /// Dados do endereço
        /// </summary>
        public TEndereco enderDest
        {
            get
            {
                return this.enderDestField;
            }
            set
            {
                this.enderDestField = value;
            }
        }

        /// <summary>
        /// Indicador da IE do destinatário:
        ///1 – Contribuinte ICMSpagamento à vista;
        ///2 – Contribuinte isento de inscrição;
        ///9 – Não Contribuinte
        /// </summary>
        public TNFeInfNFeDestIndIEDest indIEDest
        {
            get
            {
                return this.indIEDestField;
            }
            set
            {
                this.indIEDestField = value;
            }
        }

        /// <summary>
        /// Inscrição Estadual (obrigatório nas operações com contribuintes do ICMS)
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
        /// Inscrição na SUFRAMA (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob controle da SUFRAMA) PL_005d - 11/08/09 - alterado para aceitar 8 ou 9 dígitos
        /// </summary>
        public string ISUF
        {
            get
            {
                return this.iSUFField;
            }
            set
            {
                this.iSUFField = value;
            }
        }

        /// <summary>
        /// Inscrição Municipal do tomador do serviço
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
        /// Informar o e-mail do destinatário. O campo pode ser utilizado para informar o e-mail de recepção da NF-e indicada pelo destinatário
        /// </summary>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
    }
}