namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{

    /// <summary>
    /// Indicador de presença do comprador no estabelecimento comercial no momento da oepração
    ///(0-Não se aplica(ex.: Nota Fiscal complementar ou de ajuste;1-Operação presencial;2-Não presencial, internet;3-Não presencial, teleatendimento;4-NFC-e entrega em domicílio;5-Operação presencial, fora do estabelecimento;9-Não presencial, outros)
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndPres
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        NaoSeAplica = 0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        OperacaoPresencial = 1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        NaoPresencialInternet = 2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        NaoPresencial = 3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        NFCeEntradaDomicilio = 4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        OperacaoPresencialForaEstabelecimento = 5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        NaoPresencialOutros = 9,
    }
}