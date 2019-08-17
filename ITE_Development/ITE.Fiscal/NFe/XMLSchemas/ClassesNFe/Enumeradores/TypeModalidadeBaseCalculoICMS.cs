using System.ComponentModel;

namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Modalidade de determinação da BC do ICMS:
    ///0 - Margem Valor Agregado(%);
    ///1 - Pauta(valor);
    ///2 - Preço Tabelado Máximo(valor);
    ///3 - Valor da Operação.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TypeModalidadeBaseCalculoICMS
    {

        /// <summary>
        /// 0 - Margem Valor Agregado(%);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        [Description("0 - Margem Valor Agregado(%);")]
        MargemValorAgregado = 0,

        /// <summary>
        /// 1 - Pauta(valor);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        [Description("1 - Pauta(valor);")]
        PautaValor = 1,

        /// <summary>
        /// 2 - Preço Tabelado Máximo(valor);
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        [Description("2 - Preço Tabelado Máximo(valor);")]
        PrecoTabeladoMaximo = 2,

        /// <summary>
        /// 3 - Valor da Operação.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        [Description("3 - Valor da Operação.")]
        ValorOperacao = 3,
    }
}