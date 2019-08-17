using System.ComponentModel;

namespace ITE.Entidades.Enumeradores
{
    public enum TypeStatusLancamentoFinanceiro
    {
        [Description("Aberto")]
        Aberto = 0,

        [Description("Pago")]
        Pago = 1,

        [Description("Vencido")]
        Vencido = 2,

        [Description("Cancelado")]
        Cancelado = 3,

        [Description("Pendentes")]
        Pendente = 4,

        [Description("Todos os status")]
        Todos = 5,
    }
}
