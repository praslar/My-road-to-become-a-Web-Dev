using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
namespace DLU.Areas.Admin.Controllers.TaiKhoan
{
    public class DanhSachThiController : Controller
    {
        DataAccess.BaseMethods<LICHTHI> objlichthi = new BaseMethods<LICHTHI>();
        DataAccess.QL_TaiKhoan objTK = new QL_TaiKhoan();
        // GET: Admin/DanhSachThi
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Get_LichThi()
        {
            return Json(new { data = objlichthi.SelectAll() });
        }
        public JsonResult Get_DanhSachTaiKhoanLichThi(int IDLop,int IDLichThi)
        {
            return Json(new { data = objTK.Get_DanhSachTaiKhoanLichThi(IDLop, IDLichThi) });
        }
    }
}