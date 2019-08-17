namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Modalidade de determinação da BC do ICMS ST:
    ///0 – Preço tabelado ou máximo  sugerido;
    ///1 - Lista Negativa(valor);
    ///2 - Lista Positiva(valor);
    ///3 - Lista Neutra(valor);
    ///4 - Margem Valor Agregado(%);
    ///5 - Pauta(valor);
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TypeModalidadeBaseCalculoICMSST
    {
        /// <summary>
        /// 0 – Preço tabelado ou máximo  sugerido;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        PrecoTabeladoOuMaxSugerido = 0,
        
        /// <summary>
        /// 1 - Lista Negativa(valor);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        ListaNegativaValor = 1,
        
        /// <summary>
        /// 2 - Lista Positiva(valor);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        ListaPositivaValor = 2,
        
        /// <summary>
        /// 3 - Lista Neutra(valor);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        ListaNeutraValor = 3,
        
        /// <summary>
        /// 4 - Margem Valor Agregado(%);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        MargemValorAgregado = 4,
        
        /// <summary>
        /// 5 - Pauta(valor);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Pauta = 5,
    }
}