using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Fiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.DaoManager.FiscalDaoManager
{
    [ServiceContract(Name = "MovimentoContract", ConfigurationName = "IMovimentoContract", Namespace = "ITE.Services")]
    public interface IMovimentoDaoManager
    {
        [OperationContract]
        bool UpdateMovimentoFiscal(Movimento movimento, Movimento novoMovimento, List<ItemMovimento> itensRemovidos, Usuario user);
        [OperationContract]
        bool SalvarMovimento(Movimento movimento);
    }
}
