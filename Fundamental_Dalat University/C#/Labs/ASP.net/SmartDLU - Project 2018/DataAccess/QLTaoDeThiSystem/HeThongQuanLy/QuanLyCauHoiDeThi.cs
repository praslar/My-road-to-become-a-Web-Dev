using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QuanLyCauHoiDeThi
    {
        CauHoi_DeThiMethods objCauHoi_DeThi = new CauHoi_DeThiMethods();
        

        /// <summary>
        /// U6. Thêm đề thi
        /// Thêm mới một câu hỏi của đề thi
        /// </summary>
        /// <param name="cd"> Thông tin câu hỏi đề thi mới</param>
        /// <returns></returns>
        public int InsertWithOutput(CAUHOI_DETHI cd)
        {
            return objCauHoi_DeThi.InsertWithOutput(cd);
        }

        /// <summary>
        /// U8. Xóa đề thi
        /// Khi xóa đề thi, thì xóa luôn câu hỏi đề thi của đề thi đó
        /// U5. Xóa bộ đề
        /// Khi xóa bộ đề, thì xóa luôn câu hỏi đề thi
        /// </summary>
        /// <param name="id"> ID đề thi</param>
        /// <returns></returns>
        public int DeleteByIdDeThi(int id)
        {
            return objCauHoi_DeThi.DeleteByIdDeThi(id);
        }

        /// <summary>
        /// U5. Xóa bộ đề thi
        /// U8. Xóa đề thi
        /// </summary>
        /// <param name="idDeThi">ID Đề thi</param>
        /// <returns></returns>
        public List<CAUHOI_DETHI> GetByIdDeThi(int idDeThi)
        {
            return objCauHoi_DeThi.GetByIdDeThi(idDeThi);
        }

        /// <summary>
        /// U2. Chỉnh sửa bộ đề thi
        /// Thay đổi câu hỏi của bộ đề
        /// </summary>
        /// <param name="idCauHoiBoDe"></param>
        /// <returns></returns>
        public List<CAUHOI_DETHI> GetByIdCauHoiBoDe(int idCauHoiBoDe)
        {
            return objCauHoi_DeThi.GetByIdCauHoiBoDe(idCauHoiBoDe);
        }
    }
}
