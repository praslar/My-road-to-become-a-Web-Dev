using DataAccess;
using DLU.App_DLU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLU.Areas.Admin.Controllers.QLThi
{
    public class DiemThiController : Alert
	{
		QuanLyThi qlt = new QuanLyThi();
        // GET: Admin/DiemThi
        public ActionResult Index()
        {
			ViewBag.Diemthi = qlt.HienThiDiemThi();
            return View();
        }

		public JsonResult Get_ByID(int ID)
		{
			var x = Json(new { data = qlt.Get_DS_DiemThi_By_ID(ID) });
			return x;
		}
		public JsonResult Get_TenMonHoc(int ID)
		{
			return Json(new { data = qlt.Get_TenMonHoc(ID) });
		}

		public JsonResult Get_TenHocKi(int ID)
		{
			return Json(new { data = qlt.Get_TenHocKi(ID) });
		}

		public JsonResult Get_TenDotThi(int ID)
		{
			return Json(new { data = qlt.Get_TenDotThi(ID) });
		}

		public JsonResult Get_DiemThi_ALL()
		{
			var x = Json(new { data = qlt.HienThiDiemThi() });
			return x;
		}

		public JsonResult Delete(int ID_Delete)
		{
			if (qlt.Xoa_DiemThi(ID_Delete) > 0)
			{

				return Json(new { data = true });
			}
			else
			{

				return Json(new { data = false });
			}
		}

		//public JsonResult Create(int ID, int IDHOCKI, int IDDOTTHI, int  )
		//{
		//	HOCKI n = new HOCKI();
		//	n.IDHOCKI = 0;
		//	n.TENHOCKI = TenHocKi;
		//	n.MOTA = MoTa;
		//	if (qlt.Them_HocKi(n) > 0)
		//	{
		//		SetAlert("Thêm thành công", "success");
		//		return Json(new { data = true });
		//	}
		//	else
		//	{
		//		return Json(new { data = false });
		//	}
		//}
		//public JsonResult Edit(int ID, string TenHocKi, string MoTa)
		//{
		//	HOCKI n = new HOCKI();
		//	n.IDHOCKI = ID;
		//	n.TENHOCKI = TenHocKi;
		//	n.MOTA = MoTa;
		//	if (qlt.Sua_HocKi(n) > 0)
		//	{

		//		return Json(new { data = true });
		//	}
		//	else
		//	{
		//		return Json(new { data = false });
		//	}
		//}

	}
}