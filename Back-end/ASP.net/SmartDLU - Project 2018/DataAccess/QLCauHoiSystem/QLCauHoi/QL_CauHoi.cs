using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QL_CauHoi : CauHoiMethods
    {
        CauHoiMethods objCauHoi = new CauHoiMethods();
        //-----------------------------QUẢN LÝ Nhóm -------------------------------//
        public List<CAUHOI> Get_DanhSach_CauHoi()//Lấy Tất Cả danh sách
        {
            return objCauHoi.SelectAll();
        }
        public List<CAUHOI> Get_DanhSach_By_ID(int ID)// Lấy Danh Sách Theo ID
        {
            return objCauHoi.SelectByID(ID);
        }
        public int Them_CauHoi(CAUHOI obj)//Thêm Nhóm
        {
            return objCauHoi.Add(obj);
        }
        public int Sua_CauHoi(CAUHOI obj)//Suả Nhóm
        {
            return objCauHoi.Update(obj);
        }
        public int Delete_CauHoi(int ID)//Xoa Nhóm
        {
            return objCauHoi.Delete(ID);
        }
        //Nhóm 3
        /// <summary>
        /// U1.3: Random câu hỏi theo chương học
        /// Lấy danh sách câu hỏi theo chương học
        /// </summary>
        /// <param name="idChuongHoc">ID chương học</param>
        /// <returns></returns>
        /// 
        public List<CAUHOI> GetByidChuongHoc(int idChuongHoc)
        {
            return objCauHoi.GetByIdChuongHoc(idChuongHoc);
        }
        /// <summary>
        /// U1.2: Random câu hỏi theo độ khó
        /// Lấy danh sách câu hỏi theo độ khó
        /// </summary>
        /// <param name="tenDoKho"></param>
        /// <param name="idMonHoc"></param>
        /// <returns></returns>
        public new List<CAUHOI> GetByNameDoKho_IdMonHoc(string tenDoKho, int idMonHoc)

        {
            return objCauHoi.GetByNameDoKho_IdMonHoc(tenDoKho, idMonHoc);
        }
        /// <summary>
        /// U10. Xem danh sách đề thi
        /// Lấy danh sách câu hỏi theo đề thi
        /// </summary>
        /// <param name="idDeThi"></param>
        /// <returns></returns>
        public new List<CAUHOI> GetByIdDeThi(int idDeThi)
        {
            return objCauHoi.GetByIdDeThi(idDeThi);
        }
        /// <summary>
        /// U2. Chỉnh sửa bộ đề thi
        /// Lấy về danh sách câu hỏi theo bộ đề
        /// </summary>
        /// <param name="idBoDe">ID bộ đề</param>
        /// <returns></returns>
        public List<CAUHOI> GetbyIdBoDe(int idBoDe)
        {
            return objCauHoi.GetByIdBoDe(idBoDe);
        }
        /// <summary>
        /// U2. Chỉnh sửa bộ đề thi
        /// Lấy về danh sách câu hỏi theo môn học
        /// </summary>
        /// <param name="idMonHoc">ID môn học</param>
        /// <returns></returns>
        public List<CAUHOI> GetbyIdMonHoc(int idMonHoc)
        {
            return objCauHoi.GetByIdMonHoc(idMonHoc);
        }
    }
}
