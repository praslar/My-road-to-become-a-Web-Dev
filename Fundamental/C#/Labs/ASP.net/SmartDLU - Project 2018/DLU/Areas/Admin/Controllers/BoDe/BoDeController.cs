using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;

namespace DLU.Areas.Admin.Controllers.BoDe
{
    public class BoDeController : Controller
    {
        QL_MonHoc _qlmh = new QL_MonHoc();
        QuanLyBoDe _qlbd = new QuanLyBoDe();
        QL_CauHoi _qlch = new QL_CauHoi();
        QL_CauTraLoi _qlctl = new QL_CauTraLoi();
        QL_ChuongHoc _qlchgh = new QL_ChuongHoc();
        QL_DoKho _qldk = new QL_DoKho();
        QuanLyCauHoi_BoDe _qlchbd = new QuanLyCauHoi_BoDe();
        static List<CAUHOI> _listCauHoi = null;
        static int _soLuongCauHoi = 0;
        public ActionResult Index(int id)
        {
            ViewBag.idMonHoc = id;
            return View();
        }
        public ActionResult TaoBoDe(int id)
        {
            ViewBag.IDMONHOC = id;
            var listChuong = _qlchgh.GetByIdMonHoc(id);
            var listCauHoi = _qlch.Get_DanhSach_CauHoi();
            var listDoKho = _qldk.GetByIdMonHoc(id);
            var listCauTraLoi = _qlctl.Get_DanhSach_CauTraLoi();
            List<object> model = new List<object>();
            model.Add(listChuong);
            model.Add(listCauHoi);
            model.Add(listDoKho);
            model.Add(listCauTraLoi);
            return View(model);
        }
        public JsonResult GetBoDe(int id)
        {
            QuanLyBoDe ql = new QuanLyBoDe();
            List<BODE> dsBoDe = ql.getByIDMonHoc(id);
            return Json(new { data = dsBoDe }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SuaBoDe(int idBoDe, int idMonHoc)
        {
            QuanLyBoDe qlbd = new QuanLyBoDe();
            QL_CauHoi qlch = new QL_CauHoi();
            List<BODE> dsboDe = qlbd.getbyIDBoDe(idBoDe);
            List<CAUHOI> dsCauHoi = qlch.GetbyIdBoDe(dsboDe[0].IDBODE);
            ViewBag.dsCauHoi = dsCauHoi;
            ViewBag.idBoDe = idBoDe;
            ViewBag.idMonHoc = idMonHoc;
            return View(dsboDe[0]);
        }
        [HttpPost]
        public JsonResult SuaBoDe(BODE bd)
        {
            QuanLyBoDe qlbd = new QuanLyBoDe();
            if (ModelState.IsValid)
            {
                qlbd.Update(bd);
            }
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult XoaBoDe(int idBoDe)
        {
            QuanLyBoDe qlBoDe = new QuanLyBoDe();
            QuanLyDeThi qldt = new QuanLyDeThi();
            QuanLyCauHoiDeThi qlchdt = new QuanLyCauHoiDeThi();
            QuanLyCauTraLoiCuaCauHoiDeThi qlctlcchdt = new QuanLyCauTraLoiCuaCauHoiDeThi();
            QuanLyCauHoi_BoDe qlchbd = new QuanLyCauHoi_BoDe();
            List<DETHI> dsDeThi = qldt.getDeThiByIDBoDe(idBoDe);
            for (int i = 0; i < dsDeThi.Count; i++)
            {
                List<CAUHOI_DETHI> dsCauHoiDeThi = qlchdt.GetByIdDeThi(dsDeThi[i].IDMADE);
                for (int j = 0; j < dsCauHoiDeThi.Count; j++)
                {

                    qlctlcchdt.DeleteByIdCauHoiDeThi(dsCauHoiDeThi[j].IDCAUHOIDETHI);
                }
                qlchdt.DeleteByIdDeThi(dsDeThi[i].IDMADE);
                qldt.DeleteById(dsDeThi[i].IDMADE);
            }
            List<CAUHOI_BODE> dsCauHoiBoDe = qlchbd.GetByIdBoDe(idBoDe);
            for (int i = 0; i < dsCauHoiBoDe.Count; i++)
            {
                qlchbd.DeleteById(dsCauHoiBoDe[i].IDCAUHOIBODE);
            }
            qlBoDe.DeleteById(idBoDe);
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult LoadDanhSachCauHoiCuaMonHoc(int idMonHoc, int idBoDe)
        {
            QL_CauHoi qlch = new QL_CauHoi();
            List<CAUHOI> dsCauHoiCuaMonHoc = qlch.GetbyIdMonHoc(idMonHoc);
            List<CAUHOI> dsCauHoiCuaBoDe = qlch.GetbyIdBoDe(idBoDe);
            List<int> dsIdTrung = new List<int>();
            //Xóa trùng
            for (  int i = 0; i < dsCauHoiCuaMonHoc.Count; i++)
            {
                for (int j = 0; j < dsCauHoiCuaBoDe.Count; j++)
                {
                    if (dsCauHoiCuaMonHoc[i].IDCAUHOI == dsCauHoiCuaBoDe[j].IDCAUHOI)
                    {
                        dsIdTrung.Add(i);
                    }
                }
            }
            dsIdTrung.Sort();
            for(int i = dsIdTrung.Count-1; i >= 0; i--)
            {
                dsCauHoiCuaMonHoc.RemoveAt(dsIdTrung[i]);
            }
            string data = string.Empty;
            data = JsonConvert.SerializeObject(dsCauHoiCuaMonHoc, Formatting.Indented);

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult DoiCauHoi(int idBoDe, int idCauHoiBiDoi, int idCauHoiMuonDoiThanh)
        {
            Random r = new Random();
            QuanLyCauHoi_BoDe qlch_bd = new QuanLyCauHoi_BoDe();
            QuanLyCauHoiDeThi qlch_dt = new QuanLyCauHoiDeThi();
            QL_CauTraLoi qlCauTraLoi = new QL_CauTraLoi();
            QuanLyCauTraLoiCuaCauHoiDeThi qlCauTraLoiCuaCauHoiDeTHi = new QuanLyCauTraLoiCuaCauHoiDeThi();

            //lấy danh sách câu hỏi bộ đề có idBoDe và idCauHoiBiDoi
            List<CAUHOI_BODE> dsCauHoiBoDe = qlch_bd.GetByIdBoDeAndIdCauHoi(idBoDe, idCauHoiBiDoi);
            CAUHOI_BODE chbd = new CAUHOI_BODE();
            chbd.IDCAUHOIBODE = dsCauHoiBoDe[0].IDCAUHOIBODE;
            chbd.IDBODE = idBoDe;
            chbd.IDCAUHOI = idCauHoiMuonDoiThanh;
            //Update lại
            qlch_bd.Update(chbd);

            //Lấy danh sách câu hỏi đề thi có mã là idCauHoiBoDe
            List<CAUHOI_DETHI> dsCauHoiDeThi = qlch_dt.GetByIdCauHoiBoDe(dsCauHoiBoDe[0].IDCAUHOIBODE);

            //Xóa những bản ghi có idCauHoiDeThi trong bảng CauTraLoiCuaCauHoiDeThi
            for (int i = 0; i < dsCauHoiDeThi.Count; i++)
            {
                qlCauTraLoiCuaCauHoiDeTHi.DeleteByIdCauHoiDeThi(dsCauHoiDeThi[i].IDCAUHOIDETHI);
            }

            //Lấy danh sách câu trả lời của câu hỏi mới
            List<CAUTRALOI> dsCauTraLoi = qlCauTraLoi.GetByIdCauHoi(idCauHoiMuonDoiThanh);

            //Với mỗi CauHoiDeThi vừa lấy về, thêm vào bảng CauTraLoiCuaCauHoiDeThi kèm theo câu trả lời
            for (int i = 0; i < dsCauHoiDeThi.Count; i++)
            {
                //Xáo trộn danh sách câu trả lời của câu hỏi mới
                for (int j = 0; j < dsCauTraLoi.Count; j++)
                {
                    int soNgauNhien = r.Next(0, dsCauTraLoi.Count);
                    CAUTRALOI tam = dsCauTraLoi[0];
                    dsCauTraLoi[0] = dsCauTraLoi[soNgauNhien];
                    dsCauTraLoi[soNgauNhien] = tam;
                }
                //Insert vào bảng cautraloicuacauhoidethi với id của cauhoidethi
                for (int j = 0; j < dsCauTraLoi.Count; j++)
                {
                    CAUTRALOICUACAUHOIDETHI c = new CAUTRALOICUACAUHOIDETHI();
                    c.IDCAUHOIDETHI = dsCauHoiDeThi[i].IDCAUHOIDETHI;
                    c.IDCAUTL = dsCauTraLoi[j].IDCAUTL;
                    qlCauTraLoiCuaCauHoiDeTHi.Insert(c);
                }
            }
            return Json(JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult SaveSoCauHoiTrucTiep(int[] list)
        {
            var listch = _qlch.Get_DanhSach_CauHoi();
            int tong = new int();
            _listCauHoi = new List<CAUHOI>();
            //_boDe.SOLUONGCAUHOI = itemId.Count();
            foreach (var item in list)
            {
                foreach (var item1 in listch)
                {

                    if (item1.IDCAUHOI == item)
                    {
                        tong++;
                        _listCauHoi.Add(item1);
                    }
                }
            }
            int soLuongCauHoi = _listCauHoi.Count;
            string data = string.Empty;
            var obj = new
            {
                soCauHoi = tong,
                dsCauHoi = _listCauHoi

            };
            data = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult SaveSoCauHoiTheoChuong(int idMonHoc, int[] itemNumbers)
        {
            _listCauHoi = new List<CAUHOI>();
            int tong = 0;
            Random r = new Random();
            //Lấy danh sách chương học của môn học
            var dsChuongHoc = _qlchgh.GetByIdMonHoc(idMonHoc);
            

            for (int i = 0; i < dsChuongHoc.Count; i++)
            {
                List<CAUHOI> dsCauHoiCuaChuong = _qlch.GetByidChuongHoc(dsChuongHoc[i].IDCHUONGHOC);

                //Xáo trộn
                for (int j = 0; j < dsCauHoiCuaChuong.Count; j++)
                {
                    int soNgauNhien = r.Next(0, dsCauHoiCuaChuong.Count);
                    CAUHOI c = dsCauHoiCuaChuong[0];
                    dsCauHoiCuaChuong[0] = dsCauHoiCuaChuong[soNgauNhien];
                    dsCauHoiCuaChuong[soNgauNhien] = c;
                }

                for (int k = 0; k < itemNumbers[i]; k++)
                {
                    _listCauHoi.Add(dsCauHoiCuaChuong[k]);
                }
            }
            foreach (var item in itemNumbers)
            {
                tong += item;
            }
            var obj = new
            {
                soCauHoi = tong,
                dsCauHoi = _listCauHoi

            };
            _soLuongCauHoi = tong;
            string data = string.Empty;
            data = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult SaveSoCauHoiTheoDoKho(int idMonHoc, int soLuongCauHoi, int[] itemNumbers)
        {
            int tong = 0;
            int tongConLai = 0;
            _listCauHoi = new List<CAUHOI>();
            _soLuongCauHoi = soLuongCauHoi;
            Random r = new Random();
            //Lấy danh sách độ khó của môn học
            var dsDoKho = _qldk.GetByIdMonHoc(idMonHoc);

            //Danh sách số lượng câu hỏi muốn lấy của 1 độ khó
            List<int> dsSoLuongCauHoiMuonLay = new List<int>();

            for (int i = 0; i < itemNumbers.Count(); i++)
            {
                if (i != (itemNumbers.Count() - 1))
                {
                    decimal a = itemNumbers[i] * soLuongCauHoi / 100;
                    int soCauHoi = int.Parse(Math.Ceiling(a).ToString());
                    tongConLai += soCauHoi;
                    dsSoLuongCauHoiMuonLay.Add(soCauHoi);
                }
                else
                {
                    int soCauHoi = soLuongCauHoi - tongConLai;
                    dsSoLuongCauHoiMuonLay.Add(soCauHoi);
                }
            }

            List<CAUHOI> dsCauHoiCanLay = new List<CAUHOI>();

            for (int i = 0; i < dsDoKho.Count; i++)
            {
                List<CAUHOI> dsCauHoiTheoDoKho = _qlch.GetByNameDoKho_IdMonHoc(dsDoKho[i].TENDOKHO, idMonHoc);
                //Xáo trộn
                for (int j = 0; j < dsCauHoiTheoDoKho.Count; j++)
                {
                    int soNgauNhien = r.Next(0, dsCauHoiTheoDoKho.Count);
                    CAUHOI c = dsCauHoiTheoDoKho[0];
                    dsCauHoiTheoDoKho[0] = dsCauHoiTheoDoKho[soNgauNhien];
                    dsCauHoiTheoDoKho[soNgauNhien] = c;
                }

                for (int k = 0; k < dsSoLuongCauHoiMuonLay[i]; k++)
                {
                    dsCauHoiCanLay.Add(dsCauHoiTheoDoKho[k]);
                }
            }
            for (int i = 0; i < dsCauHoiCanLay.Count; i++)
            {
                _listCauHoi.Add(dsCauHoiCanLay[i]);
            }
            foreach (var item in dsSoLuongCauHoiMuonLay)
            {
                tong += item;
            }
            var obj = new
            {
                soCauHoi = tong,
                dsCauHoi = _listCauHoi

            };

            string data = string.Empty;
            data = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult XacNhanTaoBoDe(BODE boDe)
        {
            BODE b = new BODE();
            b.IDMONHOC = boDe.IDMONHOC;
            b.TENBODE = boDe.TENBODE;
            b.SOLUONGCAUHOI = boDe.SOLUONGCAUHOI;
            b.MUCDIEMDAT = boDe.MUCDIEMDAT;
            b.DIEMTOIDA = boDe.DIEMTOIDA;
            b.NGAYTAOBODE = DateTime.Now;
            b.THOIGIANLAMBAI_PHUT_ = boDe.THOIGIANLAMBAI_PHUT_;
            int idBoDe = _qlbd.InsertWithOutput(b);
            for (int i = 0; i < _listCauHoi.Count; i++)
            {
                CAUHOI_BODE cb = new CAUHOI_BODE();
                cb.IDBODE = idBoDe;
                cb.IDCAUHOI = _listCauHoi[i].IDCAUHOI;
                _qlchbd.Insert(cb);
            }


            return Json(new { data = "sdf" }, JsonRequestBehavior.AllowGet);

        }



    }
}