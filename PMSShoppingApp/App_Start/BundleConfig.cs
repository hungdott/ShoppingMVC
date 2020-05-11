using System.Web;
using System.Web.Optimization;

namespace PMSShoppingApp
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

            
            bundles.Add(new StyleBundle("~/bundles/bootstrapv4").Include(
                "~/Assets/ContentCommon/vendor/bootstrap/css/bootstrap.min.css"
                ));
            bundles.Add(new StyleBundle("~/bundles/fontawsv4").Include(
                "~/Assets/ContentCommon/fonts/font-awesome-4.7.0/css/font-awesome.min.css"
                ));
            bundles.Add(new StyleBundle("~/bundles/iconic").Include(
                "~/Assets/ContentCommon/fonts/iconic/css/material-design-iconic-font.min.css"
                ));
            bundles.Add(new StyleBundle("~/bundles/animate").Include(
                "~/Assets/ContentCommon/vendor/animate/animate.css"
                ));
            bundles.Add(new StyleBundle("~/bundles/hamburgers").Include(
                "~/Assets/ContentCommon/vendor/css-hamburgers/hamburgers.min.css"
                ));
            bundles.Add(new StyleBundle("~/bundles/animsition").Include(
                "~/Assets/ContentCommon/vendor/animsition/css/animsition.min.css"
                ));
            bundles.Add(new StyleBundle("~/bundles/select2").Include(
                "~/Assets/ContentCommon/vendor/select2/select2.min.css"
                ));
            bundles.Add(new StyleBundle("~/bundles/daterangepicker").Include(
                "~/Assets/ContentCommon/vendor/daterangepicker/daterangepicker.css"
                ));
            bundles.Add(new StyleBundle("~/bundles/materialicon").Include(
                "~/Assets/ContentCommon/fonts/material-icon/css/material-design-iconic-font.min.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryv32").Include(
                "~/Assets/ContentCommon/vendor/jquery/jquery-3.2.1.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/animsitionjs").Include(
                "~/Assets/ContentCommon/vendor/animsition/js/animsition.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/popperjs").Include(
                "~/Assets/ContentCommon/vendor/bootstrap/js/popper.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs").Include(
                "~/Assets/ContentCommon/vendor/bootstrap/js/bootstrap.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/select2js").Include(
                "~/Assets/ContentCommon/vendor/select2/select2.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/momentjs").Include(
                "~/Assets/ContentCommon/vendor/daterangepicker/moment.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/daterangepickerjs").Include(
                "~/Assets/ContentCommon/vendor/daterangepicker/daterangepicker.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/countdowntimejs").Include(
                "~/Assets/ContentCommon/vendor/countdowntime/countdowntime.js"
                ));


            //login bundle
            bundles.Add(new StyleBundle("~/bundles/loginstyle").Include(
                "~/Assets/Login/css/main.css",
                "~/Assets/Login/css/util.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/loginjs").Include(
               "~/Assets/Login/js/main.js"
               ));
            //signin
            bundles.Add(new StyleBundle("~/bundles/signin").Include(
                "~/Assets/SignUp/style.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/signinjs").Include(
                "~/Assets/SignUp/main.js"
                ));
            //errorFrendly
            bundles.Add(new StyleBundle("~/bundles/errorFrendly").Include(
                "~/Assets/ContentCommon/errorFrendly/errorFrendly.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/errorFrendlyjs").Include(
                "~/Assets/ScriptCommon/errorFrendly/errorFrendly.js"
                ));
            //successFrendly
            bundles.Add(new StyleBundle("~/bundles/successFrendly").Include(
                "~/Assets/ContentCommon/errorFrendly/successFrendly.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/successFrendlyjs").Include(
                "~/Assets/ScriptCommon/errorFrendly/successFrendly.js"
                ));

        }
    }
}
