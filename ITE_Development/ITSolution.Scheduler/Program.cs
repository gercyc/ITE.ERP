using ITSolution.Reflection;
using ITSolution.Scheduler.EntidadesBd;
using ITSolution.Scheduler.Forms;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ITE.Teste
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetTheme();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new XFrmTaskCentral().ShowDialog();
            //teste();

        }
        private static void teste()
        {
            TaskIts task = new TaskIts("ITSolution.Scheduler.Forms.Testes", "Insere", "1");

            //Obtem o tipo especifico
            var instance = ReflectionManagerIts.CreateInstance(task.Classe);
            //testando Set por reflexao
            //instance.SetPropertieValue("ID", "275f24e4-0343-4c78-adf9-74ee6ac06240");
            //testando Get por reflexao
            //var value = instance.GetPropertieValue("ID");
            //saida
            //Console.WriteLine(value);
            //testando invocacao de metodo por reflexao
            //instance.InvokeMethod("MetodoTeste");

            //Console.WriteLine();
            //obtendo paramentos do metodo por reflexao
            var x = instance.GetTypesMethodParameters("Insere");
            
            
            //args
            var values = new object[] { 1000, "275f24e4-0343-4c78-adf9-74ee6ac06240", new CancellationTokenSource() };
            //setando todos os values
            //instance.SetValues(values);
            
            instance.InvokeMethod("Insere", values);
            //obtendo os values
            var result = instance.GetValues();
            //saida
            foreach (var item in result) 
            {
                Console.WriteLine(item);
            }
        }

        static void SetTheme()
        {
            // The following line provides localization for the application's user interface. 
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("pt-BR");

            // The following line provides localization for data formats. 
            Thread.CurrentThread.CurrentCulture =
                new CultureInfo("pt-BR");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Blue";

        }
    }
}
