using System.ComponentModel;

namespace ITE.Entidades.Enumeradores
{
    public enum TypeFormaPagamento
    {
        [Description("Á Vista")]
        Dinheiro = 1,

        [Description("Cartão de Crédito")]
        Cartao = 2,

        [Description("Boleto Bancário")]
        Boleto = 3,

        [Description("Cheque")]
        Cheque = 4,

        [Description("Á Prazo")]
        Parcelado = 5,
    }
}
