using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess
{

    public class QL_TaiKhoan: TaiKhoanMethods
    {
        TaiKhoanMethods objTaiKhoan = new TaiKhoanMethods();

        //-----------------------------QUẢN LÝ TAI KHOẢN -------------------------------//
        public List<TaiKhoan>  Get_DanhSach_TaiKhoan()//Lấy Tất Cả danh sách
        {
            return objTaiKhoan.SelectAll();
        }
        public List<TaiKhoan> Get_DanhSach_By_ID(int ID)// Lấy Danh Sách Theo ID
        {
            return objTaiKhoan.SelectByID(ID);
        }
        public List<TaiKhoan>GetBy(object item,string name)
        {
            return objTaiKhoan.SelectBy(item, name);
        }
        public int Them_TaiKhoan(TaiKhoan obj)//Thêm Tài Khoản
        {
            return objTaiKhoan.Add(obj);
        }
        public int Sua_TaiKhoan(TaiKhoan obj)//Suả Tài Khoản
        {
            return objTaiKhoan.Update(obj);
        }
        public int Delete_TaiKhoan(int ID)//Xoa Tài khoản
        {
            return objTaiKhoan.Delete(ID);
        }
        public List<TaiKhoan> Login(string username ,string password)//Dang Nhap Vao Hệ Thống
        {
            return objTaiKhoan.DangNhap(username, password);
        }
        public int Doi_MatKhau(int ID, string MatKhauMoi)//ThayDoiMat Khau
        {
            return objTaiKhoan.UpdatePassword(ID, MatKhauMoi);
        }
        public List<TaiKhoan> Get_DanhSachTaiKhoanLichThi(int IDLop,int IDLichThi)
        {
            return objTaiKhoan.TaiKhoanLichThi(IDLop, IDLichThi);
        }
    }
}
