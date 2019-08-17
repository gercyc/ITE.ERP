namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Motivo da desoneração do ICMS:
    /// 3-Uso na agropecuária;
    /// 9-Outros;
    /// 12-Fomento agropecuário
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public enum TypeMotivoDesoneracaoICMS20 {

        /// <summary>
        /// 3-Uso na agropecuária;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        UsoAgropecuaria = 3,

        /// <summary>
        /// 9-Outros;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Outros = 9,

        /// <summary>
        /// 12-Fomento agropecuário
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        FomentoAgropecuario = 12,
    }
}