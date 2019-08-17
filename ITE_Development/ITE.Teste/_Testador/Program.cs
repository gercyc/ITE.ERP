using System;
using System.Globalization;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace ITE.Teste._Testador
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // TaskUpdateManager.UpdateDllsFromDisk();
            InfoPC();



        }

        static void InfoPC()
        {
            ManagementObjectSearcher s2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject mo in s2.Get())
                Console.WriteLine("Processador: {0}", mo["Name"]);


            ManagementObjectSearcher objMOS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_BaseBoard");

            foreach (ManagementObject objManagemnet in objMOS.Get())
            {
                try
                {
                    Console.WriteLine("======================================================================");
                    Console.WriteLine("                Detalhes da Placa Mãe                                 ");
                    Console.WriteLine("======================================================================");
                    Console.WriteLine("Caption             :" + objManagemnet.GetPropertyValue("Caption").ToString());
                    Console.WriteLine("CreationClassName   :" + objManagemnet.GetPropertyValue("CreationClassName").ToString());
                    Console.WriteLine("Description         :" + objManagemnet.GetPropertyValue("Description").ToString());
                    Console.WriteLine("InstallDate         :" + Convert.ToDateTime(objManagemnet.GetPropertyValue("InstallDate")));
                    Console.WriteLine("Manufacturer        :" + objManagemnet.GetPropertyValue("Manufacturer").ToString());
                    Console.WriteLine("Model               :" + Convert.ToString(objManagemnet.GetPropertyValue("Model")));
                    Console.WriteLine("Name                :" + objManagemnet.GetPropertyValue("Name").ToString());
                    Console.WriteLine("PartNumber          :" + Convert.ToInt32(objManagemnet.GetPropertyValue("PartNumber")));
                    Console.WriteLine("PoweredOn           :" + objManagemnet.GetPropertyValue("PoweredOn").ToString());
                    Console.WriteLine("Product             :" + objManagemnet.GetPropertyValue("Product").ToString());
                    Console.WriteLine("SerialNumber        :" + objManagemnet.GetPropertyValue("SerialNumber").ToString());
                    Console.WriteLine("SKU                 :" + Convert.ToString(objManagemnet.GetPropertyValue("SKU")));
                    Console.WriteLine("Status              :" + Convert.ToString(objManagemnet.GetPropertyValue("Status")));
                    Console.WriteLine("Tag                 :" + Convert.ToString(objManagemnet.GetPropertyValue("Tag")));
                    Console.WriteLine("Version             :" + Convert.ToString(objManagemnet.GetPropertyValue("Version")));
                    Console.WriteLine("Weight              :" + Convert.ToString(objManagemnet.GetPropertyValue("Weight")));
                    Console.WriteLine("Height              :" + Convert.ToString(objManagemnet.GetPropertyValue("Height")));
                    Console.WriteLine("PoweredOn           :" + Convert.ToString(objManagemnet.GetPropertyValue("PoweredOn")));
                }
                catch (Exception ex) { }
            }

        }


        static void SetTheme()
        {
            // The following line provides localization for the application's user interface. 
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("pt -BR");

            // The following line provides localization for data formats. 
            Thread.CurrentThread.CurrentCulture =
                new CultureInfo("pt-BR");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Blue";
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2013 Light Gray";

        }





    }
}
