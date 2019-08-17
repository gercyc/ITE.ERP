using System;
using System.ComponentModel;

namespace ITE.Entidades.Enumeradores.BorderoEnum
{
    [Flags]
    public enum TypeSituacaoCheque
    {
        Aberto = 0,
        Vencido = 1,
        Compensado = 2,
        Cancelado = 3,
        Devolvido = 4,
        [Description("Aberto/Vencido")]
        Pendente = 5,
        [Description("Vencendo Hoje")]
        VencendoHoje = 6,
        Todos = 6

    }
}
