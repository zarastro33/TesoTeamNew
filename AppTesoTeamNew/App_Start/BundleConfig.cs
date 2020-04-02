using System.Web;
using System.Web.Optimization;

namespace AppTesoTeamNew
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/ajax").Include(
               "~/Scripts/ajax-form.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapxyz").Include(
                "~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/contact").Include(
                "~/Scripts/contact.js"));
            bundles.Add(new ScriptBundle("~/bundles/gijgo").Include(
                "~/Scripts/gijgo.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/imagesloaded").Include(
                "~/Scripts/imagesloaded.pkgd.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/isotope").Include(
                "~/Scripts/isotope.pkgd.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-1.12.4.min").Include(
                "~/Scripts/jquery-{version}.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.ajaxchimp.min").Include(
                "~/Scripts/jquery.ajaxchimp.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.counterup.min").Include(
                "~/Scripts/jquery.counterup.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.form").Include(
                            "~/Scripts/jquery.form.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.magnific-popup.min").Include(
                            "~/Scripts/jquery.magnific-popup.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.scrollUp.min").Include(
                            "~/Scripts/jquery.scrollUp.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.slicknav.min").Include(
                            "~/Scripts/jquery.slicknav.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.validate.min").Include(
                            "~/Scripts/jquery.validate.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/mail-script").Include(
                "~/Scripts/mail-script.js"));
            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                "~/Scripts/main.js"));
            bundles.Add(new ScriptBundle("~/bundles/mio").Include(
                "~/Scripts/mio.js"));
            bundles.Add(new ScriptBundle("~/bundles/nice-select.min").Include(
                "~/Scripts/nice-select.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/owl.carousel.min").Include(
                "~/Scripts/owl.carousel.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                "~/Scripts/plugins.js"));
            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                "~/Scripts/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/scrollIt").Include(
                "~/Scripts/scrollIt.js"));
            bundles.Add(new ScriptBundle("~/bundles/waypoints.min").Include(
                "~/Scripts/waypoints.js"));
            bundles.Add(new ScriptBundle("~/bundles/wow.min").Include(
                "~/Scripts/wow.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/animate.css",
                "~/Content/flaticon.css",
                "~/Content/font-awesome.min.css",
                "~/Content/gijgo.css",
                "~/Content/magnific-popup.css",
                "~/Content/nice-select.css",
                "~/Content/owl.carousel.min.css",
                "~/Content/slicknav.css",
                "~/Content/style.css",
                "~/Content/theme-default.css",
                "~/Content/themify-icons"));
        }
    }
}
