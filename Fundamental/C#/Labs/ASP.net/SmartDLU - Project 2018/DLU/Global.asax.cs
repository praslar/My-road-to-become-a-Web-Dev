using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DLU
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Session_Start()
        {
            Session["ID_TaiKhoan"] = null;
            Session["ID_TaiKhoan_SV"] = null;
            Session["Email_TaiKhoan"] = null;
            Session["Email_TaiKhoan_SV"] = null;
            Session["IDMaCV"] = null;
            Session["KeyPassWord"] = null;


        }
    }
}
