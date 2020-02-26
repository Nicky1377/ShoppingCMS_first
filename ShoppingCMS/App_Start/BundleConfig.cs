using System.Web;
using System.Web.Optimization;

namespace ShoppingCMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/assets/plugins/global/plugins.bundle.js",
                "~/assets/js/scripts.bundle.js",
                "~/assets/plugins/custom/fullcalendar/fullcalendar.bundle.js",
                "~/assets/js/pages/dashboard.js"
            ));

            bundles.Add(new StyleBundle("~/Content/css").Include(


                "~/assets/plugins/custom/fullcalendar/fullcalendar.bundle.rtl.css",
                "~/assets/plugins/global/plugins.bundle.rtl.css",
                "~/assets/css/style.bundle.rtl.css",
                "~/assets/css/skins/header/base/light.rtl.css",
                "~/assets/css/skins/header/menu/light.rtl.css",
                "~/assets/css/skins/brand/dark.rtl.css",
                "~/assets/css/skins/aside/dark.rtl.css",
                "~/assets/css/Custome.css"
            ));

        }
    }
}
