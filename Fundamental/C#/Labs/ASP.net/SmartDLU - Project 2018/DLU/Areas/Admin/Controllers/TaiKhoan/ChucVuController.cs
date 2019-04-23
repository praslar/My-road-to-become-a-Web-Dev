using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;
namespace DLU.Areas.Admin.Controllers.TaiKhoan
{
    public class ChucVuController : Alert
    {
        BaseMethods<ChucVu> objChucVu = new BaseMethods<ChucVu>();
        // GET: Admin/ChucVu
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
        public JsonResult Get_List_ChucVu()
        {
            return Json(new { data = objChucVu.SelectAll() });
        }
        public JsonResult Get_ChucVu_ByID(int ID)
        {
            return Json(new { data = objChucVu.SelectByID(ID) });
        }

        public JsonResult Create_ChucVu(string MaCV, string TenCV,string MoTaCV)
        {
            ChucVu CV = new ChucVu();
            CV.ID = 0;
            CV.MaCV = MaCV;
            CV.TenCV = TenCV;
            CV.MoTaCV = MoTaCV;
            if (objChucVu.Add(CV) > 0)
            {
                return Json(new { data = true });
            }else
            {
                return Json(new { data = false });
            }

            
        }
        public JsonResult Edit_ChucVu(int ID ,string MaCV, string TenCV, string MoTaCV)
        {
            ChucVu CV = new ChucVu();
            CV.ID = ID;
            CV.MaCV = MaCV;
            CV.TenCV = TenCV;
            CV.MoTaCV = MoTaCV;
            if (objChucVu.Update(CV) > 0)
            {
                return Json(new { data = true });
            }
            else
            {
                return Json(new { data = false });
            }


        }
        public JsonResult Delete_ChucVu(int ID)
        {
            try
            {
                if (objChucVu.Delete(ID) > 0)
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

    }
}