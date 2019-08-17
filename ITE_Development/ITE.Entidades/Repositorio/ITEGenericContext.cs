using ITSolution.Framework.Dao.Contexto;
using System.Configuration;

namespace ITE.Entidades.Repositorio
{
    public class ITEGenericContext<T> : GenericContextIts<T> where T : class
    {

        public ITEGenericContext()
                  : base(AppConfigManager.Configuration.ConnectionString)
        {

        }

        public static ITEGenericContext<T> Instance { get { return new ITEGenericContext<T>(); } }


    }
}
