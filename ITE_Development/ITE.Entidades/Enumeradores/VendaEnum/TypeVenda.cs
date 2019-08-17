
using System.ComponentModel;

namespace ITE.Entidades.Enumeradores
{
    public enum TypeVenda
    {
        //Venda 
        [Description("Venda")]
        Venda = 1,

        //Nao gera movimento no caixa
        [Description("Cotação")]
        Cotacao = 2,

        //Venda a prazo (somente em tempo de execução
        //Utilizado para tomada de decisão
        [Description("Venda á Prazo")]
        VendaPrazo = 3,

    }
}
