using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccess
{
    public class QuanLyBoDe
    {
        BoDeMethods objBoDe = new BoDeMethods();
        

        /// <summary>
        /// U4. Xem danh sách bộ đề thi của môn học
        /// </summary>
        /// <param name="idMonHoc"> ID của môn học cần xem danh sách bộ đề thi</param>
        /// <returns></returns>
        public List<BODE> getByIDMonHoc(int idMonHoc)
        {
            return objBoDe.GetByIDMonHoc(idMonHoc);
        }

        /// <summary>
        /// U2. Chỉnh sủa bộ đề
        /// Lấy về bộ đề cần chỉnh sửa
        /// </summary>
        /// <param name="idBoDe"> ID của bộ đề cần sửa</param>
        /// <returns></returns>
        public List<BODE> getbyIDBoDe(int idBoDe)
        {
            return objBoDe.SelectByID(idBoDe);
        }

        /// <summary>
        /// U5. Xóa bộ đề thi
        /// </summary>
        /// <param name="id"> ID của bộ đề cần xóa</param>
        /// <returns></returns>
        public int DeleteById(int id)
        {
            return objBoDe.Delete(id);
        }

        /// <summary>
        /// U2. Chỉnh sủa bộ đề
        /// </summary>
        /// <param name="bd"> Thông tin mới của bộ đề</param>
        /// <returns></returns>
        public int Update(BODE bd)
        {
            return objBoDe.Update(bd);
        }

        /// <summary>
        /// U1. Tạo bộ đề
        /// </summary>
        /// <param name="bd"> Thông tin của bộ đề cần tạo</param>
        /// <returns></returns>
        public int InsertWithOutput(BODE bd)
        {
            return objBoDe.InsertWithOutput(bd);
        }
    }
}
