using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.Base
{
    [Serializable]
    public class ItsLicenseData
    {
        public CliFor Cliente { get; set; }
        public DateTime DataInicioLic { get; set; }
        public DateTime DataFimLic { get; set; }
        public List<ItsMenu> ActiveMenus { get; set; }
    }
}
