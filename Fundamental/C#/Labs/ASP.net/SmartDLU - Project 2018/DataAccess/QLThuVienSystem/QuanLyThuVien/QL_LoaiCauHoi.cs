using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.QLThuVienSystem.Methods;

namespace DataAccess
{
    public class QL_LoaiCauHoi : LoaiCauHoiMethods
    {
        LoaiCauHoiMethods objLoaiCauHoi = new LoaiCauHoiMethods();

        /// <summary>
        /// Lấy tất cả danh sách loại câu hỏi trong csdl
        /// </summary>
        /// <returns></returns>
        public List<LOAICAUHOI> Get_DanhSach_LoaiCauHoi()
        {
            return objLoaiCauHoi.SelectAll();
        }

        /// <summary>
        /// Lấy loại câu hỏi theo id truyền vào
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<LOAICAUHOI> Get_DanhSach_By_ID(int ID)
        {
            return objLoaiCauHoi.SelectByID(ID);
        }

        /// <summary>
        /// Thêm loại câu hỏi vào csdl
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Them_LoaiCauHoi(LOAICAUHOI obj)
        {
            return objLoaiCauHoi.Add(obj);
        }

        /// <summary>
        /// Sửa thông tin loại câu hỏi
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Sua_LoaiCauHoi(LOAICAUHOI obj)
        {
            return objLoaiCauHoi.Update(obj);
        }

        /// <summary>
        /// Xóa một loại câu hỏi
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Delete_LoaiCauHoi(int ID)
        {
            return objLoaiCauHoi.Delete(ID);
        }
    }
}
