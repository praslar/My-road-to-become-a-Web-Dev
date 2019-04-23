using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;
namespace DLU.Areas.Admin.Controllers.TaiKhoan
{
    public class LopController : Alert
    {
        QL_Lop objLop = new QL_Lop();
        public ActionResult Index()
        {

            if (Session["ID_TaiKhoan"] != null)
            {
                if (Session["IDMaCV"].ToString() == "GV")
                {
                    SetAlert("Bạn không có quyên truy cập vào chức năng nầy xin cảm ơn", "danger");
                    return RedirectToAction("Index", "TrangChu");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();

            }
        }
        public JsonResult Get_Lop_ByID(int ID)
        {
            var x = Json(new { data = objLop.Get_DanhSach_By_ID(ID) });
            return x;
        }
        public JsonResult Get_Lop_ALL()
        {
            var x = Json(new { data = objLop.Get_DanhSach_Lop() });
            return x;
        }
        public JsonResult Delete_Lop(int ID_Delete)
        {
            try { 
                if(objLop.Delete(ID_Delete) >0)
                {
                
                    return Json(new { data = true });
                }
                else
                {
                
                    return Json(new { data = false });
                }
            }
            catch
            {
                return Json(new { data = false });
            }
        }
        public JsonResult Create_Lop(string TenLop,string MoTaLop)
        {
            Lop n = new Lop();
            n.ID = 0;
            n.TenLop = TenLop;
            n.MoTaLop = MoTaLop;
            n.TrangThai = true;
            if (objLop.Them_Lop(n) > 0)
            {
                SetAlert("Thêm thành công", "success");
                return Json(new { data = true });
            }
            else
            {
                return Json(new { data = false });
            }
        }
        public JsonResult Edit_Lop(int ID, string TenLop, string MoTaLop)
        {
            Lop n = new Lop();
            n.ID = ID;
            n.TenLop = TenLop;
            n.MoTaLop = MoTaLop;
            n.TrangThai = true;
            if (objLop.Sua_Lop(n) > 0)
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