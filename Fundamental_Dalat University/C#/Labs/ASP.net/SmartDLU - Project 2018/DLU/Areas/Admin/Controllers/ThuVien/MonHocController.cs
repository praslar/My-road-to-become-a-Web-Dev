using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;

namespace DLU.Areas.Admin.Controllers.ThuVien
{
    public class MonHocController : Alert
    {
        private int Them = 1;
        private int Sua = 1;
        QL_MonHoc objMonHoc = new QL_MonHoc();
        QL_MucDoKho objMucDoKho = new QL_MucDoKho();
        QL_ChuongHoc objchuong = new QL_ChuongHoc();


       //===========================================================================================

       

        // GET: Admin/MonHoc
        public ActionResult Index()
        {
            ViewBag.DataMucDoKho = objMucDoKho.Get_DanhSach_MucDoKho();
            ViewBag.Data_MonHoc = objMonHoc.Get_DanhSach_MonHoc();
            return View();
        }

        //=====================================================================================//
        /// <summary>
        /// Lấy danh sách số lượng độ khó
        /// </summary>
        /// <returns></returns>
        public ActionResult Get_SoLuongDoKho()
        {
            return Json(new { data = objMucDoKho.Get_DanhSach_MucDoKho() });
        }
        /// <summary>
        /// lấy tất cả môn học
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Get_MonHoc(int ID)
        {
            return Json(new { data = objMonHoc.Get_DanhSach_By_ID(ID) });
        }

        /// <summary>
        /// lấy tất cả chương
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Get_chuong(int ID)
        {
            try
            {
                return Json(new { data = objchuong.GetByIdMonHoc(ID) });
            }
            catch (Exception)
            {
                return Json(new { data = false });
            }
  
        }


        public JsonResult Them_MonHoc(string tenMon, string moTa, int IDSoLuongDoKho)
        {
            MONHOC monHoc = new MONHOC();
            monHoc.IDMONHOC = 0;
            monHoc.MOTAMONHOC = moTa;
            monHoc.TENMONHOC = tenMon;
            monHoc.IDMUCDOKHO = IDSoLuongDoKho;

            foreach (MONHOC monhoc in objMonHoc.Get_DanhSach_MonHoc())
            {
                if (monhoc.TENMONHOC == monHoc.TENMONHOC)
                {
                    Them = 0;
                }
            }
            if (tenMon == "")
                Them = 0;
            if (Them == 1)
            {
                if (objMonHoc.Them_MonHoc(monHoc) > 0)
                {
                    SetAlert("Thêm thành công", "success");
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

        //Xóa
        public JsonResult Xoa_MonHoc(int ID)
        {
            try
            {
                if (objMonHoc.Delete_MonHoc(ID) > 0)
                {
                    SetAlert("Xóa thành công!","success");
                    return Json(new { data = true });
                }
                else
                {
                    return Json(new { data = false });
                }
            }
            catch (Exception)
            {
                return Json(new { data = false });
            }
 
        }

        //Sửa
        public JsonResult Sua_MonHoc(int id, string tenMon, string moTa, int IDSoLuongDoKho)
        {
            MONHOC monHoc = new MONHOC();
            monHoc.IDMONHOC = id;
            monHoc.MOTAMONHOC = moTa;
            monHoc.TENMONHOC = tenMon;
            monHoc.IDMUCDOKHO = IDSoLuongDoKho;
            foreach (MONHOC monhoc in objMonHoc.Get_DanhSach_By_ID(id))
            {
                if (monhoc.TENMONHOC == tenMon && monhoc.MOTAMONHOC == moTa && monhoc.IDMUCDOKHO == IDSoLuongDoKho)
                {
                    Sua = 0;
                }
            }
            if (tenMon == "")
                Sua = 0;
            if (Sua == 1)
            {
                if (objMonHoc.Sua_MonHoc(monHoc) > 0)
                {
                    SetAlert("Sửa thành công", "success");
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
    }
}