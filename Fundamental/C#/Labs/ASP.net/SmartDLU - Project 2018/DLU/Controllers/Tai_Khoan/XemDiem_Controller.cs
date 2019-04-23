using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLU.Controllers.Tai_Khoan
{
    public class XemDiem_Controller : Controller
    {
        QuanLyThi qlt = new QuanLyThi();
        // GET: XemDiem_
        public ActionResult Index()
        {
			int ID = Convert.ToInt32(Session["ID_TaiKhoan_SV"]);
			return View(/*qlt.SelectDiemThiTheoTaiKhoan(ID)*/);
        }

		public ActionResult ChiTietDiem()
		{
			return View();
		}
    }
}