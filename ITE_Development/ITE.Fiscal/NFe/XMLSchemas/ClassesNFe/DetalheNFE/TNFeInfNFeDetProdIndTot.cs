namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Este campo deverá ser preenchido com:
    ///0 – o valor do item(vProd) não compõe o valor total da NF-e(vProd)
    ///1  – o valor do item(vProd) compõe o valor total da NF-e(vProd)
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdIndTot {
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        ValorProdutoNaoCompoeTotalNF = 0,
    
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        ValorProdutoCompoeTotalNF = 1,
    }
}