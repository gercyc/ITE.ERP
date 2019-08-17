using Common.Math;
using ITSolution.Framework.Common.BaseClasses;
using ITSolution.ServiceFramework.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadKey();
            //IMath obj = WCFUtils.OpenConnection<IMath>("http://localhost:9000/MathController");
            //Console.WriteLine(obj.SomaInt(1,4));
            //obj.ForceCpu();

            RemoteService.RegisterService.StartServices(9000);
            

            Console.ReadKey();
        }
    }
}
