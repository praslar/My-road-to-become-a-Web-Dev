using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;

namespace DLU.Areas.Admin.Controllers.DeThi
{
    public class DeThiController : Controller
    {
        // GET: DeThi
        public ActionResult Index(int id, int idMonHoc)
        {
            ViewBag.idMonHoc = idMonHoc;
            ViewBag.idBoDe = id;
            return View();
        }
        public JsonResult GetDeThi(int id)
        {
            QuanLyDeThi ql = new QuanLyDeThi();
            List<DETHI> dsDeThi = ql.getDeThiByIDBoDe(id);
            return Json(new { data = dsDeThi }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ThemDeThiMoi(DETHI dtModel)
        {
            //thêm đề thi
            QuanLyDeThi ql = new QuanLyDeThi();
            DETHI dt = new DETHI();
            dt.IDBODE = dtModel.IDBODE;
            dt.TENDETHI = dtModel.TENDETHI;
            int idIdDeThiMoi = int.Parse(ql.AddDeThiOutputId(dt).ToString());

            //Lấy câu hỏi của bộ đề
            QuanLyCauHoi_BoDe qlchbd = new QuanLyCauHoi_BoDe();
            List<CAUHOI_BODE> dsCauHoiBoDe = qlchbd.GetByIdBoDe(dtModel.IDBODE);

            //Xáo trộn câu hỏi bộ đề
            Random r = new Random();
            for (int i = 0; i < dsCauHoiBoDe.Count; i++)
            {
                int n = r.Next(0, (dsCauHoiBoDe.Count));
                CAUHOI_BODE tam = dsCauHoiBoDe[0];
                dsCauHoiBoDe[0] = dsCauHoiBoDe[n];
                dsCauHoiBoDe[n] = tam;
            }

            //Thêm câu hỏi đề thi
            QuanLyCauHoiDeThi qlchdt = new QuanLyCauHoiDeThi();
            List<int> dsIdCauHoiDeThiMoi = new List<int>();
            for (int i = 0; i < dsCauHoiBoDe.Count; i++)
            {
                CAUHOI_DETHI chdt = new CAUHOI_DETHI();
                chdt.IDCAUHOIBODE = dsCauHoiBoDe[i].IDCAUHOIBODE;
                chdt.IDMADE = idIdDeThiMoi;
                int idCHDTMoi = qlchdt.InsertWithOutput(chdt);
                dsIdCauHoiDeThiMoi.Add(idCHDTMoi);
            }
            //Thêm câu trả lời của câu hỏi đề thi
            QL_CauTraLoi qlctl = new QL_CauTraLoi();
            QuanLyCauTraLoiCuaCauHoiDeThi qlctlcchdt = new QuanLyCauTraLoiCuaCauHoiDeThi();
            for (int i = 0; i < dsIdCauHoiDeThiMoi.Count; i++)
            {
                List<CAUTRALOI> dsCauTraLoiCuaCauHoiDeThi = qlctl.GetByIdCauHoiDeThi(dsIdCauHoiDeThiMoi[i]);
                //xáo trộn danh sách câu trả lời
                for (int k = 0; k < dsCauTraLoiCuaCauHoiDeThi.Count; k++)
                {
                    int n = r.Next(0, dsCauTraLoiCuaCauHoiDeThi.Count);
                    CAUTRALOI tam = dsCauTraLoiCuaCauHoiDeThi[0];
                    dsCauTraLoiCuaCauHoiDeThi[0] = dsCauTraLoiCuaCauHoiDeThi[n];
                    dsCauTraLoiCuaCauHoiDeThi[n] = tam;
                }
                //thêm câu trả lời vào bảng câu trả lời của câu hỏi đề thi
                for (int l = 0; l < dsCauTraLoiCuaCauHoiDeThi.Count; l++)
                {
                    CAUTRALOICUACAUHOIDETHI ctlcchdt = new CAUTRALOICUACAUHOIDETHI();
                    ctlcchdt.IDCAUHOIDETHI = dsIdCauHoiDeThiMoi[i];
                    ctlcchdt.IDCAUTL = dsCauTraLoiCuaCauHoiDeThi[l].IDCAUTL;
                    qlctlcchdt.Insert(ctlcchdt);
                }
            }
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult SuaDeThi(int idDeThi)
        {
            QuanLyDeThi qldt = new QuanLyDeThi();
            List<DETHI> dsDeThi = qldt.GetById(idDeThi);
            DETHI dt = dsDeThi[0];
            string value = string.Empty;
            value = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return Json(value, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult SuaDeThi(DETHI dt)
        {
            QuanLyDeThi ql = new QuanLyDeThi();
            if (ModelState.IsValid)
            {
                ql.Update(dt);
            }
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult XoaDeThi(int IdDeThi)
        {
            //bool status = false;
            QuanLyDeThi qldt = new QuanLyDeThi();
            QuanLyCauHoiDeThi qlchdt = new QuanLyCauHoiDeThi();
            QuanLyCauTraLoiCuaCauHoiDeThi qlctlcchdt = new QuanLyCauTraLoiCuaCauHoiDeThi();
            List<CAUHOI_DETHI> dsCauHoiDeThi = qlchdt.GetByIdDeThi(IdDeThi);
            for (int i = 0; i < dsCauHoiDeThi.Count; i++)
            {
                qlctlcchdt.DeleteByIdCauHoiDeThi(dsCauHoiDeThi[i].IDCAUHOIDETHI);
            }
            qlchdt.DeleteByIdDeThi(IdDeThi);
            qldt.DeleteById(IdDeThi);
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}