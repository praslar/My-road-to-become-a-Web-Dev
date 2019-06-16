using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using System.Threading.Tasks;
namespace DataAccess
{
    public class QL_CauTraLoi:CauTraLoiMethods
    {
        CauTraLoiMethods objCauTraLoi = new CauTraLoiMethods();
        public List<CAUTRALOI> Get_DanhSach_CauTraLoi()
        {
            return objCauTraLoi.SelectAll();
        }
        public List<CAUTRALOI> Get_DanhSach_By_ID(int ID)
        {
            return objCauTraLoi.SelectByID(ID);
        }
        public int Them_CauTraLoi(CAUTRALOI obj)
        {
            return objCauTraLoi.Add(obj);
        }
        public int Sua_CauTraLoi(CAUTRALOI obj)
        {
            return objCauTraLoi.Update(obj);
        }
        public int Delete_CauTraLoi(int ID)
        {
            return objCauTraLoi.Delete(ID);
        }

        //Nhóm 3
        /// <summary>
        /// U2. Chỉnh sửa bộ đề thi
        /// Lấy về danh sách câu trả lời của câu hỏi
        /// </summary>
        /// <param name="idCauHoi"> ID câu hỏi</param>
        /// <returns></returns>
        /// 
        public new List<CAUTRALOI> GetByIdCauHoi(int idCauHoi)
        {
            return objCauTraLoi.GetByIdCauHoi(idCauHoi);
        }
        /// <summary>
        /// U10. Xem chi tiết đề thi
        /// Lấy về danh sách câu trả lời của đề thi
        /// </summary>
        /// <param name="idDeThi">ID đề thi</param>
        /// <returns></returns>
        public new List<CAUTRALOI> GetByIdDeThi(int idDeThi)
        {
            return objCauTraLoi.GetByIdDeThi(idDeThi);
        }

        /// <summary>
        /// U6. Thêm đề thi
        /// Lấy về danh sách câu trả lời của câu hỏi đề thi
        /// </summary>
        /// <param name="id">ID câu hỏi đề thi</param>
        /// <returns></returns>
        public new List<CAUTRALOI> GetByIdCauHoiDeThi(int id)
        {
            return objCauTraLoi.GetByIdCauHoi(id);
        }
    }
}