using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using DataAccess;


namespace DLU.Controllers.ThiThu
{
    public class ThiThu_Controller : Controller
    {
        // GET: ThiThu_
        QuanLyThi qlt = new QuanLyThi();
        QL_MonHoc qlmonhoc = new QL_MonHoc();
        ThiThuMethods tt = new ThiThuMethods();
        KetQuaThiThuMethods kqtt = new KetQuaThiThuMethods();

        public ActionResult Index()
        {
            ViewBag.MonHoc = qlmonhoc.Get_DanhSach_MonHoc();
            return View();
        }
        
        public ActionResult ChonBoDe(FormCollection form)
        {
            int idMonHoc = Convert.ToInt32(form["Idmonhoc"]);
            List<BODE> bode = qlt.GetBoDeByIDMonHoc(idMonHoc);
            ViewBag.BoDe = bode;
            return View();
        }

        public ActionResult ChonDe(FormCollection form)
        {
            int idBoDe = Convert.ToInt32(form["idBoDe"]);
            string thoigian = form["idThoiGian"];
            qlt.CapNhatThoiGian(thoigian + ":00");
            List<DETHI> dethi = qlt.SelectDeThiByBoDe(idBoDe);
            ViewBag.DeThi = dethi;
            return View();
        }
        public ActionResult LuuDe(FormCollection form)
        {
            qlt.CapNhatDeThi(Convert.ToInt32(form["idDe"]));
            int IDthithu = tt.Them_ThiThu(new THITHU(-1, GetSession.IDDETHI));
            qlt.CapNhatLichThi(IDthithu);
            QL_CauHoi ql = new QL_CauHoi();
            List<CAUHOI> dsCauHoi = new List<CAUHOI>();
            dsCauHoi = ql.GetByIdDeThi(Convert.ToInt32(GetSession.IDDETHI));
            ViewBag.dsCauHoi = dsCauHoi;
            //Lấy danh sách câu trả lời
            QL_CauTraLoi qlCTL = new QL_CauTraLoi();
            List<CAUTRALOI> dsCauTraLoi = qlCTL.GetByIdDeThi(Convert.ToInt32(GetSession.IDDETHI));
            ViewBag.dsCauTraLoi = dsCauTraLoi;
            ViewBag.MADE = Convert.ToInt32(GetSession.IDDETHI);
            for (int i = 1; i <= dsCauHoi.Count; i++)
            {
                kqtt.Them_KetQuaThiThu(new KETQUATHITHU(GetSession.IDLICHTHI, i, -1));
            }
            return RedirectToAction("ThiThu");
        }

        public ActionResult ThiThu(FormCollection form)
        {
            //Lấy danh sách câu hỏi
            QL_CauHoi ql = new QL_CauHoi();
            List<CAUHOI> dsCauHoi = new List<CAUHOI>();
            dsCauHoi = ql.GetByIdDeThi(Convert.ToInt32(GetSession.IDDETHI));
            ViewBag.dsCauHoi = dsCauHoi;
            //Lấy danh sách câu trả lời
            QL_CauTraLoi qlCTL = new QL_CauTraLoi();
            List<CAUTRALOI> dsCauTraLoi = qlCTL.GetByIdDeThi(Convert.ToInt32(GetSession.IDDETHI));
            ViewBag.dsCauTraLoi = dsCauTraLoi;
            ViewBag.MADE = Convert.ToInt32(GetSession.IDDETHI);
            if (GetSession.THOIGIANCONLAI != null)
            {
                string[] time = Regex.Split(GetSession.THOIGIANCONLAI, ":");
                ViewBag.min = time[0];
                ViewBag.sec = time[1];
            }
            return View();
        }

        public ActionResult KetQuaThiThu()
        {
            //Lấy danh sách câu hỏi
            QL_CauHoi ql = new QL_CauHoi();
            List<CAUHOI> dsCauHoi = new List<CAUHOI>();
            dsCauHoi = ql.GetByIdDeThi(GetSession.IDDETHI);
            ViewBag.dsCauHoi = dsCauHoi;
            //Lấy danh sách câu trả lời
            QL_CauTraLoi qlCTL = new QL_CauTraLoi();
            List<CAUTRALOI> dsCauTraLoi = qlCTL.GetByIdDeThi(GetSession.IDDETHI);
            ViewBag.dsCauTraLoi = dsCauTraLoi;
            int tongsocauhoi = dsCauHoi.Count;
            List<KETQUATHITHU> kqt = kqtt.Get_DanhSach_By_ID(GetSession.IDLICHTHI);
            int soCauDung = 0;
            foreach (var item in kqt)
            {
                if (item.CAUTRALOI != -1)
                {
                    List<CAUTRALOI> ctl = qlCTL.Get_DanhSach_By_ID(item.CAUTRALOI);
                    if (ctl.First().DUNGSAI == true)
                        soCauDung++;
                }
            }
            double diem = 10.0 / (double)tongsocauhoi;
            ViewBag.DSKetQuaThi = kqt;
            ViewBag.Diem = String.Format("{0:0.##}", soCauDung * diem);
            ViewBag.KQ = soCauDung + "/" + dsCauHoi.Count;
            return View();
        }


        // Cập nhật câu trả lời của thí sinh
        [HttpPost]
        public void UpdateStudentTest(FormCollection form)
        {
            string answer = form["answer"];
            int id_quest = Convert.ToInt32(form["id"]);
            answer = answer.Trim();
            string time = form["min"] + ":" + form["sec"];
            //Model.UpdateStudentTest(answer);
            //Model.UpdateTiming(time);
            kqtt.Sua_KetQuaThiThu(new KETQUATHITHU(GetSession.IDLICHTHI,id_quest,Convert.ToInt32(answer)));
        }
    }
}