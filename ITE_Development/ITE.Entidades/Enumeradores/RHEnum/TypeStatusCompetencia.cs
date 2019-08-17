using System.ComponentModel;

namespace ITE.Entidades.Enumeradores.RHEnum
{
    public enum TypeStatusCompetencia
    {
        [Description("Em edição")]
        EmEdicao = 0,
        Encerrada = 1,
        Cancelada = 2,
        [Description("Financeiro gerado")]
        EncerradaFinanceiro = 3
    }
}
