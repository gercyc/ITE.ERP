namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Código de Regime Tributário. 
    ///Este campo será obrigatoriamente preenchido com:
    ///1 – Simples Nacional;
    ///2 – Simples Nacional – excesso de sublimite de receita bruta;
    ///3 – Regime Normal.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeEmitCRT {
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        SimplesNacional = 1,
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        SimpleNacionalExcessoSubLimiteRecBruta = 2,
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        RegimeNormal = 3,
    }
}