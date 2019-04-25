using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DLU
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //-------------------------------------------Route nhom 09 -----------------------------------------------------//
            routes.MapRoute(
                   name: "DangNhap",
                   url: "dang-nhap",
                   defaults: new { controller = "DangNhap_", action = "Index", id = UrlParameter.Optional }

             );
            routes.MapRoute(
                  name: "ThongTinCaNhan",
                  url: "thong-tin-ca-nhan",
                  defaults: new { controller = "ThongTinCaNhan_", action = "Index", id = UrlParameter.Optional }

            );
            routes.MapRoute(
                 name: "DoiMatKhau",
                 url: "thay-doi-mat-khau",
                 defaults: new { controller = "DoiMatKhau_", action = "Index", id = UrlParameter.Optional }

           );
            routes.MapRoute(
                name: "DoiAvatar",
                url: "thay-doi-hinh-dai-dien",
                defaults: new { controller = "DoiAvatar_", action = "Index", id = UrlParameter.Optional }

          );
            routes.MapRoute(
               name: "XemDiemThi",
               url: "diem-thi",
               defaults: new { controller = "XemDiem_", action = "Index", id = UrlParameter.Optional }

            );
            routes.MapRoute(
              name: "LichSuLamBai",
              url: "lich-su",
              defaults: new { controller = "LichSuLamBai_", action = "Index", id = UrlParameter.Optional }

           );

			//-------------------------------------------end Route nhom 09 -----------------------------------------------------//

			//=========================================== Route nhom 08 ========================================================//

			routes.MapRoute(
				   name: "ThiChinhThuc",
				   url: "thi-that",
				   defaults: new { controller = "ThiChinhThuc_", action = "Index", id = UrlParameter.Optional }

			 );
			routes.MapRoute(
				   name: "CauHoiOnTap",
				   url: "cauhoi-ontap",
				   defaults: new { controller = "CauHoiOnTap_", action = "Index", id = UrlParameter.Optional }

			 );
			routes.MapRoute(
				   name: "ThiThu",
				   url: "thi-thu",
				   defaults: new { controller = "ThiThu_", action = "Index", id = UrlParameter.Optional }

			 );
			//==================================================================================================================//



















			routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "TrangChu_", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
