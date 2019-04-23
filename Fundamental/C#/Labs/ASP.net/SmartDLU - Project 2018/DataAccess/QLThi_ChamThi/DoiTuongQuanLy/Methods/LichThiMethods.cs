using Core;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LichThiMethods
    {
        BaseMethods<LICHTHI> objlichthi = new BaseMethods<LICHTHI>();
		/*=================== Hiển thị lịch thi ======================= */

		/*==== Lấy tất cả lịch thi */
		public List<LICHTHI> SelectAll()
        {
            return objlichthi.SelectAll();
        }

        public List<LICHTHI> Get_DanhSach_By_ID(int ID)// Lấy Danh Sách Theo ID
        {
            return objlichthi.SelectByID(ID);
        }
        public int Them_LichThi(LICHTHI obj)//Thêm lich thi
        {
            return objlichthi.Add(obj);
        }
        public int Sua_LichThi(LICHTHI obj)//Suả Chứ Vự
        {
            return objlichthi.Update(obj);
        }
        public int Delete_LichThi(int ID)//Xoa Chứ Vự
        {
            return objlichthi.Delete(ID);
        }
    }
}
