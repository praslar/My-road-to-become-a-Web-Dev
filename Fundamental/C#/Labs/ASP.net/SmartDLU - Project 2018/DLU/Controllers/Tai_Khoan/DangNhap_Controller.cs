using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;
namespace DLU.Controllers.Tai_Khoan
{
    public class DangNhap_Controller : Alert
    {
        DataAccess.QL_TaiKhoan QL_TaiKhoan = new DataAccess.QL_TaiKhoan();
        // GET: DangNhap_
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(DataAccess.TaiKhoan model)
        {
            var TK = QL_TaiKhoan.DangNhap(model.TenDangNhap, model.MatKhau);
    
            if (TK.Count > 0)
            {
                foreach (var Row in TK)
                {
                    Session["ID_TaiKhoan_SV"] = Row.ID;
                    Session["Email_TaiKhoan_SV"] = Row.Email;




                }

                return RedirectToAction("Index", "ThiChinhThuc_");
                

            }
            else
            {
                SetAlert("Tên đăng nhập hoặt mật khẩu không đúng vui lòng nhập lại ", "danger");
                return RedirectToAction("Index", "DangNhap_");

            }

        }
        public ActionResult DangXuat()
        {
            Session["ID_TaiKhoan_SV"] = null;
            Session["Email_TaiKhoan_SV"] = null;
            SetAlert("Đăng Xuất Thành công ", "success");
            return RedirectToAction("Index", "DangNhap_");

        }
    }
}