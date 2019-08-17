using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Math;
using ITSolution.Framework.BaseClasses;

namespace Servers.Math
{
    [ITSolutionServer(typeof(MathController))]
    public class MathController : DefaultServer<MathController>, IMath
    {
        private ITSDBObject itsdbObject1;
        private System.ComponentModel.IContainer components;

        public MathController() : base("Teste")
        {

        }

        public int SomaInt(int Num_1, int Num_2)
        {
            //var server2 = (IMath)Open("http://localhost:9000/MathController.soap");
            return Num_1 + Num_2;
        }
        public void ForceCpu()
        {
            int num = 0;
            while (true)
            {
                num += new Random().Next(1, 999);

                if (num > 100000)
                    num = 0;
               
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.itsdbObject1 = new ITSolution.Framework.BaseClasses.ITSDBObject(this.components);
            // 
            // itsdbObject1
            // 
            this.itsdbObject1.TypedObject = null;

        }

        public void TestConnection()
        {
            
            DataAccess.ExecuteQueryDataTable("select count(1) from usuario");
        }
    }
}
