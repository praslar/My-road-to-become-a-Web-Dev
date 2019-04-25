using DataAccess;
using DLU.App_DLU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLU.Areas.Admin.Controllers.QLThi
{
    public class DotThiController : Alert
	{
		QuanLyThi qlt = new QuanLyThi();
		// GET: Admin/DotThi
		public ActionResult Index()
        {
			
			ViewBag.Dotthi = qlt.HienThidotthi();
            return View();
        }

		public JsonResult Get_DotThi_ByID(int ID)
		{
			var x = Json(new { data = qlt.Get_DS_DotThi_By_ID(ID) });
			return x;
		}

		public JsonResult Get_DotThi_ALL()
		{
			var x = Json(new { data = qlt.HienThidotthi() });
			return x;
		}

		public JsonResult Delete_DotThi(int ID_Delete)
		{
			if (qlt.Xoa_DotThi(ID_Delete) > 0)
			{

				return Json(new { data = true });
			}
			else
			{

				return Json(new { data = false });
			}
		}

		public JsonResult Create_DotThi(string TenDotThi, string MoTaDotThi)
		{
			DOTTHI n = new DOTTHI();
			n.IDDOTTHI = 0;
			n.TENDOTTHI = TenDotThi;
			n.MOTA = MoTaDotThi;
			if (qlt.Them_DotThi(n) > 0)
			{
				SetAlert("Thêm thành công", "success");
				return Json(new { data = true });
			}
			else
			{
				return Json(new { data = false });
			}
		}
		public JsonResult Edit_DotThi(int ID, string TenDotThi, string MoTaDotThi)
		{
			DOTTHI n = new DOTTHI();
			n.IDDOTTHI = ID;
			n.IDDOTTHI = 0;
			n.TENDOTTHI = TenDotThi;
			n.MOTA = MoTaDotThi;
			if (qlt.Sua_DotThi(n) > 0)
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