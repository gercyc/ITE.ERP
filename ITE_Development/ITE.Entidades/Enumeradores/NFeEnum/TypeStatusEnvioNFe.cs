using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.Enumeradores.NFeEnum
{
    public enum TypeStatusEnvioNFe
    {
        [Description("Não enviada")]
        NaoEnviada = 0,
        [Description("XML gerado")]
        XmlGerado = 1,
        [Description("XML validado")]
        XmlValido = 2,
        [Description("XML inválido")]
        XmlInvalido = 3,
        [Description("NFe Assinada")]
        Assinada = 4,
        [Description("NFe Autorizada")]
        Autorizada = 5,
        [Description("NFe Cancelada")]
        Cancelada = 6,
        [Description("NFe Denegada")]
        Denegada = 7
    }
}
