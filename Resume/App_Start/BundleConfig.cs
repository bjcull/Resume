using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;
using System.Web;
using System.Web.Optimization;

namespace Resume
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js/jquery").Include(
                        "~/Public/js/jquery-1.8.3.js"));

            var cssTransformer = new CssTransformer();
            var nullOrderer = new NullOrderer();

            var css = new Bundle("~/bundles/css/site")
                .Include("~/Public/css/bootstrap.css")
                .Include("~/Public/css/bootstrap-responsive.css")
                .Include("~/Public/css/site.less");

            css.Transforms.Add(cssTransformer);
            css.Orderer = nullOrderer;

            bundles.Add(css);
        }
    }
}