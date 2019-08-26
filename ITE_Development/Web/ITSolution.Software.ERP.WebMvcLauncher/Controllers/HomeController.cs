using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITSolution.Framework.BaseClasses.License;
using ITSolution.Framework.BaseClasses.License.POCO;

namespace ITSolution.Software.ERP.WebMvcLauncher.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //GetMenuTree();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetMenuTree()
        {
            var licManager = new LicenseDaoManager();
            var lic = licManager.GetValidLicense();

            return View(lic.LicenseDataUnSerialized.ActiveMenus);
        }
    }
}