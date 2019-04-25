using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using System.Text.RegularExpressions;

namespace DLU.Controllers.ThiChinhThuc
{
    public class ThiChinhThuc_Controller : Controller
    {
        QuanLyThi qlt = new QuanLyThi();
        TaiKhoanLichThiMethods tklt = new TaiKhoanLichThiMethods();
        List<GETLICHTHIMODELVIEW> lt = new List<GETLICHTHIMODELVIEW>();
        public ActionResult Index()
        {
            List<TAIKHOANLICHTHI> tk= tklt.Get_DanhSach_By_IDTaiKhoan(Convert.ToInt32(Session["ID_TaiKhoan_SV"]));
            foreach(var item in tk)
            {
                foreach (var item1 in qlt.SelectLichThi())
                {
                    if (item1.IDLICHTHI == item.IDLICHTHI)
                        lt.Add(item1);
                }
            }
            return View(lt);
        }

        public ActionResult CheckMaBoDe(FormCollection form)
        {
            string IDLichThi = form["MaLichThi"];
            int code = Convert.ToInt32(IDLichThi);
            qlt.CapNhatLichThi(code);
            return RedirectToAction("ThemBangDiem");
        }
        public ActionResult ThemBangDiem()
        {
            DIEMTHI dt = new DIEMTHI();
            List<LICHTHI> lt = qlt.GetLichThiByID(GetSession.IDLICHTHI);
            dt.IDDOTTHI = lt.First().IDDOTTHI;
            dt.IDHOCKI = lt.First().IDHOCKI;
            List<BODE> bd = qlt.GetBoDeByID(Convert.ToInt32(lt.First().IDBODE.ToString()));
            dt.IDMONHOC = bd.First().IDMONHOC;
            dt.DINHCHI = 0;
            dt.CANHCAO = 0;
            dt.TONGDIEM = 0;
            dt.IDDIEMTHI = 0;
            dt.ID = Convert.ToInt32(Session["ID_TaiKhoan_SV"]);
            int IDDIEMTHI = qlt.Them_DiemThi(dt);
            qlt.CapNhatIDDiemThi(IDDIEMTHI);
            return RedirectToAction("ChonDeThi");
        }

        public ActionResult ChonDeThi()
        {
            return View(qlt.SelectDeThi(GetSession.IDLICHTHI));
        }

        public ActionResult CheckLamBai(FormCollection form)
        {
            XULYSUCO xuly = new XULYSUCO();
            string IDMaDe = form["MaDeThi"];
            string thoigian = form["thoigian"];
            int code = Convert.ToInt32(IDMaDe);
            qlt.CapNhatDeThi(code);
            qlt.CapNhatThoiGian(thoigian + ":00");
            xuly.IDBODE = code;
            xuly.IDXULYSUCO = 0;
            xuly.THOIGIAN = thoigian + ":00";
            xuly.ID = Convert.ToInt32(Session["ID_TaiKhoan_SV"]);
            xuly.NOIDUNG = "";
            qlt.TaoXuLySuCo(xuly);
            return RedirectToAction("TaoCTL");
        }

        public ActionResult TaoCTL()
        {
            //Lấy danh sách câu hỏi
            QL_CauHoi ql = new QL_CauHoi();
            KetQuaThiMethods kq = new KetQuaThiMethods();
            List<CAUHOI> dsCauHoi = new List<CAUHOI>();
            dsCauHoi = ql.GetByIdDeThi(GetSession.IDDETHI);
            for(int i=1;i<= dsCauHoi.Count;i++)
                kq.Them_KetQuaThi(new KETQUATHI(i,GetSession.IDDIEMTHI,GetSession.IDDETHI,-1));
            return RedirectToAction("LamBai");
        }

        public ActionResult LamBai()
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
            ViewBag.MADE = GetSession.IDDETHI;
            if (GetSession.THOIGIANCONLAI != null)
            {
                string[] time = Regex.Split(GetSession.THOIGIANCONLAI, ":");
                ViewBag.min = time[0];
                ViewBag.sec = time[1];
            }

            return View();
        }

        public ActionResult NopBai()
        {
            return View();
        }

		public ActionResult KetQuaLamBai()
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
            KetQuaThiMethods kq = new KetQuaThiMethods();
            List<KETQUATHI> kqt= kq.Get_DanhSach_By_ID(GetSession.IDDIEMTHI, GetSession.IDDETHI);
            int soCauDung = 0;
            foreach(var item in kqt)
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
            ViewBag.Diem = String.Format("{0:0.##}",soCauDung * diem);
            ViewBag.KQ = soCauDung + "/" + dsCauHoi.Count;
            if(diem>=0)
                qlt.UpdateDiem(GetSession.IDDIEMTHI, Convert.ToDecimal(String.Format("{0:0.##}", soCauDung * diem)));
            return View();
		}
		
		// Cập nhật thời gian thi
		[HttpPost]
		public void UpdateTiming(FormCollection form)
		{
			string min = form["min"];
			string sec = form["sec"];
			string time = min + ":" + sec;
			//Model.UpdateTiming(time);
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
            KetQuaThiMethods kq = new KetQuaThiMethods();
            kq.Sua_KetQuaThi(new KETQUATHI(id_quest, GetSession.IDDIEMTHI, GetSession.IDDETHI, Convert.ToInt32(answer)));
        }
	}
}