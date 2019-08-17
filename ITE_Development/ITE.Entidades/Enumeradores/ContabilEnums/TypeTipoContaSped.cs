

using System.ComponentModel;

namespace ITE.Entidades.Enumeradores.ContabilEnums
{
    public enum TypeTipoContaSped
    {
        [Description("Contas de ativo")]
        ContasAtivo = 01,
        [Description("Contas de passivo")]
        ContasPassivo = 02,
        [Description("Patrimônio Líquido")]
        PatrimonioLiquido = 03,
        [Description("Contas de resultado")]
        ContasResultado = 04,
        [Description("Contas de compensação")]
        ContasCompensacao = 05,
        [Description("Outras")]
        Outras = 09,

    }
}
