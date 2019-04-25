using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.QLThuVienSystem.Methods;

namespace DataAccess
{
    public class QL_DoKho : DoKhoMethods
    {
        DoKhoMethods objDoKho = new DoKhoMethods();

        /// <summary>
        /// Lấy Tất Cả danh sách độ khó
        /// </summary>
        /// <returns></returns>
        public List<DOKHO> Get_DanhSach_DoKho()
        {
            return objDoKho.SelectAll();
        }

        /// <summary>
        /// Lấy Danh Sách Theo ID truyền vào
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<DOKHO> Get_DanhSach_By_ID(int ID)
        {
            return objDoKho.SelectByID(ID);
        }

        /// <summary>
        /// Thêm độ khó
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Them_DoKho(DOKHO obj)
        {
            return objDoKho.Add(obj);
        }

        /// <summary>
        /// Sửa thông tin độ khó 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Sua_DoKho(DOKHO obj)
        {
            return objDoKho.Update(obj);
        }

        /// <summary>
        /// Xóa một độ khó
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Delete_DoKho(int ID)
        {
            return objDoKho.Delete(ID);
        }

        //Nhóm 3
        public new List<DOKHO> GetByIdMonHoc(int idMonHoc)
        {
            return objDoKho.GetByIdMonHoc(idMonHoc);
        }
    }
}
