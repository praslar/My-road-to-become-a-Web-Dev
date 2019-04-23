using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DLU.App_DLU;

namespace DLU.Areas.Admin.Controllers.ThuVien
{
    public class HinhThucCauHoiController : Alert
    {
        private int Them = 0;
        // GET: Admin/HinhThucCauHoi
        QL_LoaiCauHoi objLoaiCauHoi = new QL_LoaiCauHoi();

        // GET: Admin/LoaiCauHoi
        public ActionResult Index()
        {

            ViewBag.Data_LoaiCauHoi = objLoaiCauHoi.Get_DanhSach_LoaiCauHoi();
            return View();
        }

        /// <summary>
        /// lấy tất cả loại câu hỏi
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Get_LoaiCauHoi(int ID)
        {
            return Json(new { data = objLoaiCauHoi.Get_DanhSach_By_ID(ID) });
        }

        /// <summary>
        /// thêm loại câu hỏi
        /// </summary>
        /// <param name="tenLoaicauhoi"></param>
        /// <param name="moTa"></param>
        /// <returns></returns>
        public JsonResult Them_LoaiCauHoi(string tenLoaicauhoi, string moTa)
        {
            LOAICAUHOI loaicauhoi = new LOAICAUHOI();
            loaicauhoi.IDLOAICAUHOI = 0;
            loaicauhoi.TENLOAICAUHOI = tenLoaicauhoi;

            foreach (LOAICAUHOI lchLoaicauhoi in objLoaiCauHoi.Get_DanhSach_LoaiCauHoi())
            {
                if (lchLoaicauhoi.TENLOAICAUHOI == tenLoaicauhoi)
                    Them = 1;
            }

            if (tenLoaicauhoi == "")
                Them = 1;
            if (Them == 0)
            {
                if (objLoaiCauHoi.Them_LoaiCauHoi(loaicauhoi) > 0)
                {
                    SetAlert("Thêm thành công!", "success");
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
        /// xóa loại câu hỏi
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public JsonResult Xoa_LoaiCauHoi(int ID)
        {
            try
            {
                if (objLoaiCauHoi.Delete_LoaiCauHoi(ID) > 0)
                {
                    SetAlert("Xóa thành công!", "success");
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
        /// sửa thông tin loại câu hỏi
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenLoaicauhoi"></param>
        /// <returns></returns>
        public JsonResult Sua_LoaiCauHoi(int id, string tenLoaicauhoi)
        {
            LOAICAUHOI loaicauhoi = new LOAICAUHOI();
            loaicauhoi.IDLOAICAUHOI = id;
            loaicauhoi.TENLOAICAUHOI = tenLoaicauhoi;
            foreach (LOAICAUHOI lchLoaicauhoi in objLoaiCauHoi.Get_DanhSach_LoaiCauHoi())
            {
                if (lchLoaicauhoi.TENLOAICAUHOI == tenLoaicauhoi)
                    Them = 1;
            }

            if (tenLoaicauhoi == "")
                Them = 1;
            if (Them == 0)
            {
                if (objLoaiCauHoi.Sua_LoaiCauHoi(loaicauhoi) > 0)
                {
                    SetAlert("Sửa thành công!", "success");
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