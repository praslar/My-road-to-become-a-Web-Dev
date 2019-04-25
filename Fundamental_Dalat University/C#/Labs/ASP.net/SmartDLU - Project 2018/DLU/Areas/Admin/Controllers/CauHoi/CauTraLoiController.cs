using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DLU.App_DLU;


namespace DLU.Areas.Admin.Controllers.CauHoi
{

    [ValidateInput(false)]
    public class CauTraLoiController : Alert
    {
        private int invalidIndex = 0;
        private int them = 0;
        int invalidDapAnDung = 0;
        int LoaiCauhoi_sosanh = 0;
        private string LoaiCauhoi = "";


        QL_CauHoi objCauHoi = new QL_CauHoi();
        QL_CauTraLoi objCauTraLoi = new QL_CauTraLoi();
        QL_LoaiCauHoi objLoaiCauHoi = new QL_LoaiCauHoi();
        QL_ChuongHoc objChuongHoc = new QL_ChuongHoc();


        // GET: Admin/CauHoi
        public ActionResult Index()
        {
            ViewBag.Data_CauHoi = objCauHoi.Get_DanhSach_CauHoi();
            ViewBag.Data_CauTraLoi = objCauTraLoi.Get_DanhSach_CauTraLoi();
            ViewBag.Data_ChuongHoc = objChuongHoc.Get_DanhSach_ChuongHoc();
            return View();
        }
        public ActionResult Get_CauHoi(int id)
        {
            return Json(new { data = objCauHoi.Get_DanhSach_By_ID(id) });
        }
        public ActionResult Get_CauTraLoi(int id)
        {
            return Json(new { data = objCauTraLoi.Get_DanhSach_By_ID(id) });
        }



        //Thêm
        public JsonResult Them_CauTraLoi(int id, bool dungSai, string noiDung, int index)
        {
            CAUTRALOI cauTraLoi = new CAUTRALOI();
            cauTraLoi.IDCAUTL = 0;
            cauTraLoi.IDCAUHOI = id;
            cauTraLoi.DUNGSAI = dungSai;
            cauTraLoi.NOIDUNGCAUTL = noiDung;
            cauTraLoi.INDEXCTL = index;

            //Kiểm tra đã đủ đáp án đúng chưa
            if (dungSai == true)
            {
                //Lấy hình thức câu hỏi (câu hỏi có mấy câu trả lời đúng)
                List<CAUHOI> thisCH = objCauHoi.Get_DanhSach_By_ID(id);
                foreach (LOAICAUHOI lch in objLoaiCauHoi.Get_DanhSach_LoaiCauHoi())
                {
                    if (lch.IDLOAICAUHOI == thisCH[0].IDLOAICAUHOI)
                    {
                        LoaiCauhoi += lch.TENLOAICAUHOI;
                    }
                }
                LoaiCauhoi_sosanh = Convert.ToInt32(LoaiCauhoi.Substring(0, 1));
                //Đếm số lượng câu trả lời đúng của câu hỏi
                foreach (CAUTRALOI ctl in objCauTraLoi.GetByIdCauHoi(id))
                {
                    if (ctl.DUNGSAI == true)
                        invalidDapAnDung++;

                }
                //So sánh hình thức câu hỏi (1 đáp án, 2 đáp án) với số lượng đáp án đúng của câu hỏi

                if (invalidDapAnDung == LoaiCauhoi_sosanh)
                    invalidDapAnDung = 1;
                else
                {
                    invalidDapAnDung = 0;
                }
            }

            //Kiểm tra index đã tồn tại
            foreach (CAUTRALOI ctl in objCauTraLoi.GetByIdCauHoi(id))
            {
                if (ctl.INDEXCTL == index)
                {
                    invalidIndex = 1;
                    break;
                }
            }

            //Kiểm tra câu trả lời đã tồn tại
            foreach (CAUTRALOI ctl in objCauTraLoi.GetByIdCauHoi(id))
            {
                if (ctl.NOIDUNGCAUTL == noiDung)
                {
                    them = 1;
                    break;
                }
            }

            //Duyệt thêm đ/án -> index -> nội dung
            if (invalidDapAnDung == 0)
            {
                if (invalidIndex == 0)
                {
                    if (them == 0)
                    {
                        if (objCauTraLoi.Them_CauTraLoi(cauTraLoi) > 0)
                        {
                            SetAlert("Thêm thành công", "success");
                            return Json(new { data = true });
                        }
                        return Json(new { data = false });
                    }
                    else
                    {
                        return Json(new { data = "InvalidNoiDung" });
                    }
                }
                else
                {
                    return Json(new { data = "invalidIndex" });
                }
            }
            else
            {
                return Json(new { data = "invalidDapAnDung" });
            }

        }

