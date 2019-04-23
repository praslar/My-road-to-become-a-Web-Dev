using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DLU.App_DLU;
using System.Configuration;

namespace DLU.Areas.Admin.Controllers.TaiKhoan
{
    public class DangNhapController : Alert
    {
        DataAccess.QL_TaiKhoan QL_TaiKhoan = new DataAccess.QL_TaiKhoan();
        // GET: Admin/DangNhap
        public ActionResult index()// Hiện Thị from đăng nhập vào hệ thống
        {
            return View();
        }

        /// <summary>
        /// U1 Đăng Nhập Người dùng chọn chức năng đăng nhập, điền tên và mật khẩu sau đó tiến hành đang nhập vào hệ thống. 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Login(DataAccess.TaiKhoan model)// Chức Năng Đang Nhập vòa hệ thống  
        {
            var TK = QL_TaiKhoan.DangNhap(model.TenDangNhap, model.MatKhau); //kiểm tra nếu đúng  trả về 1 tài khoản
            string MaCV = "";
            if (TK.Count > 0)//nếu Lón hơn 0 nghĩa là đăng nhập đúng
            {
                foreach (var Row in TK)
                {
                    Session["ID_TaiKhoan"] = Row.ID; // Gắng Session ID tài khoản vào
                    Session["IDMaCV"] = Row.MaCV;// Gắng Session Mã Chúc vụ tài khoản vào
                    MaCV = Row.MaCV;
                }
                if (MaCV == "SV")// Kiểm Tra nếu  mà mã chúc vụ là sv là sinh viên  thì thông báo 
                {
                    SetAlert("Bạn không có quyền truy cập vào admin !!", "danger"); // không có quyền truy cập vào admin quản lý
                    return RedirectToAction("Index", "DangNhap");
                }
                else
                {
                    return RedirectToAction("Index", "TrangChu");// ngược lại không phải là sinh viên thì cho vào admin vào quảng lý
                }

            }
            else
            {
                SetAlert("Đăng nhập thất bại !!", "danger");//nếu đăng nhập không đúng trả về lại  trang đằng nhập 
                return RedirectToAction("Index", "DangNhap");

            }

        }
        /// <summary>
        /// U2 Đăng Xuất  Người dùng chọn chức năng đăng nhập, điền tên và mật khẩu sau đó tiến hành đang nhập vào hệ thống. 
        /// </summary>
        /// <returns></returns>
        public ActionResult DangXuat()// chức năng đăng xuất gắng tất cả session về null
        {
            Session["ID_TaiKhoan"] = null;
            Session["Email_TaiKhoan"] = null;
            Session["IDMaCV"] = null;
            SetAlert("Đăng Xuất Thành công ", "success");
            return RedirectToAction("Index", "DangNhap");

        }

        public ActionResult IndexGuiMail() /// chức năng lấy lại mật khẩu  hiện from nhâp gmail để lấy mã xác nhận
        {
            return View();
        }
        public ActionResult GuiEMail(string Email) // Khi người dùng nhập gmail bấm ok  gét lấy gmail và gủi một mã bất kỳ cho gmail đó
        {
            int Mail = QL_TaiKhoan.GetBy(Email, "Mail").Count;

            if (Mail > 0)
            {
                var KeyPassword = RandomString(5, true);
                Session["KeyPassWord"] = KeyPassword;// rồi gắng session cho mã xắc nhận tậm thời
                Resetpassword.SendEmail(Email, "Mã Xác nhận lấy lại mật khẩu từ DLU", "Đây là mã xác nhận lấy lại mật khẩu : " + KeyPassword);
                TempData["Email"] = Email;
                return RedirectToAction("LayMatKhau", "DangNhap");// chuyên đên trang lấy lại mật khẩu
            }
            else
            {
                SetAlert("Email của bạn không có sử dụng vào hệ thống , vui long nhập Email chính xác ", "danger");
                return RedirectToAction("IndexGuiMail", "DangNhap");// chuyên đên trang lấy lại mật khẩu

            }
        }
        public ActionResult LayMatKhau()
        {

            return View();// chuyên đên trang lấy lại mật khẩu
        }
        [HttpPost]
        public ActionResult LayMatKhau(string KeyPassword, string Email ,string PasswordNew)
        {
            TempData["Email"] = Email;
            var tk = QL_TaiKhoan.GetBy(Email, "Mail");

           if (Session["KeyPassWord"].ToString()== KeyPassword&& tk[0].Email == Email)// kiểm tra nếu mã xác nhận tư đúng với mã xắc nhận hiện tại  và gmail = với gamil đã gủi mà thi
            {
                if (QL_TaiKhoan.Doi_MatKhau(tk[0].ID, PasswordNew)>0)// cho người dùng nhập mật khẩu mới 
                {
                    TempData["Email"] = Email;
                    Session["KeyPassWord"] = null;// gắng lại session =null
                    SetAlert("Lấy lại mật khẩu thành công", "success");// thông báo lấy lại mật khẩu thành công
                    return RedirectToAction("LayMatKhau", "DangNhap");
                }
                else// nếu không  
                {
                    SetAlert("Lấy lại mật khẩu không thành công", "danger");
                    TempData["Email"] = Email;
                    return RedirectToAction("LayMatKhau", "DangNhap");
                }
              
            }
            else if (Session["KeyPassWord"].ToString() != KeyPassword) 
            {
                SetAlert("Mã xác của bạn không đúng vui long nhập lại !", "danger");
                TempData["Email"] = Email;
                return RedirectToAction("LayMatKhau", "DangNhap");
            }else
            {
                SetAlert("Email không đúng vui lòng !", "danger");
                TempData["Email"] = Email;
                return RedirectToAction("LayMatKhau", "DangNhap");
            }
           
        }
    }
}