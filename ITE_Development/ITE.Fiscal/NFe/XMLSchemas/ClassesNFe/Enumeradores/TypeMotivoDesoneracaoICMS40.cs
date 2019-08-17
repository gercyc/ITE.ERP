namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Este campo será preenchido quando o campo anterior estiver preenchido.
    ///Informar o motivo da desoneração:
    ///1 – Táxi;
    ///3 – Produtor Agropecuário;
    ///4 – Frotista/Locadora;
    ///5 – Diplomático/Consular;
    ///6 – Utilitários e Motocicletas da Amazônia Ocidental e Áreas de Livre Comércio(Resolução 714/88 e 790/94 – CONTRAN e suas alterações);
    ///7 – SUFRAMA;
    ///8 - Venda a órgão Público;
    ///9 – Outros
    ///10- Deficiente Condutor
    ///11- Deficiente não condutor
    ///16 - Olimpíadas Rio 2016
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public enum TypeMotivoDesoneracaoICMS40 {

        /// <summary>
        /// 1 – Táxi;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Taxi = 1,

        /// <summary>
        /// 3 – Produtor Agropecuário;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        ProdutorAgropecuario = 3,

        /// <summary>
        /// 4 – Frotista/Locadora;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        FrotistaLocadora = 4,

        /// <summary>
        /// 5 – Diplomático/Consular;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        DiplomaticoConsular = 5,

        /// <summary>
        /// 6 – Utilitários e Motocicletas da Amazônia Ocidental e Áreas de Livre Comércio (Resolução 714/88 e 790/94 – CONTRAN e suas alterações);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        UtilitariosAreaLivreComercio = 6,

        /// <summary>
        /// 7 – SUFRAMA;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Suframa = 7,

        /// <summary>
        /// 8 - Venda a órgão Público;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        VendaOrgaoPublico = 8,

        /// <summary>
        /// 9 – Outros
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Outros = 9,

        /// <summary>
        /// 10- Deficiente Condutor
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        DeficienteCondutor = 10,

        /// <summary>
        /// 11- Deficiente não condutor
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        DeficienteNaoCondutor = 11,

        /// <summary>
        /// 16 - Olimpíadas Rio 2016
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        OlimpiadasRio2016 = 16,
    }
}