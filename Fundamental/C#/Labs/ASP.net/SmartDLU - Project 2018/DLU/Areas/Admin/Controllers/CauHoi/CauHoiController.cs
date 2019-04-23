using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;
using Newtonsoft.Json;
using WebGrease.Css.Extensions;


namespace DLU.Areas.Admin.Controllers.CauHoi
{

    [ValidateInput(false)]

    public class CauHoiController : Alert
    {
        private int ktraChuong = 1;
        private int ktraDoKho = 1;
        private int Them = 0;
        QL_MonHoc objMonHoc = new QL_MonHoc();
        QL_DoKho objDoKho = new QL_DoKho();
        QL_ChuongHoc objChuongHoc = new QL_ChuongHoc();
        QL_LoaiCauHoi objLoaiCauHoi = new QL_LoaiCauHoi();
        QL_CauHoi objCauHoi = new QL_CauHoi();
        QL_CauTraLoi objCauTraLoi = new QL_CauTraLoi();
        // GET: Admin/CauHoi
        /// <summary>
        /// Truyền danh sách độ khó, môn học, chương học, loại câu hỏi và câu hỏi vào Index
        /// </summary>
        /// <returns>Index Ngân hàng câu hỏi </returns>
        public ActionResult Index()
        {
            ViewBag.Data_DoKho = objDoKho.Get_DanhSach_DoKho();
            ViewBag.Data_MonHoc = objMonHoc.Get_DanhSach_MonHoc();
            ViewBag.Data_ChuongHoc = objChuongHoc.Get_DanhSach_ChuongHoc();
            ViewBag.Data_LoaiCauHoi = objLoaiCauHoi.Get_DanhSach_LoaiCauHoi();
            ViewBag.Data_CauHoi = objCauHoi.Get_DanhSach_CauHoi();

            return View();
        }
        //======================================================Lấy danh sách============================
        /// <summary>
        /// Lấy danh sách câu trả lời của câu hỏi
        /// </summary>
        /// <param name="id">Mã câu hỏi</param>
        /// <returns>ListCauTraLoi</returns>
        public JsonResult Get_NoiDung_CauHoi(int id)
        {
            List<CAUTRALOI> dsCauTraLoi = objCauTraLoi.GetByIdCauHoi(id);
            List<CAUHOI> ch = objCauHoi.Get_DanhSach_By_ID(id);
            var obj = new
            {
                Cauhoi = ch,
                CauTraLoi = dsCauTraLoi
            };
            var datactl = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return Json(new { data = datactl }, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// Lấy danh sách độ khó trong DB 
        /// </summary>
        /// <returns>DOKHO</returns>
        public ActionResult Get_DoKho()
        {
            return Json(new { data = objDoKho.Get_DanhSach_DoKho() });
        }
        /// <summary>
        /// Lấy danh sách môn học trong DB
        /// </summary>
        /// <returns>MONHOC</returns>
        public ActionResult Get_MonHoc()
        {
            return Json(new { data = objMonHoc.Get_DanhSach_MonHoc() });
        }
        /// <summary>
        /// Lấy danh sách chương học trong DB
        /// </summary>
        /// <returns>CHUONGHOC</returns>
        public ActionResult Get_ChuongHoc()
        {
            return Json(new { data = objChuongHoc.Get_DanhSach_ChuongHoc() });
        }
        /// <summary>
        /// Lấy danh sách loại câu hỏi trong DataBase 
        /// </summary>
        /// <returns>LOAICAUHOI</returns>
        public ActionResult Get_LoaiCauHoi()
        {
            return Json(new { data = objLoaiCauHoi.Get_DanhSach_LoaiCauHoi() });
        }

        //====================================================chức năng chính==============================
        /// <summary>
        /// Thêm câu hỏi
        /// </summary>
        /// <param name="idChuongHoc"> Id của chương học</param>
        /// <param name="idLoaiCauHoi"> Id loại câu hỏi</param>
        /// <param name="noiDung"> nội dung câu hỏi</param>
        /// <param name="giaiThich"></param>
        /// <param name="DoKho"></param>
        /// <param name="IDMonHoc"></param>
        /// <returns> Câu hỏi mới </returns>
        public JsonResult Them_CauHoi(int idChuongHoc, int idLoaiCauHoi, string noiDung, string giaiThich, string DoKho, int IDMonHoc)
        {
            CAUHOI cauHoi = new CAUHOI();
            cauHoi.IDCAUHOI = 0;
            cauHoi.IDCHUONGHOC = idChuongHoc;
            cauHoi.IDLOAICAUHOI = idLoaiCauHoi;
            cauHoi.THOIGIANUPLEN = DateTime.Now;
            cauHoi.THOIGIANSUA = DateTime.Now;
            cauHoi.NOIDUNGCAUHOI = noiDung;
            cauHoi.GIAITHICHCAUHOI = giaiThich;
            cauHoi.MUCDOKHO = DoKho;

            //Kiểm tra chương học có thuộc môn học hay không
            foreach (CHUONGHOC chuonghoc in objChuongHoc.GetByIdMonHoc(IDMonHoc))
            {
                if (chuonghoc.IDCHUONGHOC == idChuongHoc)
                {
                    ktraChuong = 0;
                    break;
                }
            }

            //Kiếm tra độ khó hợp lệ
            List<MONHOC> mh = objMonHoc.Get_DanhSach_By_ID(IDMonHoc);
            foreach (DOKHO dk in objDoKho.GetByIdMucDoKho(mh[0].IDMUCDOKHO))
            {
                if (dk.TENDOKHO == DoKho)
                {
                    ktraDoKho = 0;
                    break;
                }
            }

            if (noiDung == "" || DoKho == "")
                Them = 1;

            //===========================================================================
            if (ktraChuong == 0)
            {
                if (ktraDoKho == 0)
                {
                    if (Them == 0)
                    {
                        if (objCauHoi.Them_CauHoi(cauHoi) > 0)
                        {
                            SetAlert("Thêm câu hỏi thành công, vui lòng thêm câu trả lời cho câu hỏi! ", "warning");
                            return Json(new { data = true });
                        }
                        return Json(new { data = false });
                    }
                    else
                    {
                        return Json(new { data = false });
                    }
                }
                else
                {
                    return Json(new { data = "invalidDoKho" });
                }

            }
            else
            {
                return Json(new { data = "invalidChuong" });
            }

        }
        //Xóa ( chưa biết làm)
        /// <summary>
        /// Xóa câu hỏi
        /// </summary>
        /// <param name="ID">Id câu hỏi</param>
        /// <returns>Jquery</returns>
        public JsonResult Xoa_CauHoi(int ID)
        {
            try
            {
                if (objCauHoi.Delete_CauHoi(ID) > 0)
                {
                    SetAlert("Xóa thành công", "success");
                    return Json(new { data = true });
                }
                return Json(new { data = false });
            }
            catch (Exception)
            {
                return Json(new { data = false });
            }
        }
       /// <summary>
       /// Sửa thông tin câu hỏi
       /// </summary>
       /// <param name="id">mã câu hỏi cần sửa</param>
       /// <param name="idChuongHoc">id chương</param>
       /// <param name="idLoaiCauHoi">id hình thức câu hỏi</param>
       /// <param name="noiDung"></param>
       /// <param name="moTa"></param>
       /// <param name="DoKho"></param>
       /// <param name="IDMonHoc">id môn học</param>
       /// <returns>Json(data = true||false)</returns>
        public JsonResult Sua_CauHoi(int id, int idChuongHoc, int idLoaiCauHoi, string noiDung, string moTa, string DoKho, int IDMonHoc)
        {
            CAUHOI cauHoi = new CAUHOI();
            cauHoi.IDCAUHOI = id;
            cauHoi.IDCHUONGHOC = idChuongHoc;
            cauHoi.IDLOAICAUHOI = idLoaiCauHoi;
            cauHoi.NOIDUNGCAUHOI = noiDung;
            cauHoi.GIAITHICHCAUHOI = moTa;
            cauHoi.THOIGIANUPLEN = DateTime.Now;
            cauHoi.THOIGIANSUA = DateTime.Now;
            cauHoi.MUCDOKHO = DoKho;

            foreach (CHUONGHOC chuonghoc in objChuongHoc.GetByIdMonHoc(IDMonHoc))
            {
                if (chuonghoc.IDCHUONGHOC == idChuongHoc)
                {
                    ktraChuong = 0;
                    break;
                }
            }

            //Kiếm tra độ khó hợp lệ
            List<MONHOC> mh = objMonHoc.Get_DanhSach_By_ID(IDMonHoc);
            foreach (DOKHO dk in objDoKho.GetByIdMucDoKho(mh[0].IDMUCDOKHO))
            {
                if (dk.TENDOKHO == DoKho)
                {
                    ktraDoKho = 0;
                    break;
                }
            }

            //Kiểm tra rỗng
            if (noiDung == "" || DoKho == "")
                Them = 1;

            if (ktraChuong == 0)
            {
                if (ktraDoKho == 0)
                {
                    if (Them == 0)
                    {
                        if (objCauHoi.Sua_CauHoi(cauHoi) > 0)
                        {
                            SetAlert("Sửa câu hỏi thành công, vui lòng thêm câu trả lời cho câu hỏi! ", "warning");
                            return Json(new { data = true });
                        }
                        return Json(new { data = false });
                    }
                    else
                    {
                        return Json(new { data = false });
                    }
                }
                else
                {
                    return Json(new { data = "invalidDoKho" });
                }

            }
            else
            {
                return Json(new { data = "invalidChuong" });
            }

        }
        //Nhóm 3
        public ActionResult ViewDanhSachCauHoi_CauTraLoiCuaDeThi(int id, int idMonHoc, int idBoDe)
        {
            ViewBag.idBoDe = idBoDe;
            ViewBag.idMonHoc = idMonHoc;
            ViewBag.idDeThi = id;
            //Lấy danh sách câu hỏi
            QL_CauHoi ql = new QL_CauHoi();
            List<CAUHOI> dsCauHoi = new List<CAUHOI>();
            dsCauHoi = ql.GetByIdDeThi(id);
            ViewBag.dsCauHoi = dsCauHoi;
            //Lấy danh sách câu trả lời
            QL_CauTraLoi qlCTL = new QL_CauTraLoi();
            List<CAUTRALOI> dsCauTraLoi = qlCTL.GetByIdDeThi(id);
            ViewBag.dsCauTraLoi = dsCauTraLoi;
            return View();
        }
    }
}