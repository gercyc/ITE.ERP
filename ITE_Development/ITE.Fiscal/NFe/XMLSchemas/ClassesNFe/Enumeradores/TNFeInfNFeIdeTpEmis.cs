namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Forma de emissão da NF-e: 
    /// 1 - Normal; 
    /// 2 - Contingência FS; 
    /// 3 - Contingência SCAN; 
    /// 4 - Contingência DPEC; 
    /// 5 - Contingência FSDA; 
    /// 6 - Contingência SVC - AN; 
    /// 7 - Contingência SVC - RS; 9 - Contingência off-line NFC-e
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpEmis
    {

        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Normal = 1,
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        ContingênciaFS = 2,
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        ContingênciaSCAN = 3,
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        ContingênciaDPEC = 4,
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        ContingênciaFSDA = 5,
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        ContingênciaSVCAN = 6,
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        ContingênciaSVCRS = 7,
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        ContingênciaofflineNFCe = 9,

    }
}