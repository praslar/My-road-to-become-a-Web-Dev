using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Core;
using System.Web;

namespace DataAccess
{
	public class QuanLyThi
	{

		LichThiMethods lichthi = new LichThiMethods();
		MonHocMethods monhoc = new MonHocMethods();
		HocKiMethods hocki = new HocKiMethods();
		DotThiMethods dotthi = new DotThiMethods();
		DiemThiMethods diemthi = new DiemThiMethods();
		KetQuaThiMethods ketqua = new KetQuaThiMethods();
		BoDeMethods bode = new BoDeMethods();
		ChuongHocMethods chuonghoc = new ChuongHocMethods();
		XuLySuCoMethods xulysuco = new XuLySuCoMethods();

		public List<LICHTHI> GetLichThiByID(int IDLICHTHI)
		{
			return lichthi.Get_DanhSach_By_ID(IDLICHTHI);
		}
		public List<GETLICHTHIMODELVIEW> SelectLichThi()
		{
			return CBO.FillCollection<GETLICHTHIMODELVIEW>(DataProvider.Instance.ExecuteReader(typeof(GETLICHTHIMODELVIEW).Name + "_GetAll"));
		}
		public List<GETDETHIMODELVIEW> SelectDeThi(int IDLichThi)
        {
            List<GETDETHIMODELVIEW> list;
            list=CBO.FillCollection<GETDETHIMODELVIEW>(DataProvider.Instance.ExecuteReader(typeof(GETDETHIMODELVIEW).Name + "_GetByID", IDLichThi));
			return list;
        }
        public List<DETHI> SelectDeThiByBoDe(int IDBoDe)
        {
            return CBO.FillCollection<DETHI>(DataProvider.Instance.ExecuteReader(typeof(DETHI).Name + "_GetByIDBODE", IDBoDe));
            
        }
        public List<GETDETHIMODELVIEW> SelectDeThi()
        {
            return CBO.FillCollection<GETDETHIMODELVIEW>(DataProvider.Instance.ExecuteReader(typeof(GETDETHIMODELVIEW).Name + "_GetAll"));
        }

		public List<GETDIEMTHIMODELVIEW> SelectDiemThiTheoTaiKhoan(int ID)
		{
			List<GETDIEMTHIMODELVIEW> list;
			list = CBO.FillCollection<GETDIEMTHIMODELVIEW>(DataProvider.Instance.ExecuteReader(typeof(GETDIEMTHIMODELVIEW).Name + "_GetByIDTaiKhoan", ID));
			return list;
		}

		// chương học
		public List<CHUONGHOC> HienThiChuongHocTheoIdMonHoc(int IDMonHoc)
		{
			return chuonghoc.GetByIdMonHoc(IDMonHoc);
		}

		public int UpdateDiem(int IDDiemThi, decimal DiemThi)
        {
            return DataProvider.Instance.ExecuteNonQuery(typeof(DIEMTHI).Name + "_UpdateDiem",IDDiemThi,DiemThi);
        }
        public List<LICHTHI> HienThiLichThi()
		{
			return lichthi.SelectAll();
		}

		public List<MONHOC> HienThiMonHoc()
		{
			return monhoc.SelectAll();
		}

		public List<HOCKI> HienThihocki()
		{
			return hocki.SelectAll();
		}

		public List<DOTTHI> HienThidotthi()
		{
			return dotthi.SelectAll();
		}

		public List<XULYSUCO> Hienthixulysuco()
		{
			return xulysuco.SelectAll();
		}
		//======================= get by id ==================//
		public List<LICHTHI> Get_DS_LichThi_By_ID(int id)
		{
			return lichthi.Get_DanhSach_By_ID(id);
		}
		public List<DOTTHI> Get_DS_DotThi_By_ID(int id)
		{
			return dotthi.Get_DanhSach_By_ID(id);
		}
		public List<HOCKI> Get_DS_HocKi_By_ID(int id)
		{
			return hocki.Get_DanhSach_By_ID(id);
		}

		public List<DIEMTHI> Get_DS_DiemThi_By_ID(int id)
		{
			return diemthi.Get_DanhSach_By_ID(id);
		}
		//======================= Thêm ======================//
		public int Them_LichThi(LICHTHI lich)
		{
			return lichthi.Them_LichThi(lich);
		}
		public int Them_DotThi(DOTTHI dot)
		{
			return dotthi.Them_DotThi(dot);
		}

