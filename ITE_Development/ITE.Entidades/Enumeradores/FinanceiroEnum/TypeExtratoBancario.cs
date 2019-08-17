using System.ComponentModel;

namespace ITE.Entidades.Enumeradores
{
    /// <summary>
    /// Enum para identificar o tipo do extrato bancario
    /// Exibir no comboBox de criação manual somente os tipos: SaqueManual, DepositoManual, Transferencia, ChequeManual
    /// </summary>
    public enum TypeExtratoBancario
    {
        [Description("Saque manual")]
        SaqueManual = 0,
        [Description("Saque na baixa")]
        SaqueNaBaixa = 1,
        [Description("Depósito manual")]
        DepositoManual = 2,
        [Description("Depósito na baixa")]
        DepositoNaBaixa = 3,
        [Description("Transerência entre contas")]
        Transferencia = 4,
        [Description("Cheque Manual")]
        ChequeManual = 5,
        [Description("Cheque na baixa")]
        ChequeNaBaixa = 6,
        [Description("Estorno")]
        Estorno = 7
    }
}
