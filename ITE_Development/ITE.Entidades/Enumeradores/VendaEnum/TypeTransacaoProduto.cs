using System.ComponentModel;

namespace ITE.Entidades.Enumeradores
{
    public enum TypeTransacaoProduto
    {
        [Description("Entrada")]
        Entrada = 1,

        [Description("Saída")]
        Saida = 2,

        [Description("Alteração")]
        Alteracao = 3,

        [Description("Cancelamento de vendas")]
        Estorno = 4
    }
}
