namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Emissão de avulsa, informar os dados do Fisco emitente
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAvulsa {
    
        private string cNPJField;
    
        private string xOrgaoField;
    
        private string matrField;
    
        private string xAgenteField;
    
        private string foneField;
    
        private string ufField;
    
        private string nDARField;
    
        private string dEmiField;
    
        private string vDARField;
    
        private string repEmiField;
    
        private string dPagField;

        /// <summary>
        /// CNPJ do Órgão emissor
        /// </summary>
        public string CNPJ {
            get {
                return this.cNPJField;
            }
            set {
                this.cNPJField = value;
            }
        }

        /// <summary>
        /// Órgão emitente
        /// </summary>
        public string xOrgao {
            get {
                return this.xOrgaoField;
            }
            set {
                this.xOrgaoField = value;
            }
        }

        /// <summary>
        /// Matrícula do agente
        /// </summary>
        public string matr {
            get {
                return this.matrField;
            }
            set {
                this.matrField = value;
            }
        }

        /// <summary>
        /// Nome do agente
        /// </summary>
        public string xAgente {
            get {
                return this.xAgenteField;
            }
            set {
                this.xAgenteField = value;
            }
        }

        /// <summary>
        /// Telefone
        /// </summary>
        public string fone {
            get {
                return this.foneField;
            }
            set {
                this.foneField = value;
            }
        }

        /// <summary>
        /// Sigla da Unidade da Federação
        /// </summary>
        public string UF {
            get {
                return this.ufField;
            }
            set {
                this.ufField = value;
            }
        }

        /// <summary>
        /// Número do Documento de Arrecadação de Receita
        /// </summary>
        public string nDAR {
            get {
                return this.nDARField;
            }
            set {
                this.nDARField = value;
            }
        }

        /// <summary>
        /// Data de emissão do DAR (AAAA-MM-DD)
        /// </summary>
        public string dEmi {
            get {
                return this.dEmiField;
            }
            set {
                this.dEmiField = value;
            }
        }

        /// <summary>
        /// Valor Total constante no DAR
        /// </summary>
        public string vDAR {
            get {
                return this.vDARField;
            }
            set {
                this.vDARField = value;
            }
        }

        /// <summary>
        /// Repartição Fiscal emitente
        /// </summary>
        public string repEmi {
            get {
                return this.repEmiField;
            }
            set {
                this.repEmiField = value;
            }
        }

        /// <summary>
        /// Data de pagamento do DAR (AAAA-MM-DD)
        /// </summary>
        public string dPag {
            get {
                return this.dPagField;
            }
            set {
                this.dPagField = value;
            }
        }
    }
}