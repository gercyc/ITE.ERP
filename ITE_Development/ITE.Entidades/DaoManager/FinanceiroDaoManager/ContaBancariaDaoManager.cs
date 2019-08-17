using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;

namespace ITE.Entidades.DaoManager.FinanceiroDaoManager
{
    public class ContaBancariaDaoManager
    {

        public ContaBancaria GetContaDefault()
        {
            ContaBancaria conta = null;
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var contas = ctx.ContaBancariaDao.FindAll();

                    //recupera a conta padrao se ela existir
                    conta = ParametroDaoManager.GetContaBancariaDefault();

                    if (conta == null)
                    {

                        //se existe so uma conta
                        if (contas.Count == 1)
                        {
                            //então ela será usada como conta principal
                            //se tem so uma use ela 
                            conta = contas[0];

                            //add essa conta como padrão se ela nao existir
                            ParametroDaoManager.AddContaBancariaDefault(conta);
                        }
                    } //se nao for null entao ja eh a padrão

                    if (conta != null && contas.Count == 1)
                        return conta;
                }
            }
            catch
            {
                //Whatever se deu certo ou nao => usuario se vira pra add 
             
            }
            return conta;
        }
    }
}
