using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QL_ChucVu:ChucVuMethods
    {
        ChucVuMethods objChucVu = new ChucVuMethods();

        //-----------------------------QUẢN LÝ Chứ Vự -------------------------------//
        public List<ChucVu> Get_DanhSach_ChucVu()//Lấy Tất Cả danh sách
        {
            return objChucVu.SelectAll();
        }
        public List<ChucVu> Get_DanhSach_By_ID(int ID)// Lấy Danh Sách Theo ID
        {
            return objChucVu.SelectByID(ID);
        }
        public int Them_ChucVu(ChucVu obj)//Thêm Chứ Vự
        {
            return objChucVu.Add(obj);
        }
        public int Sua_ChucVu(ChucVu obj)//Suả Chứ Vự
        {
            return objChucVu.Update(obj);
        }
        public int Delete_ChucVu(int ID)//Xoa Chứ Vự
        {
            return objChucVu.Delete(ID);
        }
       
    }
}
