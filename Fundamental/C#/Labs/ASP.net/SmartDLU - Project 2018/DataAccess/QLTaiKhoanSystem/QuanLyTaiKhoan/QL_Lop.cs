using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QL_Lop:LopMethods
    {
        LopMethods objLop = new LopMethods();
        //-----------------------------QUẢN LÝ Nhóm -------------------------------//
        public List<Lop> Get_DanhSach_Lop()//Lấy Tất Cả danh sách
        {
            return objLop.SelectAll();
        }
        public List<Lop> Get_DanhSach_By_ID(int ID)// Lấy Danh Sách Theo ID
        {
            return objLop.SelectByID(ID);
        }
        public List<Lop> Get_DanhSach_By(int ID,string name)// Lấy Danh Sách Theo ID
        {
            return objLop.SelectBy(ID,name);
        }
        public int Them_Lop(Lop obj)//Thêm Nhóm
        {
            return objLop.Add(obj);
        }
        public int Sua_Lop(Lop obj)//Suả Nhóm
        {
            return objLop.Update(obj);
        }
        public int Delete_Lop(int ID)//Xoa Nhóm
        {
            return objLop.Delete(ID);
        }
    }
}
