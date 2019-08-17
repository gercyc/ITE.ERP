using System.ComponentModel;

namespace ITE.Entidades.Enumeradores
{
    public enum TypeMovimentacaoMonetaria
    {
        [Description("Débito")]
        Debito = 0,

        [Description("Crédito")]
        Credito = 1,

        Estorno = 2,
    }
}
