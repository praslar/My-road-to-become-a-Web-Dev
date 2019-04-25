using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;
namespace DLU.Areas.Admin.Controllers.TaiKhoan// Dinh Van Lanh Làm
{
    public class TaiKhoanController : Alert
    {
        QL_TaiKhoan objTaiKhoan = new QL_TaiKhoan();
        QL_ThongTinTaiKhoan objThongTinTaiKhoan = new QL_ThongTinTaiKhoan();
        BaseMethods<TAIKHOANLICHTHI> objTaiKhoanLichThi = new BaseMethods<TAIKHOANLICHTHI>();
        
        
        // GET: Admin/TaiKhoan
        public ActionResult Index()
        {
            
            if(Session["ID_TaiKhoan"]!=null)
            {
                if (Session["IDMaCV"].ToString() == "GV")
                {
                    SetAlert("Bạn không có quyên truy cập vào chức năng nầy xin cảm ơn", "danger");
                    return RedirectToAction("Index", "TrangChu");
                }
            }
            
            return View();
        }
        public JsonResult Get_DanhSachTaiKhoan(string MaCV)
        {
            if (MaCV == "ALL")
            {
                return Json(new { data = objTaiKhoan.Get_DanhSach_TaiKhoan() });
            }
            else
            {
                  return Json(new { data = objTaiKhoan.GetBy(MaCV, "MaCV") });
            }
        }
        public JsonResult Ckeck_Mail(string Mail)
        {
            if (objTaiKhoan.GetBy(Mail,"Mail").Count>0)
            {
                return Json(new { data = true });
            }
            else
            {
                return Json(new { data = false });
            }
           
        }
        public JsonResult Ckeck_TenDangNhap(string TenDangNhap)
        {
            if(objTaiKhoan.GetBy(TenDangNhap,"TenDangNhap").Count>0)
            {
                return Json(new { data = true });
            }
            else
            {
                return Json(new { data = false });
            }
        }
        /// <summary>
        ///U4 Người quản lý dùng tài khoản hệ thống, chọn
        /// chức năng thêm tài khoản người sử dụng. 
        /// Nhập đầy đủ thông tin và tiến hành tạo tài khoản.
        /// </summary>
        public JsonResult Them_TaiKhoan(
            string TenDangNhap,
            string MatKhau,
            string ChucVu,
            string Mail,
            string Ho,
            string Ten,
            string NgaySinh,
            bool GioiTinh,
            string SoCMND,
            string DiaChi,
            string HinhAnh

            )
        {
            DataAccess.TaiKhoan tk = new DataAccess.TaiKhoan();
            DataAccess.ThongTinTaiKhoan TT = new ThongTinTaiKhoan();
            tk.ID = 0;
            tk.TenDangNhap = TenDangNhap;
            tk.MatKhau = MatKhau;
            tk.Email = Mail;
            tk.MaCV = ChucVu;
            tk.IDLop = null;
            if (objTaiKhoan.Them_TaiKhoan(tk)>0)
            {
                var RowTaiKhoan = objTaiKhoan.GetBy(Mail, "Mail");
                if (RowTaiKhoan.Count > 0)
                {
                    TT.ID = 0;
                    TT.Ho = Ho;
                    TT.Ten = Ten;
                    TT.NgaySinh = NgaySinh;
                    TT.GioiTinh = GioiTinh;
                    TT.SoCMND = SoCMND;
                    TT.DiaChi = DiaChi;
                    TT.HinhAnh = HinhAnh;
                    foreach (var Row in RowTaiKhoan)
                    {
                        TT.IDTaiKhoan = Row.ID;
                    }
                    if (objThongTinTaiKhoan.Them_ThongTinTaiKhoan(TT) > 0)
                    {
                        
                        return Json(new { data = true });
                    }
                    else
                    {
                        return Json(new { data = false });
                    }
                }
                else
                {
                    return Json(new { data = false });

                }
               // return Json(new { data = true });
            }
            else
            {
                return Json(new { data = false });
            }
          
        }
        /// <summary>
        ///  U5 Sửa tài khoản Người quản lý dùng tài khoản được quyền sửa tài khoản giảng viên hoặc tài khoản thi.
        /// </summary>

        public JsonResult Edit_HoSo(int ID, string TenDangNhap, string MatKhau, string MaCV, string Email, string Ho, string Ten, string NgaySinh, bool GioiTinh, string SoCMND, string DiaChi, string HinhAnh)
        {

            DataAccess.TaiKhoan tk = new DataAccess.TaiKhoan();
            DataAccess.ThongTinTaiKhoan TT = new ThongTinTaiKhoan();

            tk.ID = ID;
            tk.TenDangNhap = TenDangNhap;
            tk.MatKhau = MatKhau;
            tk.Email = Email;
            tk.MaCV = MaCV;

            TT.Ho = Ho;
            TT.Ten = Ten;
            TT.NgaySinh = NgaySinh;
            TT.GioiTinh = GioiTinh;
            TT.SoCMND = SoCMND;
            TT.DiaChi = DiaChi;
            TT.HinhAnh = HinhAnh;
            TT.IDTaiKhoan = 0;

            foreach (ThongTinTaiKhoan row in objThongTinTaiKhoan.SelectBy(ID, "IDTaiKhoan"))
            {
                TT.ID = row.ID;
            }


            if (objTaiKhoan.Sua_TaiKhoan(tk) > 0)
            {
                if (objThongTinTaiKhoan.Sua_ThongTinTaiKhoan(TT) > 0)
                {
                    
                    return Json(new { data = true });
                }
                else
                {
                    return Json(new { data = false });
                }

            }
            else
            {
                return Json(new { data = false });
            }


        }
        /// <summary>
        /// U6 Xóa Tài Khoản tài khoản
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public JsonResult Xoa_TaiKhoan(int ID)
        {
            try
            {
                if (objTaiKhoanLichThi.SelectBy(ID, "IDTaiKhoan").Count > 0)
                {
                    //xoa tai khoan lich thi
                    objTaiKhoanLichThi.DeleteBy(ID, "IDTaiKhoan");
                    //xoa thong tin tai khoan dang co
                    objThongTinTaiKhoan.DeleteBy(ID, "IDTaiKhoan");
                    // xoa tai khoan 
                    if (objTaiKhoan.Delete(ID) > 0)
                    {
                        return Json(new { data = true });

                    }
                    else
                    {
                        return Json(new { data = false });
                    }

                }
                else
                {
                    objThongTinTaiKhoan.DeleteBy(ID, "IDTaiKhoan");
                    // xoa tai khoan 
                    if (objTaiKhoan.Delete(ID) > 0)
                    {
                        return Json(new { data = true });

                    }
                    else
                    {
                        return Json(new { data = false });
                    }
                }
            }
            catch
            {
                return Json(new { data = false });
            }
             
               
              
                  

        }
       
        public JsonResult  Get_TaiKhoan_Va_ThongTin(int ID)
        {
            return Json(new { TK = objTaiKhoan.Get_DanhSach_By_ID(ID) ,TT=objThongTinTaiKhoan.SelectBy(ID,"IDTaiKhoan") });
        }

    }
}