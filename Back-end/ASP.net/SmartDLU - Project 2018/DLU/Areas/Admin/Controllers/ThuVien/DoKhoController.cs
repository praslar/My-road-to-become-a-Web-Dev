using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;

namespace DLU.Areas.Admin.Controllers.ThuVien
{
    public class DoKhoController : Alert
    {
        private int Them = 0;
        private int invalidDoKho = 0;
        private int i = 0;
        QL_DoKho objDoKho = new QL_DoKho();
        QL_MucDoKho objMucDoKho = new QL_MucDoKho();
        QL_MonHoc objMonHoc = new QL_MonHoc();
        private string sldokho = "";

        private int soluongdokho = 0;
        // GET: Admin/DoKho
        public ActionResult Index()
        {
            ViewBag.DataMucDoKho = objMucDoKho.Get_DanhSach_MucDoKho();
            ViewBag.Data_DoKho = objDoKho.Get_DanhSach_DoKho();
            ViewBag.Data_MonHoc = objMonHoc.Get_DanhSach_MonHoc();
            return View();
        }

        /// <summary>
        /// lấy dang sách số lượng độ khó
        /// </summary>
        /// <returns></returns>
        public ActionResult Get_SoLuongDoKho()
        {
            return Json(new { data = objMucDoKho.Get_DanhSach_MucDoKho() });
        }

        //cái này lỗi, k lấy được sldk theo id do kho, k biết cách viết store proceduce
        //public ActionResult Get_CurrentSoLuongDoKho(int id)
        //{
        //    return Json(new { data = objMucDoKho.Get_DanhSach_By_ID(id) });
        //}

        /// <summary>
        /// lấy độ khó theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Get_DoKho(int id)
        {
            return Json(new { data = objDoKho.Get_DanhSach_By_ID(id) });
        }
        /// <summary>
        /// thêm độ khó trong số lượng độ khó
        /// </summary>
        /// <param name="tenDoKho"></param>
        /// <param name="IDSoLuongDoKho"></param>
        /// <returns></returns>
        public JsonResult Them_DoKho(string tenDoKho, int IDSoLuongDoKho)
        {
            DOKHO DoKho = new DOKHO();
            DoKho.IDDOKHO = 0;
            DoKho.TENDOKHO = tenDoKho;
            DoKho.IDMUCDOKHO = IDSoLuongDoKho;

            ////// //Lấy số lượng đô khó-> int
            foreach (MUCDOKHO t in objMucDoKho.Get_DanhSach_By_ID(IDSoLuongDoKho))
            {
                sldokho += t.TENMUCDOKHO;
            }

            soluongdokho = Convert.ToInt32(sldokho.Substring(0, 1));

            foreach (DOKHO dk in objDoKho.GetById_MucDoKho(IDSoLuongDoKho))
            {
                i++;
            }

            //duyệt xem đã đủ độ khó trong số lượng độ khó chưa
            if (i == soluongdokho)
                invalidDoKho = 1;

            foreach (DOKHO DK in objDoKho.GetById_MucDoKho(IDSoLuongDoKho))
            {
                if (DK.TENDOKHO == tenDoKho)
                    Them = 1;
            }
            if (tenDoKho == "")
                Them = 1;
            if (Them == 0)
            {
                if (invalidDoKho == 0)
                {
                    if (objDoKho.Them_DoKho(DoKho) > 0)
                    {
                        SetAlert("Thêm thành công!", "success");
                        return Json(new { data = true });
                    }
                    return Json(new { data = false });
                }
                else
                {
                    return Json(new { data = "invalidDoKho" });
                }
            }
            else
            {
                return Json(new { data = false });
            }

        }

        /// <summary>
        /// xóa một độ khó trong số lượng độ khó
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public JsonResult Xoa_DoKho(int ID)
        {
            try
            {
                if (objDoKho.Delete_DoKho(ID) > 0)
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
        /// sửa một độ khó
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenDoKho"></param>
        /// <param name="IDSoLuongDoKho"></param>
        /// <returns></returns>
        public JsonResult Sua_DoKho(int id, string tenDoKho, int IDSoLuongDoKho)
        {
            DOKHO DoKho = new DOKHO();
            DoKho.IDDOKHO = id;
            DoKho.TENDOKHO = tenDoKho;
            DoKho.IDMUCDOKHO = IDSoLuongDoKho;
            foreach (DOKHO DK in objDoKho.Get_DanhSach_DoKho())
            {
                if (DK.TENDOKHO == tenDoKho)
                    Them = 1;
            }
            if (tenDoKho == "")
                Them = 1;
            if (Them == 0)
            {
                if (objDoKho.Sua_DoKho(DoKho) > 0)
                {
                    SetAlert("Sửa thành công!", "success");
                    return Json(new { data = true });
                }
                return Json(new { data = false });
            }
            else
            {
                return Json(new { data = false });
            }
        }
    }
}