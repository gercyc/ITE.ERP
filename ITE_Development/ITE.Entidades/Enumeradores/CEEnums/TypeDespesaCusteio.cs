using System.ComponentModel;

namespace ITE.Entidades.Enumeradores.CEEnums
{
    public enum TypeDespesaCusteio
    {

        Aduaneira = 0,
        [Description("Não Aduaneira")]
        NaoAduaneira = 1,
        Outras = 2
    }
}
