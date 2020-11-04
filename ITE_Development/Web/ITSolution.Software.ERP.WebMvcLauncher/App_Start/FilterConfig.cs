using System.Web;
using System.Web.Mvc;

namespace ITSolution.Software.ERP.WebMvcLauncher
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
