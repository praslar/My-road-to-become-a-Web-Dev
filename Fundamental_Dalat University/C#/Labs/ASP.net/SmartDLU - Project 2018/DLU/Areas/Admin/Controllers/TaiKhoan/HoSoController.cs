using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;
namespace DLU.Areas.Admin.Controllers.TaiKhoan
{
   
    public class HoSoController : Alert
    {
        QL_ThongTinTaiKhoan objThongTinTK = new QL_ThongTinTaiKhoan();
        QL_TaiKhoan objTaiKhoan = new QL_TaiKhoan();
        // GET: Admin/AD_HoSo
        public ActionResult HoSo(long id)
        {
            ViewBag.ThongTinTK = objThongTinTK.SelectBy(id, "IDTaiKhoan");
            return View();
        }
        public JsonResult Xem_ThongTinTaiKhoan(int ID)
        {
            return Json(new { data = objThongTinTK.SelectBy(ID, "IDTaiKhoan") });
        }
        public JsonResult Edit_HoSo(int ID, string Ho, string Ten, string NgaySinh,bool GioiTinh, string SoCMND, string DiaChi,string HinhAnh)
        {



            ThongTinTaiKhoan tt = new ThongTinTaiKhoan();
            tt.ID = ID;
            tt.Ho = Ho;
            tt.Ten = Ten;
            tt.NgaySinh = NgaySinh;
            tt.GioiTinh = GioiTinh;
            tt.SoCMND = SoCMND;
            tt.DiaChi = DiaChi;
            tt.HinhAnh = HinhAnh;
            tt.IDTaiKhoan = 0;
            if (objThongTinTK.Sua_ThongTinTaiKhoan(tt) > 0)
            {
                SetAlert("Sửa thông tin thành công ", "success");
                return Json(new { data = true });
                
            }
            else
            {
                return Json(new { data = false });
            }
        }

        /// <summary>
        /// U13 Đổi Mật Khẩu Giảng viên hoặc thí sinh chọn chức năng đổi mật khẩu, xác nhận mật khẩu cũ và điền mật khẩu mới
        /// </summary>
        /// <param name="MatKhauCu"></param>
        /// <param name="Mail_Pass"></param>
        /// <param name="MatKhauMoi2"></param>
        /// <returns></returns>
        public JsonResult Doi_MatKhau(string MatKhauCu,string Mail_Pass,string MatKhauMoi2)
        {

                var TaiKhoan = objTaiKhoan.Check_PassWord(MatKhauCu, Mail_Pass);
                int ID = TaiKhoan[0].ID;
                if(TaiKhoan.Count<=0)
                {
                    return Json(new { data = false });
                }
                else
                {
                    objTaiKhoan.Doi_MatKhau(ID, MatKhauMoi2);
                    return Json(new { data = true });
                }
        

        }
    }
}