		public int Them_KetQuaThi(KETQUATHI kq)
		{
			return ketqua.Them_KetQuaThi(kq);
		}

		public int Them_HocKi(HOCKI hk)
		{
			return hocki.Them_HocKi(hk);
		}

		//======================= Xóa ======================//

		public int Xoa_LichThi(int idlich)
		{
			return lichthi.Delete_LichThi(idlich);
		}

		public int Xoa_DotThi(int id)
		{
			return dotthi.Delete_DotThi(id);
		}

		public int Xoa_KetQuaThi(int id)
		{
			return ketqua.Delete_KetQuaThi(id);
		}

		public int Xoa_HocKi(int id)
		{
			return hocki.Delete_HocKi(id);
		}

		public int Xoa_DiemThi(int id)
		{
			return diemthi.Delete_DiemThi(id);
		}

		//======================= Sửa ======================//
		public int Sua_LichThi(LICHTHI lich)
		{
			return lichthi.Sua_LichThi(lich);
		}

		public int Sua_DotThi(DOTTHI dot)
		{
			return dotthi.Sua_DotThi(dot);
		}
		public int Sua_KetQuaThi(KETQUATHI kq)
		{
			return ketqua.Sua_KetQuaThi(kq);
		}

		public int Sua_HocKi(HOCKI hk)
		{
			return hocki.Sua_HocKi(hk);
		}

		public int Sua_DiemThi(DIEMTHI dt)
		{
			return diemthi.Sua_DiemThi(dt);
		}
		//=================================================//

		public List<BODE> HienThibode()
		{
			return bode.SelectAll();
		}
		public List<BODE> GetBoDeByID(int IDBoDe)
		{
			return bode.SelectByID(IDBoDe);
		}
        // điểm thi
        public List<DIEMTHI> HienThiDiemThi()
        {
            return diemthi.SelectAll();
        }
        public List<BODE> GetBoDeByIDMonHoc(int IDMonHoc)
        {
            return CBO.FillCollection<BODE>(DataProvider.Instance.ExecuteReader(typeof(BODE).Name + "_GetByIDMonHoc", IDMonHoc));
        }

        public int Them_DiemThi(DIEMTHI dt)
		{
			return diemthi.Them_DiemThi(dt);
		}
		public int Them_DiemThi1(DIEMTHI dt)
		{
			return diemthi.Them_DiemThi1(dt);
		}
		public void CapNhatLichThi(int IDLichThi)
		{
			HttpContext.Current.Session[UserSession.IDLICHTHI] = IDLichThi;
			GetSession.IDLICHTHI = IDLichThi;
		}

        public void CapNhatDeThi(int IDDeThi)
        {
            HttpContext.Current.Session[UserSession.IDDETHI] = IDDeThi;
            GetSession.IDDETHI = IDDeThi;
        }

		public void CapNhatThoiGian(string ThoiGian)
		{
			HttpContext.Current.Session[UserSession.THOIGIANCONLAI] = ThoiGian;
			GetSession.THOIGIANCONLAI = ThoiGian;
		}
		public void CapNhatIDDiemThi(int IDDiemThi)
		{
			HttpContext.Current.Session[UserSession.IDDIEMTHI] =IDDiemThi ;
			GetSession.IDDIEMTHI = IDDiemThi;
		}

		// Tạo xử lý sự cố
		public int TaoXuLySuCo(XULYSUCO xuly)
		{
			return xulysuco.Them_XuLySuCo(xuly);
		}

		// Cập nhật thời gian xử lý sự cố
		public int CapNhatThoiGianXuLy(XULYSUCO xuly)
		{
			return xulysuco.Sua_XuLySuCo(xuly);
		}

		//==================== Hàm lẻ ==================== //
		public string Get_TenMonHoc(int ID)
		{
			
			string TenMonHoc = "";
			foreach (var row in monhoc.SelectByID(ID))
			{
				TenMonHoc = row.TENMONHOC;
			}
			return TenMonHoc;
		}

		public string Get_TenHocKi(int ID)
		{

			string Ten = "";
			foreach (var row in hocki.SelectByID(ID))
			{
				Ten = row.TENHOCKI;
			}
			return Ten;
		}

		public string Get_TenDotThi(int ID)
		{

			string Ten = "";
			foreach (var row in dotthi.SelectByID(ID))
			{
				Ten = row.TENDOTTHI;
			}
			return Ten;
		}

	}
}
