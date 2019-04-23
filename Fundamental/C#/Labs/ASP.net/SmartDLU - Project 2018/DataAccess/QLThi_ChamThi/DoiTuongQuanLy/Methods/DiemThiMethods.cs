using Core;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class DiemThiMethods
	{
		BaseMethods<DIEMTHI> objdiemthi = new BaseMethods<DIEMTHI>();
		/*===== Hiển thị điểm thi ====== */

		public List<DIEMTHI> SelectAll()
		{
			return objdiemthi.SelectAll();
		}

        public List<DIEMTHI> Get_DanhSach_By_ID(int ID)
        {
            return objdiemthi.SelectByID(ID);
        }
        public int Them_DiemThi(DIEMTHI obj)
        {
            return objdiemthi.AddWithOutput(obj,"@IDDIEMTHI");
        }
		public int Them_DiemThi1(DIEMTHI obj)
		{
			return objdiemthi.Add(obj);
		}
		public int Sua_DiemThi(DIEMTHI obj)
        {
            return objdiemthi.Update(obj);
        }
        public int Delete_DiemThi(int ID)
        {
            return objdiemthi.Delete(ID);
        }
    }
}
