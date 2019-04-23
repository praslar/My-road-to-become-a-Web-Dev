using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QL_ChuongHoc:ChuongHocMethods
    {
        ChuongHocMethods objChuongHoc = new ChuongHocMethods();
        //-----------------------------QUẢN LÝ -------------------------------//
        /// <summary>
        /// Lấy danh sách chương học từ DB
        /// </summary>
        /// <returns>List_ChuongHoc</returns>
        public List<CHUONGHOC> Get_DanhSach_ChuongHoc()//Lấy Tất Cả danh sách

        {
            return objChuongHoc.SelectAll();
        }

        /// <summary>
        /// Lấy Danh Sách Theo ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<CHUONGHOC> Get_DanhSach_By_ID(int ID)
        {
            return objChuongHoc.SelectByID(ID);
        }

        /// <summary>
        /// Thêm chương học vào csdk
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Them_ChuongHoc(CHUONGHOC obj)
        {
            return objChuongHoc.Add(obj);
        }

        /// <summary>
        /// Sửa thông tin của chương học
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Sua_ChuongHoc(CHUONGHOC obj)
        {
            return objChuongHoc.Update(obj);
        }

        /// <summary>
        /// Xóa một chương học khỏi csdl
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Delete_ChuongHoc(int ID)
        {
            return objChuongHoc.Delete(ID);
        }


        //Nhóm 3
        /// <summary>
        /// lấy môn học theo id truyền vào
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public new List<CHUONGHOC> GetByIdMonHoc(int id)
        {
            return objChuongHoc.GetByIdMonHoc(id);
        }
    }
}
