using System;
using System.Data;
using System.Data.Sql;
using System.Diagnostics;
using System.IO;
using ITSolution.Framework.Arquivos;

namespace ITE.Teste._Testador
{
    //https://www.codeproject.com/Articles/16917/Getting-File-Version-Information
    static class TesteDll
    {


        private static void InfoVersionDLLs()
        {
            //versao da dll
            var v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            //nome do projeto
            var n = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

            var forms = @"D:\Program Files\TFS\ITE\ITE.Forms\bin\Debug\";

            var files = FileManagerIts.ToFiles(forms, new string[] { ".dll" });
            var outversion = FileManagerIts.DeskTopPath + "\\out.txt";
            foreach (var f in files)
            {
                if (Path.GetFileName(f).StartsWith("ITE."))
                {
                    Console.WriteLine(f);
                    Console.WriteLine("==================================================================================");
                    var currentVersion = FileVersionInfo.GetVersionInfo(f);
                    var oldVersion = FileVersionInfo.GetVersionInfo(f);

                    FileManagerIts.AppendLines(outversion, "File:" + f);
                    FileManagerIts.AppendLines(outversion, "File version:" + currentVersion.FileVersion);
                    FileManagerIts.AppendLines(outversion, "Product version:" + currentVersion.ProductVersion);

                }
            }
        }

   
    }
}
