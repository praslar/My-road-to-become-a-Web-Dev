using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QL_ThongTinTaiKhoan : ThongTinTaiKhoanMedthods
    {
        ThongTinTaiKhoanMedthods objThongTinTaiKhoan = new ThongTinTaiKhoanMedthods();

        //-----------------------------QUẢN LÝ  THÔNG TIN TÀI KHOẢN -------------------------------//
        public List<ThongTinTaiKhoan> Get_DanhSach()//Lấy Tất Cả danh sách Thong Tin Tai Khoản
        {
            return objThongTinTaiKhoan.SelectAll();
        }
        public List<ThongTinTaiKhoan> Get_DanhSach_By_ID(long ID)// Lấy  Danh Sách Thong Tin Tai Khoản Theo ID
        {
            return objThongTinTaiKhoan.SelectByID(ID);
        }
        public int Them_ThongTinTaiKhoan(ThongTinTaiKhoan obj)//Thêm Thong Tin Tai Khoản
        {
            return objThongTinTaiKhoan.Add(obj);
        }
        public int Sua_ThongTinTaiKhoan(ThongTinTaiKhoan obj)//Suả Thong Tin Tai Khoản
        {
            return objThongTinTaiKhoan.Update(obj);
        }
        public int Delete_ThongTinTaiKhoan(int ID)//Xoa Thong Tin Tai Khoản
        {
            return objThongTinTaiKhoan.Delete(ID);
        }
        public int Delete_By(object item, string name)//Xoa Thong Tin Tai Khoản
        {
            return objThongTinTaiKhoan.DeleteBy(item,name);
        }

    }
}
