using System.ComponentModel;

namespace ITE.RH.Enumeradores
{
    public enum TypeEvento
    {
        Desconto = 0,
        Provento = 1,
        [Description("Base de Cálculo")]
        BaseCalculo = 2
    }
}
