using System.ComponentModel;

namespace ITE.Entidades.Enumeradores
{
    public enum TypeStatusVenda
    {
        //Vendas  vencidas ou que nao venceram
        Aberto = 1,
        
        //Parcela nunca poderá ser quitada parcialmente
        [Description("Parcialmente Paga")]
        Parcial = 2,

        //Cancela e ou estornado
        Cancelada = 3,

        //Parcela Paga
        [Description("Paga")]
        Paga = 4,

        //Vendas com parcela em atraso
        Vencida = 5,

        //Todos os Status
        Todas = 6,

        
    }
}
