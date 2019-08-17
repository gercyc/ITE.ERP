using System.ComponentModel;

namespace ITE.Entidades.Enumeradores
{
    public enum TypeStatusAtendimento
    {

        Comunicado = 0,

        [Description("Em Andamento")]
        Andamento = 1,

        Encerrado = 2,
        Cancelado = 3
    }
}
