using System.Web.Mvc;

namespace DLU.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            //------------------------------------- Tai Khoan -----------------------------------------//
            //TaiKhoan//
            context.MapRoute( //Hien thi trang danh 
                "TaiKhoan",
                "admin/tai-khoan",
                new { Controller = "TaiKhoan", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute( 
               "Lop",
               "admin/lop",
               new { Controller = "Lop", action = "Index", id = UrlParameter.Optional }
           );
            context.MapRoute( 
              "ChucVu",
              "admin/chuc-vu",
              new { Controller = "ChucVu", action = "Index", id = UrlParameter.Optional }
          );
            context.MapRoute( 
                "Dashboard",
                "admin/dashboard",
                new { Controller = "TrangChu", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute( 
                "HoSo",
                "admin/ho-so-{id}",
                new { Controller = "HoSo", action = "HoSo", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "DanhSachThi",
                "admin/danh-sach-thi",
                new { Controller = "DanhSachThi", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "TaiKhoanSinhVien",
                "admin/tai-khoan-sinh-vien",
                new { Controller = "TaiKhoanSinhVien", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(// 
               "ResetPassWord",
               "admin/reset-password",
               new { Controller = "DangNhap", action = "IndexGuiMail", id = UrlParameter.Optional });


            //-------------------------------------End Tai Khoan -----------------------------------------//

            //-------------------------------------Quản lý bộ đề--------------------------------------//

            


            context.MapRoute( // Tạo trang thêm nhóm
                "BoDe",
                "admin/bo-de-thi-{id}",
                new { Controller = "BoDe", action = "Index", id = UrlParameter.Optional }
                );
            context.MapRoute( // Tạo trang thêm nhóm
                "TaoBoDe",
                "admin/tao-bo-de-thi-{id}",
                new { Controller = "BoDe", action = "TaoBoDe", id = UrlParameter.Optional }
                );
            context.MapRoute( // Tạo trang thêm nhóm
                "SuaBoDe",
                "admin/sua-bo-de-thi-{id}",
                new { Controller = "BoDe", action = "SuaBoDe", id = UrlParameter.Optional }
                );
            context.MapRoute( // Tạo trang thêm nhóm
                "DanhSachCauHoi_CauTraLoi",
                "admin/danh-sach-cau-hoi-cau-tra-loi-{id}",
                new { Controller = "CauHoi", action = "ViewDanhSachCauHoi_CauTraLoiCuaDeThi", id = UrlParameter.Optional }
                );
            context.MapRoute( // Tạo trang thêm nhóm
                "DeThi",
                "admin/danh-sach-cau-hoi-cau-tra-loi-{id}",
                new { Controller = "DeThi", action = "Index", id = UrlParameter.Optional }
                );

            //-------------------------------------Quản lý bộ đề--------------------------------------//

            //-------------------------------------Quản lý câu hỏi--------------------------------------//

            context.MapRoute( // hiển thị danh sách câu hỏi
               "questionsBank",
               "Admin/ngan-hang-cau-hoi",
               new { Controller = "CauHoi", action = "index", id = UrlParameter.Optional }
               );
            context.MapRoute( // thêm danh sách câu hỏi
                "addQuestion",
                "admin/them-cau-hoi",
                new { Controller = "CauHoi", action = "edit", id = UrlParameter.Optional }
            );
            context.MapRoute( // tìm và sửa thị danh sách câu hỏi
                "searchQuestion",
                "admin/tim-sua-cau-hoi",
                new { Controller = "CauHoi", action = "search", id = UrlParameter.Optional }
            );
            //-------------------------------------Quản lý câu hỏi--------------------------------------//


            //-------------------------------------Quản lý thư viện--------------------------------------//
            context.MapRoute( // môn học
                "indexMonHoc",
                "admin/mon-hoc",
                new { Controller = "MonHoc", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute( // chương môn học
                "indexChuong",
                "admin/chuong",
                new { Controller = "Chuong", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute( // độ khó
                "indexDoKho",
                "admin/do-kho",
                new { Controller = "DoKho", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute( // số lượng độ khó
                "indexSoLuongDoKho",
                "admin/so-luong-do-kho",
                new { Controller = "SoLuongDoKho", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute( // hình thức
                "indexHinhThuc",
                "admin/hinh-thuc",
                new { Controller = "HinhThucCauHoi", action = "Index", id = UrlParameter.Optional }
            );






















            context.MapRoute(
               "admin_default",
               "admin/{controller}/{action}/{id}",
               new { Controller = "DangNhap", action = "index", id = UrlParameter.Optional }
           );
        }
    }
}