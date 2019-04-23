using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLU.Controllers.CauHoiOnTap
{
    public class CauHoiOnTap_Controller : Controller
    {
        QL_MonHoc qlmonhoc = new QL_MonHoc();
		QuanLyThi qlt = new QuanLyThi();
        // GET: CauHoiOnTap_
        public ActionResult Index()
        {
            ViewBag.MonHoc = qlmonhoc.Get_DanhSach_MonHoc();
            return View();
        }

		public ActionResult CauHoiOnTap(FormCollection form)
        {
			
			int IDMonHoc= Convert.ToInt32(form["Idmonhoc"]);
            ViewBag.MonHoc = qlmonhoc.Get_DanhSach_MonHoc();
			ViewBag.ChuongHoc = qlt.HienThiChuongHocTheoIdMonHoc(IDMonHoc);
            return View();
        }

		public ActionResult OnTap(FormCollection form)
		{
			int IDChuonghoc = Convert.ToInt32(form["Idchuonghoc"]);
			//Lấy danh sách câu hỏi
			QL_CauHoi ql = new QL_CauHoi();
			List<CAUHOI> dsCauHoi = new List<CAUHOI>();
			dsCauHoi = ql.GetByidChuongHoc(IDChuonghoc);
			ViewBag.dsCauHoi = dsCauHoi;
			//Lấy danh sách câu trả lời
			QL_CauTraLoi qlCTL = new QL_CauTraLoi();
			List<CAUTRALOI> dsCauTraLoi = qlCTL.Get_DanhSach_CauTraLoi();
			ViewBag.dsCauTraLoi = dsCauTraLoi;
			return View();
		}

	}
}