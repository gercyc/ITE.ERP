using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common.Math
{

    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        int SomaInt(int Num_1, int Num_2);

        [OperationContract]
        void ForceCpu();

        [OperationContract]
        void TestConnection();
    }

}
