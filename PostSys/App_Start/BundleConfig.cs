using System.Web;
using System.Web.Optimization;

namespace PostSys
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));

			bundles.Add(new StyleBundle("~/FrontEnd/assets/css").Include(
				"~/FrondEnd/assets/css/styles.css"));

			bundles.Add(new ScriptBundle("~/FrontEnd/assets/js").Include(
				"~/FrontEnd/assets/js/pcoded.min.js",
				"~/FrontEnd/assets/js/vendor-all.min.js"));

			bundles.Add(new StyleBundle("~/FrontEnd/plugin/css").Include(
				"~/FrontEnd/assets/plugins/animation/css/animate.min.css"));

			bundles.Add(new StyleBundle("~/FrontEnd/plugins/bootstrap/css").Include(
				"~/FrontEnd/assets/plugins/bootstrap/css/bootstrap.css",
				"~/FrontEnd/assets/plugins/bootstrap/css/bootstrap.min.css"));

			bundles.Add(new ScriptBundle("~/FrontEnd/plugins/bootstrap/js").Include(
				"~/FrontEnd/assets/plugins/bootstrap/js/bootstrap.js",
				"~/FrontEnd/assets/plugins/bootstrap/js/bootstrap.min.js",
				"~/FrontEnd/assets/plugins/bootstrap/js/popover.js"));

			bundles.Add(new StyleBundle("~/css").Include(
					  "~/css/bootstrap.css",
					  "~/css/fontawesome-all.css",
					  "~/css/styles.css",
					  "~/css/magnific-popup.css",
					  "~/css/swiper.css"));

			bundles.Add(new ScriptBundle("~/js").Include(
					  "~/js/bootstrap.min.js",
					  "~/js/jquery.easing.min.js",
					  "~/js/jquery.magnific-popup.js",
					  "~/js/jquery.min.js",
					  "~/js/popper.min.js",
					  "~/js/scritps.js",
					  "~/js/swiper.min.js",
					  "~/js.validator.min.js"));

		}
	}
}
