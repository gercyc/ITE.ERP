namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Modalidade do frete
    /// 0- Contratação do Frete por conta do Remetente(CIF);
    /// 1- Contratação do Frete por conta do destinatário/remetente(FOB);
    /// 2- Contratação do Frete por conta de terceiros;
    /// 3- Transporte próprio por conta do remetente;
    /// 4- Transporte próprio por conta do destinatário;
    /// 9- Sem Ocorrência de transporte.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeTranspModFrete {

        /// <summary>
        /// 0- Contratação do Frete por conta do Remetente(CIF);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        PorContaRemetenteCIF = 0,

        /// <summary>
        /// 1- Contratação do Frete por conta do destinatário/remetente(FOB);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        DestinatarioOuRemetenteFOB = 1,

        /// <summary>
        /// 2- Contratação do Frete por conta de terceiros;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        PorContaTerceiros = 2,

        /// <summary>
        /// 3- Transporte próprio por conta do remetente;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        ProprioPorContaRemetente = 3,

        /// <summary>
        /// 4- Transporte próprio por conta do destinatário;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        PorContaDestinatario = 4,

        /// <summary>
        /// 9- Sem Ocorrência de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        SemOcorrenciaFrete = 9,
    }
}