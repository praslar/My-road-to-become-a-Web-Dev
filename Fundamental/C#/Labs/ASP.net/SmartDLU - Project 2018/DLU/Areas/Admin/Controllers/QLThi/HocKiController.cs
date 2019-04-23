using DataAccess;
using DLU.App_DLU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLU.Areas.Admin.Controllers.QLThi
{
    public class HocKiController : Alert
	{
		QuanLyThi qlt = new QuanLyThi();
		// GET: Admin/HocKi
		public ActionResult Index()
        {
			
			ViewBag.Hocki = qlt.HienThihocki();
            return View();
        }

		public JsonResult Get_HocKi_ByID(int ID)
		{
			var x = Json(new { data = qlt.Get_DS_HocKi_By_ID(ID) });
			return x;
		}

		public JsonResult Get_HocKi_ALL()
		{
			var x = Json(new { data = qlt.HienThihocki() });
			return x;
		}

		public JsonResult Delete_HocKi(int ID_Delete)
		{
			if (qlt.Xoa_HocKi(ID_Delete) > 0)
			{

				return Json(new { data = true });
			}
			else
			{

				return Json(new { data = false });
			}
		}

		public JsonResult Create_HocKi(string TenHocKi, string MoTa)
		{
			HOCKI n = new HOCKI();
			n.IDHOCKI = 0;
			n.TENHOCKI = TenHocKi;
			n.MOTA = MoTa;
			if (qlt.Them_HocKi(n) > 0)
			{
				SetAlert("Thêm thành công", "success");
				return Json(new { data = true });
			}
			else
			{
				return Json(new { data = false });
			}
		}
		public JsonResult Edit_DotThi(int ID, string TenHocKi, string MoTa)
		{
			HOCKI n = new HOCKI();
			n.IDHOCKI = ID;
			n.TENHOCKI = TenHocKi;
			n.MOTA = MoTa;
			if (qlt.Sua_HocKi(n) > 0)
			{

				return Json(new { data = true });
			}
			else
			{
				return Json(new { data = false });
			}
		}
	}
}