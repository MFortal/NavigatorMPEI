using System.Web.Optimization;

namespace Navigator
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Scripts/js").Include(
                      "~/Scripts/Script.js"));

            bundles.Add(new StyleBundle("~/Scripts/ajax").Include(
                      "~/Scripts/jquery-3.5.0.js",
                      "~/Scripts/jquery.unobtrusive-ajax.js",
                      "~/Scripts/jquery.unobtrusive-ajax.min.js"));
        }
    }
}
