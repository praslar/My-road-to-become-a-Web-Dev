using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DLU.App_DLU;
namespace DLU.Areas.Admin.Controllers.ThuVien
{
    public class SoLuongDoKhoController : Alert
    {
        private int Them = 0;
        private int Sua = 0;
        QL_MucDoKho objMucDoKho = new QL_MucDoKho();


        // GET: Admin/MonHoc
        public ActionResult Index()
        {
            ViewBag.DataMucDoKho = objMucDoKho.Get_DanhSach_MucDoKho();
            return View();
        }

        public JsonResult Get_MucDoKho(int id)
        {
            return Json(new { data = objMucDoKho.Get_DanhSach_By_ID(id) });
        }

        //Thêm
        public JsonResult Them_MucDoKho(string tenMucDoKho, string moTa)
        {
            MUCDOKHO MucDoKho = new MUCDOKHO();
            MucDoKho.IDMUCDOKHO = 0;
            MucDoKho.TENMUCDOKHO = tenMucDoKho;
            MucDoKho.MOTAMUCDOKHO = moTa;

            foreach (MUCDOKHO mdk in objMucDoKho.Get_DanhSach_MucDoKho())
            {
                if (tenMucDoKho == mdk.TENMUCDOKHO)
                {
                    Them = 1;
                }
            }

            if (tenMucDoKho == "")
            {
                Them = 1;
            }

            if (Them == 0)
            {
                if (objMucDoKho.Them_MucDoKho(MucDoKho) > 0)
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
        public JsonResult Xoa_MucDoKho(int ID)
        {
            try
            {
                if (objMucDoKho.Delete_MucDoKho(ID) > 0)
                {
                    SetAlert("Xóa thành công","danger");
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
        public JsonResult Sua_MucDoKho(int id, string tenMucDoKho, string moTa)
        {
            MUCDOKHO MucDoKho = new MUCDOKHO();
            MucDoKho.IDMUCDOKHO = id;
            MucDoKho.MOTAMUCDOKHO = moTa;
            MucDoKho.TENMUCDOKHO = tenMucDoKho;

            foreach (MUCDOKHO mdk in objMucDoKho.Get_DanhSach_MucDoKho())
            {
                if (tenMucDoKho == mdk.TENMUCDOKHO && moTa == mdk.MOTAMUCDOKHO)
                {
                    Sua = 1;
                }
            }
            if (tenMucDoKho == "")
            {
                Sua = 1;
            }
            if (Sua == 0)
            {
                if (objMucDoKho.Sua_MucDoKho(MucDoKho) > 0)
                {
                    SetAlert("Sửa thành công", "success");
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