using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QL_MonHoc:MonHocMethods
    {
        MonHocMethods objMonHoc = new MonHocMethods();

            /// <summary>
            /// Lấy tất cả môn học có trong csdl
            /// </summary>
            /// <returns></returns>
        public List<MONHOC> Get_DanhSach_MonHoc()
        {
            return objMonHoc.SelectAll();
        }

        /// <summary>
        /// Lấy một môn học theo id truyền vào
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<MONHOC> Get_DanhSach_By_ID(int ID)
        {
            return objMonHoc.SelectByID(ID);
        }

        /// <summary>
        /// Thêm một môn học
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Them_MonHoc(MONHOC obj)
        {
            return objMonHoc.Add(obj);
        }

        /// <summary>
        /// Sửa thông tin của môn học
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Sua_MonHoc(MONHOC obj)
        {
            return objMonHoc.Update(obj);
        }

        /// <summary>
        /// Xóa một môn học
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Delete_MonHoc(int ID)
        {
            return objMonHoc.Delete(ID);
        }
    }
}
