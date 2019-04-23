using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;

namespace DLU.Areas.Admin.Controllers.QLThi
{
    public class LichThiController : Alert
	{
		QuanLyThi qlt = new QuanLyThi();
		// GET: Admin/LichThi
		public ActionResult Index()
		{
			ViewBag.Lichthi = qlt.HienThiLichThi();
			return View();
		}

		public JsonResult Get_LichThi(int id)
		{
			var x = Json(new { data = qlt.Get_DS_LichThi_By_ID(id) });
			return x;
		}

		public JsonResult Get_ALL()
		{
			var x = Json(new { data = qlt.HienThiLichThi() });
			return x;
		}

		public JsonResult Edit_LichThi(int IDLICHTHI, int IDBODE, int IDDOTTHI, int IDHOCKI, int ID, DateTime NGAYTHI, string GIOTHI, string PHONGTHI)
		{
			LICHTHI lichthi = new LICHTHI();
			lichthi.IDLICHTHI = IDLICHTHI;
			lichthi.IDBODE = IDBODE;
			lichthi.IDDOTTHI = IDDOTTHI;
			lichthi.IDHOCKI = IDHOCKI;
			lichthi.ID = ID;
			lichthi.NGAYTHI = NGAYTHI;
			lichthi.GIOTHI = GIOTHI;
			lichthi.PHONGTHI = PHONGTHI;
			if (qlt.Sua_LichThi(lichthi) > 0)
			{
				SetAlert("Sửa thành công", "success");
				return Json(new { data = true });
			}
			else
			{
				return Json(new { data = false });
			}
		}

		public JsonResult Delete_LichThi(int id)
		{
			qlt.Xoa_LichThi(id);
			SetAlert("Xóa thành công", "success");
			return Json(new { data = true });
		}

		public JsonResult Create_LichThi(int IDBODE, int IDDOTTHI, int IDHOCKI, int ID, DateTime NGAYTHI, string GIOTHI, string PHONGTHI)
		{
			LICHTHI lichthi = new LICHTHI();
			lichthi.IDBODE = IDBODE;
			lichthi.IDDOTTHI = IDDOTTHI;
			lichthi.IDHOCKI = IDHOCKI;
			lichthi.ID = ID;
			lichthi.NGAYTHI = NGAYTHI;
			lichthi.GIOTHI = GIOTHI;
			lichthi.PHONGTHI = PHONGTHI;
			if (qlt.Them_LichThi(lichthi) > 0)
			{
				SetAlert("Thêm thành công", "success");
				return Json(new { data = true });
			}
			else
			{
				return Json(new { data = false });
			}

		}
	}
}