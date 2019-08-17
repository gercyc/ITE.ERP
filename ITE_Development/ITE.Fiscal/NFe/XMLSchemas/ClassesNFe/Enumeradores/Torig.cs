using System.ComponentModel;

namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    ///Tipo Origem da mercadoria CST ICMS  origem da mercadoria: 
    ///0-Nacional exceto as indicadas nos códigos 3, 4, 5 e 8;
    ///1-Estrangeira - Importação direta; 
    ///2-Estrangeira - Adquirida no mercado interno; 
    ///3-Nacional, conteudo superior 40% e inferior ou igual a 70%; 
    ///4-Nacional, processos produtivos básicos; 
    ///5-Nacional, conteudo inferior 40%; 
    ///6-Estrangeira - Importação direta, com similar nacional, lista CAMEX; 
    ///7-Estrangeira - mercado interno, sem simular,lista CAMEX;
    ///8-Nacional, Conteúdo de Importação superior a 70%.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum Torig
    {

        /// <summary>
        /// 0-Nacional exceto as indicadas nos códigos 3, 4, 5 e 8;
        /// </summary>
        [Description("0-Nacional exceto as indicadas nos códigos 3, 4, 5 e 8;")]
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Nacional = 0,
        /// <summary>
        /// 1-Estrangeira - Importação direta; 
        /// </summary>
        [Description("1-Estrangeira - Importação direta;")]
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Estrangeira = 1,

        /// <summary>
        /// 2-Estrangeira - Adquirida no mercado interno;
        /// </summary>
        [Description("2-Estrangeira - Adquirida no mercado interno;")]
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        EstrangeiraImportIndireta = 2,

        /// <summary>
        /// 3-Nacional, conteudo superior 40% e inferior ou igual a 70%; 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        [Description("3-Nacional, conteudo superior 40% e inferior ou igual a 70%;")]
        EstrangeiraAdquiridaMercInterno = 3,

        /// <summary>
        /// 4-Nacional, processos produtivos básicos; 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        [Description("4-Nacional, processos produtivos básicos; ")]
        NacionalProcessoBasico = 4,

        /// <summary>
        /// 5-Nacional, conteudo inferior 40%; 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        [Description("5-Nacional, conteudo inferior 40%; ")]
        NacionalConteudoMenor40 = 5,

        /// <summary>
        /// 6-Estrangeira - Importação direta, com similar nacional, lista CAMEX;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        [Description("6-Estrangeira - Importação direta, com similar nacional, lista CAMEX;")]
        EstrangeiraImportIndiretaCAMEX = 6,

        /// <summary>
        /// 7-Estrangeira - mercado interno, sem simular,lista CAMEX;
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        [Description("7-Estrangeira - mercado interno, sem simular,lista CAMEX;")]
        EstrangeiraAdquiridaMercInternoCAMEX = 7,

        /// <summary>
        /// 8-Nacional, Conteúdo de Importação superior a 70%.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        [Description("8-Nacional, Conteúdo de Importação superior a 70%.")]
        NacionalConteudoMaior70 = 8,
    }
}