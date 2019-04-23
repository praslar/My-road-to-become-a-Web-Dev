using System.Web;
using System.Web.Optimization;

namespace DLU
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            //-------------------------------- Css and Javascript ----------------------------------------------//
            bundles.Add(new ScriptBundle("~/bundles/javascript/Back-end").Include(
                        "~/Content/Back-end/bower_components/jquery/dist/jquery.min.js",
                        "~/Content/Back-end/bower_components/bootstrap/dist/js/bootstrap.js",
                        "~/Content/Back-end/bower_components/bootstrap-daterangepicker/daterangepicker.js",
                        "~/Content/Back-end/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                        "~/Content/Back-end/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                        "~/Content/Back-end/dist/js/adminlte.min.js",
                        "~/Content/Back-end/dist/js/demo.js",
                         "~/Content/Back-end/plugins/iCheck/icheck.js",
                         "~/Content/Back-end/bower_components/select2/dist/js/select2.js",
                         "~/Content/Back-end/dist/js/jquery.bootstrap-growl.js",
                         "~/Content/Back-end/bower_components/datatables.net/js/jquery.dataTables.js",
                         "~/Content/Back-end/bower_components/datatables.net-bs/js/dataTables.bootstrap.js",
                         "~/Content/Back-end/plugins/loading/loading.js",
                         "~/Content/Back-end/plugins/chosen/chosen.jquery.min.js"




                        ));
            bundles.Add(new StyleBundle("~/Content/css/Back-end").Include(
                      "~/Content/Back-end/bower_components/bootstrap/dist/css/bootstrap.css",
                      "~/Content/Back-end/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/Content/Back-end/bower_components/Ionicons/css/ionicons.min.css",
                      "~/Content/Back-end/dist/css/AdminLTE.min.css",
                      "~/Content/Back-end/dist/css/skins/_all-skins.min.css",
                      "~/Content/Back-end/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                      "~/Content/Back-end/bower_components/bootstrap-daterangepicker/daterangepicker.css",
                      "~/Content/Back-end/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                      "~/Content/Back-end/bower_components/select2/dist/css/select2.css",
                      "~/Content/Back-end/plugins/iCheck/all.css",
                      "~/Content/Back-end/bower_components/datatables.net-bs/css/dataTables.bootstrap.css",
                      "~/Content/Back-end/plugins/chosen/chosen.min.css",
                      "~/Content/Back-end/plugins/loading/loading.css"

                      ));
            //-------------------------------- Css end Javascript ----------------------------------------------//

            //-------------------------------- Css and Javascript ----------------------------------------------//
            bundles.Add(new ScriptBundle("~/bundles/javascript/Front-end").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/css/Front-end").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //-------------------------------- Css end Javascript ----------------------------------------------//
        }
    }
}
