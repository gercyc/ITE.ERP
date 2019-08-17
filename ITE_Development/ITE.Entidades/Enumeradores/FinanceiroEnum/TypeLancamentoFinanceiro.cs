using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.Enumeradores
{
    public enum TypeLancamentoFinanceiro
    {
        //Contas a Pagar
        Pagar = 0,

        //Contas a Receber
        Receber = 1,

        //Pagar e Receber => Usado apenas em tempo de execucação
        Todos = 2
    }
}
