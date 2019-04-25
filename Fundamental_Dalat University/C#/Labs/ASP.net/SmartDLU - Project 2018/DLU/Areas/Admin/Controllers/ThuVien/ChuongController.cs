using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DLU.App_DLU;

namespace DLU.Areas.Admin.Controllers.ThuVien
{
    public class ChuongController : Alert
    {
        private int Them = 1;
        private int Sua = 1;
        // GET: Admin/Chuong
        QL_MonHoc objMonHoc = new QL_MonHoc();
        QL_ChuongHoc objChuong = new QL_ChuongHoc();

        // GET: Admin/MonHoc
        public ActionResult Index()
        {
            ViewBag.DataChuong = objChuong.Get_DanhSach_ChuongHoc();
            ViewBag.Data_MonHoc = objMonHoc.Get_DanhSach_MonHoc();
            return View();
        }

        /// <summary>
        /// lấy danh sách môn học
        /// </summary>
        /// <returns></returns>
        public ActionResult Get_MonHoc()
        {
            return Json(new { data = objMonHoc.Get_DanhSach_MonHoc() });
        }
        /// <summary>
        /// lấy danh sách chương học
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Get_Chuong(int ID)
        {
            return Json(new { data = objChuong.Get_DanhSach_By_ID(ID) });
        }

        /// <summary>
        /// thêm chương học
        /// </summary>
        /// <param name="tenChuong"></param>
        /// <param name="moTa"></param>
        /// <param name="IDMonHoc"></param>
        /// <returns></returns>
        public JsonResult Them_Chuong(string tenChuong, string moTa, int IDMonHoc)
        {
            CHUONGHOC chuong = new CHUONGHOC();
            chuong.IDCHUONGHOC = 0;
            chuong.MOTACHUONGHOC = moTa;
            chuong.TENCHUONGHOC = tenChuong;
            chuong.IDMONHOC = IDMonHoc;

            //bad code
            foreach (CHUONGHOC ch in objChuong.Get_DanhSach_ChuongHoc())
            {
                if (ch.TENCHUONGHOC == tenChuong)
                    Them = 0;
            }

            if (tenChuong == "")
                Them = 0;

            if (Them == 1)
            {
                if (objChuong.Them_ChuongHoc(chuong) > 0)
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

        /// <summary>
        /// Xóa chương học
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public JsonResult Xoa_Chuong(int ID)
        {
            try
            {
                if (objChuong.Delete_ChuongHoc(ID) > 0)
                {
                    SetAlert("Xóa thành công", "success");
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

        /// <summary>
        /// Sửa thông tin chương học
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenChuong"></param>
        /// <param name="moTa"></param>
        /// <param name="IDMonHoc"></param>
        /// <returns></returns>
        public JsonResult Edit_Chuong(int id, string tenChuong, string moTa, int IDMonHoc)
        {
            CHUONGHOC chuong = new CHUONGHOC();
            chuong.IDCHUONGHOC = id;
            chuong.MOTACHUONGHOC = moTa;
            chuong.TENCHUONGHOC = tenChuong;
            chuong.IDMONHOC = IDMonHoc;
            foreach (CHUONGHOC ch in objChuong.Get_DanhSach_By_ID(id))
            {
                if (ch.TENCHUONGHOC == tenChuong && ch.MOTACHUONGHOC == moTa && chuong.IDMONHOC == IDMonHoc)
                {
                    Sua = 0;
                }
            }

            if (tenChuong == "")
                Sua = 0;
            if (Sua == 1)
            {
                if (objChuong.Sua_ChuongHoc(chuong) > 0)
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