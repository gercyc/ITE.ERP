
using System.Globalization;
using System.Management;
using System.Threading;
using System.Windows.Forms;
using System;
using Teste.Teste.Narcos;

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
             new XFrmNarcos().ShowDialog();
        }

        static void InfoPC()
        {
            var pc = System.Windows.Forms.SystemInformation.ComputerName;
            Console.WriteLine("Machine name: {0}", pc);

            //User
            var user = Environment.UserName;
            Console.WriteLine("User: {0}", user);

            //true se 64 bits
            var is64bits = Environment.Is64BitOperatingSystem;
            Console.WriteLine("Arch: {0}", is64bits ? "x64" : "x86");

            ManagementObjectSearcher o = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject mo in o.Get())
                Console.WriteLine("Processador: {0}", mo["Name"]);

            ManagementObjectSearcher objMOS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_BaseBoard");

            foreach (ManagementObject objManagemnet in objMOS.Get())
            {
                try
                {
                    Console.WriteLine("Manufacturer        :" + objManagemnet.GetPropertyValue("Manufacturer").ToString());
                    Console.WriteLine("Product             :" + objManagemnet.GetPropertyValue("Product").ToString());
                    Console.WriteLine("SerialNumber        :" + objManagemnet.GetPropertyValue("SerialNumber").ToString());
                }
                catch (Exception)
                {
                }
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
