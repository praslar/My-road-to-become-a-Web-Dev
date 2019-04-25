using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QuanLyCauTraLoiCuaCauHoiDeThi
    {
        CauTraLoiCuaCauHoiDeThiMethods objCauTraLoiCuaCauHoiDeThi = new CauTraLoiCuaCauHoiDeThiMethods();

        /// <summary>
        /// U6. Thêm đề thi
        /// Thêm mới một câu trả lời của câu hỏi đề thi
        /// </summary>
        /// <param name="c"> Thông tin câu trả lời của câu hỏi đề thi cần thêm</param>
        /// <returns></returns>
        public int Insert(CAUTRALOICUACAUHOIDETHI c)
        {
            return objCauTraLoiCuaCauHoiDeThi.Add(c);
        }
        /// <summary>
        /// U5. Xóa bộ đề thi
        /// U8. Xóa đề thi
        /// U2. Chỉnh sửa bộ đề thi
        /// </summary>
        /// <param name="id"> ID câu hỏi đề thi</param>
        /// <returns></returns>
        public int DeleteByIdCauHoiDeThi(int id)
        {
            return objCauTraLoiCuaCauHoiDeThi.DeleteByIdCauHoiDeThi(id);
        }
    }
}
