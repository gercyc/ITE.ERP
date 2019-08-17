using System;

namespace ITE.Forms.Launcher
{
    static class Lancador
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new MenuUtil().Run();
        }
        

    }
}

