using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QuanLyDeThi
    {
        DeThiMethods objDeThi = new DeThiMethods();

        /// <summary>
        /// U9. Xem danh sách đề thi
        /// Lấy về danh sách đề thi của một bộ đề nào đó
        /// </summary>
        /// <param name="idBoDe"> ID của bộ đề</param>
        /// <returns></returns>
        /// 
        public List<DETHI> getDeThiByIDBoDe(int idBoDe)
        {
            return objDeThi.getDeThiByIDBODE(idBoDe);
        }
        

        /// <summary>
        /// U6. Thêm đề thi
        /// </summary>
        /// <param name="dt"> Thông tin của đề thi cần thêm</param>
        /// <returns></returns>
        /// 
        public object AddDeThiOutputId(DETHI dt)
        {
            return objDeThi.InsertDeThiOutput(dt);
        }

        /// <summary>
        /// U7. Chỉnh sửa đề thi
        /// Lấy về đề thi cần chỉnh sửa
        /// </summary>
        /// <param name="id"> ID của đề thi cần sửa</param>
        /// <returns></returns>
        /// 
        public List<DETHI> GetById(int id)
        {
            return objDeThi.SelectByID(id);
        }

        /// <summary>
        /// U7. Chỉnh sửa đề thi
        /// </summary>
        /// <param name="dt"> Thông tin mới của đề thi cần chỉnh sửa</param>
        /// <returns></returns>
        public int Update(DETHI dt)
        {
            return objDeThi.Update(dt);
        }

        /// <summary>
        /// U8. Xóa đề thi
        /// </summary>
        /// <param name="id"> ID của đề thi cần xóa</param>
        /// <returns></returns>
        public int DeleteById(int id)
        {
            return objDeThi.Delete(id);
        }
    }
}
