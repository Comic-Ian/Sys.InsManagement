using System.Web;
using System.Web.Optimization;

namespace Sys.web
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Content").Include(
                //"~/Content/Site.css",
                "~/Content/bootstrap.css",
                "~/Content/bootstrap.min.css",
                "~/Content/global.css",
                "~/Content/public.css",
                "~/Content/qqkf.css",
                "~/Content/skin.css"

                ));

            bundles.Add(new ScriptBundle("~/Scripts").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootstrap.min.js"
                ));
        }
    }
}