        //Xóa 
        public JsonResult Xoa_CauTraLoi(int ID)
        {
            try
            {
                if (objCauTraLoi.Delete_CauTraLoi(ID) > 0)
                {
                    SetAlert("Xóa thành công!", "success");
                    return Json(new { data = true });
                }
                return Json(new { data = false });
            }
            catch (Exception)
            {
                return Json(new { data = false });
            }
        }


        //Sửa
        public JsonResult Sua_CauTraLoi(int ID, int IDCH, bool dungSai, string noiDung, int index)
        {
            CAUTRALOI cauTraLoi = new CAUTRALOI();
            cauTraLoi.IDCAUHOI = IDCH;
            cauTraLoi.IDCAUTL = ID;
            cauTraLoi.DUNGSAI = dungSai;
            cauTraLoi.INDEXCTL = index;
            cauTraLoi.NOIDUNGCAUTL = noiDung;

            List<CAUTRALOI> currentCTL = objCauTraLoi.Get_DanhSach_By_ID(ID);
            //Kiểm tra đã đủ đáp án đúng chưa
            if (dungSai != currentCTL[0].DUNGSAI)
            {
                //Lấy hình thức câu hỏi (câu hỏi có mấy câu trả lời đúng)
                List<CAUHOI> thisCH = objCauHoi.Get_DanhSach_By_ID(IDCH);
                foreach (LOAICAUHOI lch in objLoaiCauHoi.Get_DanhSach_LoaiCauHoi())
                {
                    if (lch.IDLOAICAUHOI == thisCH[0].IDLOAICAUHOI)
                    {
                        LoaiCauhoi += lch.TENLOAICAUHOI;
                    }
                }
                LoaiCauhoi_sosanh = Convert.ToInt32(LoaiCauhoi.Substring(0, 1));
                //Đếm số lượng câu trả lời đúng của câu hỏi
                foreach (CAUTRALOI ctl in objCauTraLoi.GetByIdCauHoi(IDCH))
                {
                    if (ctl.DUNGSAI == true)
                        invalidDapAnDung++;

                }
                //So sánh hình thức câu hỏi (1 đáp án, 2 đáp án) với số lượng đáp án đúng của câu hỏi

                if (invalidDapAnDung == LoaiCauhoi_sosanh)
                    invalidDapAnDung = 1;
                else
                {
                    invalidDapAnDung = 0;
                }
            }

            //Kiểm tra index đã tồn tại
            if (index != currentCTL[0].INDEXCTL)
            {
                foreach (CAUTRALOI ctl in objCauTraLoi.GetByIdCauHoi(IDCH))
                {
                    if (ctl.INDEXCTL == index)
                    {
                        invalidIndex = 1;
                        break;
                    }
                }
            }

            if (noiDung != currentCTL[0].NOIDUNGCAUTL)
            {
                //Kiểm tra câu trả lời đã tồn tại
                foreach (CAUTRALOI ctl in objCauTraLoi.GetByIdCauHoi(IDCH))
                {
                    if (ctl.NOIDUNGCAUTL == noiDung)
                    {
                        them = 1;
                        break;
                    }
                }
            }

            //Duyệt thêm đ/án -> index -> nội dung
            if (invalidDapAnDung == 0)
            {
                if (invalidIndex == 0)
                {
                    if (them == 0)
                    {
                        if (objCauTraLoi.Sua_CauTraLoi(cauTraLoi) > 0)
                        {
                            SetAlert("Sửa thành công", "success");
                            return Json(new { data = true });
                        }
                        return Json(new { data = false });
                    }
                    else
                    {
                        return Json(new { data = "InvalidNoiDung" });
                    }
                }
                else
                {
                    return Json(new { data = "invalidIndex" });
                }
            }
            else
            {
                return Json(new { data = "invalidDapAnDung" });
            }
        }
    }
}