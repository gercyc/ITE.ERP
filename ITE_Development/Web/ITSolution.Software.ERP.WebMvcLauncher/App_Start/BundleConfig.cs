using System.Web;
using System.Web.Optimization;

namespace ITSolution.Software.ERP.WebMvcLauncher
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //Core
                        "~/assets/js/plugins/jquery/dist/jquery.min.js",
                        "~/assets/js/plugins/jquery/dist/core.js",
                        "~/assets/js/plugins/jquery/dist/jquery.slim.min.js",
                        //"~/Scripts/jquery-{version}.js",
                        //Optional JS
                        "~/assets/js/plugins/chart.js/dist/Chart.min.js",
                        "~/assets/js/plugins/chart.js/dist/Chart.extension.js",
                        //Argon JS
                        "~/assets/js/argon-dashboard.min.js"
                        ));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/assets/js/plugins/bootstrap/dist/js/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/js/plugins/nucleo/css/nucleo.css",
                      "~/assets/js/plugins/@fortawesome/fontawesome-free/css/all.min.css",
                      "~/assets/css/argon-dashboard.css"));
        }
    }
}
