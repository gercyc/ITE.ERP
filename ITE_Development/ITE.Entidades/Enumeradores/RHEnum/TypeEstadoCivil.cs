using System.ComponentModel;

namespace ITE.RH.Enumeradores
{
    public enum TypeEstadoCivil
    {

        Solteiro = 0,
        Casado = 1,
        [Description("Viúvo")]
        Viuvo = 2,
        Separado = 3,
        Amasiado = 4
    }
}
