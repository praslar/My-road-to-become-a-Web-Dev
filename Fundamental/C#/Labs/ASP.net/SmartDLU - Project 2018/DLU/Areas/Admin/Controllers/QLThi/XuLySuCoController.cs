using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLU.Areas.Admin.Controllers.QLThi
{
    public class XuLySuCoController : Controller
    {
		QuanLyThi qlt = new QuanLyThi();
		// GET: Admin/XuLySuCo
		public ActionResult Index()
        {
			ViewBag.Xulysuco = qlt.Hienthixulysuco();
            return View();
        }
    }
}