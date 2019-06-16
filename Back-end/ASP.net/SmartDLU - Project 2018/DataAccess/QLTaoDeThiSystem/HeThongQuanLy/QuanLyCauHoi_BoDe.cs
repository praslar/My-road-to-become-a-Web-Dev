using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QuanLyCauHoi_BoDe
    {
        CauHoi_BoDeMethods objCauHoi_BoDe = new CauHoi_BoDeMethods();

        /// <summary>
        /// U5. Xóa bộ đề thi
        /// U6. Thêm đề thi
        /// </summary>
        /// <param name="idBoDe"> ID bộ đề</param>
        /// <returns></returns>
        public List<CAUHOI_BODE> GetByIdBoDe(int idBoDe)
        {
            return objCauHoi_BoDe.GetByIdBoDe(idBoDe);
        }
        /// <summary>
        /// U5. Xóa bộ đề thi
        /// U8. Xóa đề thi
        /// </summary>
        /// <param name="id"> ID câu hỏi bộ đề cần xóa</param>
        /// <returns></returns>
        public int DeleteById(int id)
        {
            return objCauHoi_BoDe.Delete(id);
        }

        /// <summary>
        /// U2. Chính sửa bộ đề thi
        /// Thay đổi câu hỏi của bộ đề
        /// </summary>
        /// <param name="idBoDe"> ID bộ đề</param>
        /// <param name="idCauHoi"> ID câu hỏi</param>
        /// <returns></returns>
        public List<CAUHOI_BODE> GetByIdBoDeAndIdCauHoi(int idBoDe, int idCauHoi)
        {
            return objCauHoi_BoDe.GetByIdBoDeAndIdCauHoi(idBoDe, idCauHoi);
        }

        /// <summary>
        /// U2. Chỉnh sửa bộ đề thi
        /// Thay đổi câu hỏi của bộ đề
        /// </summary>
        /// <param name="cb"> Thông tin của câu hỏi bộ đề mới</param>
        /// <returns></returns>
        public int Update(CAUHOI_BODE cb)
        {
            return objCauHoi_BoDe.Update(cb);
        }

        /// <summary>
        /// U1. Tạo bộ đề
        /// </summary>
        /// <param name="cb"> Thông tin của câu hỏi bộ đề mới</param>
        /// <returns></returns>
        public int Insert(CAUHOI_BODE cb)
        {
            return objCauHoi_BoDe.Add(cb);
        }
    }
}
