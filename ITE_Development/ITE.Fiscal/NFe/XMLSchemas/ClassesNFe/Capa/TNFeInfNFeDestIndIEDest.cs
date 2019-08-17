namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Indicador da IE do destinatário:
    ///1 – Contribuinte ICMSpagamento à vista;
    ///2 – Contribuinte isento de inscrição;
    ///9 – Não Contribuinte
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDestIndIEDest {
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        ContribuinteICMSpagamentoAvista = 1,
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        ContribuinteIsentoInscricao = 2,
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        NaoContribuinte = 9,
    }
}