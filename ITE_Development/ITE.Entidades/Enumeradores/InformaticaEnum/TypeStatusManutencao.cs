using System.ComponentModel;

namespace ITE.Entidades.Enumeradores
{
    public enum TypeStatusManutencao
    {
        [Description("Em Atendimento Local")]
        AtendimentoLocal = 0,

        [Description("Em Andamento")]
        Andamento = 1,

        Encerrado = 2,

        Cancelado = 3,

        Pendente = 4
    }
}
