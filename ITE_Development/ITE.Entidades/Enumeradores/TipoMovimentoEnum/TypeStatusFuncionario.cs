using System.ComponentModel;

namespace ITE.RH.Enumeradores
{
    public enum TypeSituacaoFuncionario
    {
        Admitido = 0,
        Demitido = 1,
        Afastado = 2,
        [Description("Férias")]
        Ferias = 3,

    }
}
