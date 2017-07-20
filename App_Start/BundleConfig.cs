using System.Web;
using System.Web.Optimization;

namespace TesteBootstrap
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{


			bundles.Add(new StyleBundle("~/bundles/css").Include(
					  "~/Scripts/bootstrap/css/bootstrap.min.css",
					  "~/Scripts/font-awesome/css/font-awesome.min.css",
					  "~/Scripts/magnific-popup/magnific-popup.css",
					   "~/Content/creative.min.css"));

			bundles.Add(new ScriptBundle("~/Scripts/js").Include(
					  "~/Scripts/jquery/jquery.min.js",
					  "~/Scripts/bootstrap/js/bootstrap.min.js",
					  "~/Scripts/scrollreveal/scrollreveal.min.js",
					  "~/Scripts/magnific-popup/jquery.magnific-popup.min.js",
					  "~/Scripts/creative.min.js"));

		}
	}
}
