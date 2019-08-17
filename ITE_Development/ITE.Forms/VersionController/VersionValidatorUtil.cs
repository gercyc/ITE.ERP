using ITE.Entidades.Repositorio;
using ITE.Forms.VersionController.Entidades;
using ITSolution.Framework.Dao.Contexto;
using ITSolution.Framework.Mensagem;
using System;
using System.Collections.Generic;

namespace ITE.Forms.VersionController
{
    public class VersionValidatorUtil
    {

        public List<ItsVersionControl> GetInstalledAssemblies()
        {
            var ctx = ITEGenericContext<ItsVersionControl>.Instance;
            return ctx.Dao.FindAll();
        }

        public bool Sincbd(List<ItsVersionControl> assemblies)
        {
            try
            {
                var ctx = ITEGenericContext<ItsVersionControl>.Instance;

                foreach (var asm in assemblies)
                {
                    var current = ctx.Dao.Find(asm.FullName.Trim());
                    
                    if (current == null)
                    {
                        var version = new ItsVersionControl(asm.ClassName, asm.Version, asm.FullName.Trim());
                        ctx.Dao.Save(version);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Erro critico");
                return false;
            }

        }

        public List<ItsVersionControl> AssembliesCarregados(Type type)
        {
            List<ItsVersionControl> assembliesITS = new List<ItsVersionControl>();
            try
            {
                var asm = type.Assembly;

                var assemblies = asm.GetReferencedAssemblies();

                foreach (var assembly in assemblies)
                {
                    if (assembly.FullName.StartsWith("ITE") || assembly.FullName.StartsWith("ITS"))
                    {
                        var version = new ItsVersionControl(assembly.Name, assembly.Version.ToString(), assembly.FullName);

                        assembliesITS.Add(version);
                    }
                }
                return assembliesITS;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Erro critico");
                return assembliesITS;
            }
        }
    }
}
