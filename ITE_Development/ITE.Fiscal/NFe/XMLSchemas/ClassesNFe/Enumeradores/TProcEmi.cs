namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Processo de emissão utilizado com a seguinte codificação:
    ///0 - emissão de NF-e com aplicativo do contribuinte;
    ///1 - emissão de NF-e avulsa pelo Fisco;
    ///2 - emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco;
    ///3- emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public enum TProcEmi {
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Contribuinte = 0,
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        AvulsaFisco = 1,
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        AvulsaContribuinte = 2,
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        ContribuinteFisco,
    }
}