using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;
//using OfficeOpenXml;

namespace DLU.Areas.Admin.Controllers.TaiKhoan
{
    public class TaiKhoanSinhVienController : Alert
    {
        QL_TaiKhoan objTaiKhoan = new QL_TaiKhoan();
        QL_ThongTinTaiKhoan objThongTinTaiKhoan = new QL_ThongTinTaiKhoan();
        QL_Lop objLop = new QL_Lop();
        BaseMethods<TAIKHOANLICHTHI> objTaiKhoanLichThi = new BaseMethods<TAIKHOANLICHTHI>();
        ThongTinTaiKhoanMedthods objThongTinTaiKhoanMedthods = new ThongTinTaiKhoanMedthods();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Get_DanhSachTaiKhoanSinhVien(int Key)
        {
            if (Key == 0)
            {
                return Json(new { data = objTaiKhoan.GetBy("SV", "MaCV") });
            }
            else
            {
                return Json(new { data = objTaiKhoan.GetBy(Key, "IDLop") });
            }
             
        }
        public JsonResult Get_HoTen_TaiKhoanSinhVien(int ID)
        {
            return Json(new { data = objThongTinTaiKhoanMedthods.Get_HoTen_TK(ID) });
        }
        public JsonResult Get_DanhSachLop()
        {
            return Json(new { data = objLop.Get_DanhSach_Lop() });
        }
        public JsonResult Get_TK_TKN_TTTK(int ID)
        {
            return Json(new
            {
                TK = objTaiKhoan.Get_DanhSach_By_ID(ID),
                TT = objThongTinTaiKhoan.SelectBy(ID, "IDTaiKhoan"),
              
            });
        }

        public JsonResult Them_TaiKhoanSinhVien(
           string TenDangNhap,
           string MatKhau,
           string ChucVu,
           string Email,
           int IDLop,
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
            tk.Email = Email;
            tk.MaCV = ChucVu;
            tk.IDLop = IDLop;
            if (objTaiKhoan.Them_TaiKhoan(tk) > 0)
            {
                var RowTaiKhoan = objTaiKhoan.GetBy(Email, "Mail");
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
            }
            else
            {
                return Json(new { data = false });
            }
        }
        public JsonResult Sua_TaiKhoanSinhVien(int IDTaiKhoan, string TenDangNhap, string MatKhau, string ChucVu,int IDLop, string Email, string Ho, string Ten, string NgaySinh, bool GioiTinh, string SoCMND, string DiaChi, string HinhAnh)
        {

            DataAccess.TaiKhoan tk = new DataAccess.TaiKhoan();
            DataAccess.ThongTinTaiKhoan TT = new ThongTinTaiKhoan();
            tk.ID = IDTaiKhoan;
            tk.TenDangNhap = TenDangNhap;
            tk.MatKhau = MatKhau;
            tk.Email = Email;
            tk.MaCV = ChucVu;
            tk.IDLop = IDLop;

            TT.Ho = Ho;
            TT.Ten = Ten;
            TT.NgaySinh = NgaySinh;
            TT.GioiTinh = GioiTinh;
            TT.SoCMND = SoCMND;
            TT.DiaChi = DiaChi;
            TT.HinhAnh = HinhAnh;
            TT.IDTaiKhoan = 0;
            TT.ID = objThongTinTaiKhoan.SelectBy(IDTaiKhoan, "IDTaiKhoan")[0].ID;
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
        public JsonResult Delete_taiKhoanSinhVien(int ID)
        {
            try
            {
                if (objThongTinTaiKhoan.SelectBy(ID, "IDTaiKhoan").Count > 0)
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
    }
}
        //[HttpPost]
        //public JsonResult UpdateExcel()
        //{
        //    if (Request.Files.Count > 0)
        //    {
        //        try
        //        {
        //            HttpFileCollectionBase files = Request.Files;

        //            var path = "";
        //            for (int i = 0; i < files.Count; i++)
        //            {
        //                var file = files[i];
        //                var name = Path.GetFileName(file.FileName);
        //                var exec = Path.GetExtension(file.FileName);
        //                string newname = DateTime.Now.Date.ToString("dd-MM-yyyy-HH-mm") + DateTime.Now.Date.Ticks + exec;
        //                path = Path.Combine(Server.MapPath("/Content/Data/Temp/"), newname);
        //                file.SaveAs(path);
        //            }

        //            FileInfo fileinfo = new FileInfo(path);

        //            using (ExcelPackage package = new ExcelPackage(fileinfo))
        //            {
        //                ExcelWorksheet workSheet = package.Workbook.Worksheets.First();
        //                int totalRows = workSheet.Dimension.Rows;

        //                List<DataAccess.TaiKhoan> tktemp = new List<DataAccess.TaiKhoan>();

        //                for (int i = 2; i <= totalRows; i++)
        //                {
        //                    string tendangnhap = workSheet.Cells[i, 1].Value.ToString();
        //                    string matkhau = workSheet.Cells[i, 2].Value.ToString();
        //                    string email = workSheet.Cells[i, 3].Value.ToString();
        //                    string macv = workSheet.Cells[i, 4].Value.ToString();
        //                    tktemp.Add(new DataAccess.TaiKhoan() { TenDangNhap = tendangnhap, MatKhau = matkhau, Email = email, MaCV = macv });
        //                }
        //                var error = new List<KeyValuePair<int, string>>();
        //                var j= 0;
        //                foreach (var item in tktemp)
        //                {
        //                    objTaiKhoan.Add(item);//Thêm vào DB
        //                    //var it = objTaiKhoan.Get_DanhSach_By_TenDangNhap(item.TenDangNhap);
        //                    //if (it == null)
        //                    //{
        //                    //    objTaiKhoan.Add(item);
        //                    //}
        //                    //else
        //                    //{
        //                    //    error.Add(new KeyValuePair<int, string>(j++,item.TenDangNhap));
        //                    //}

        //                }
        //                if (error.Count <= 0)
        //                {
        //                    return Json(new { Code = 1, messenger = "Thành công.", url = "/admin/tai-khoan-thi" });
        //                }
        //                else
        //                {
        //                    return Json(new { Code = 0, data = error });
        //                }

        //            }
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }
        //    }
        //    return Json(new { Code = -1, messenger = "Không tồn tại file." });
        //}
    //}

//}