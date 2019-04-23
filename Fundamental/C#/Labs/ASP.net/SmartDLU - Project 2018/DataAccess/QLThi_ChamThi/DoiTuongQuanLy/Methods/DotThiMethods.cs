using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class DotThiMethods:BaseMethods<DOTTHI>
	{
		BaseMethods<DOTTHI> objdotthi = new BaseMethods<DOTTHI>();
        //hiển thị đợt thi
		public List<DOTTHI> SelectAll()
		{
			return objdotthi.SelectAll();
		}
        public List<DOTTHI> Get_DanhSach_By_ID(int ID)
        {
            return objdotthi.SelectByID(ID);
        }
        public int Them_DotThi(DOTTHI obj)
        {
            return objdotthi.Add(obj);
        }
        public int Sua_DotThi(DOTTHI obj)
        {
            return objdotthi.Update(obj);
        }
        public int Delete_DotThi(int ID)
        {
            return objdotthi.Delete(ID);
        }
    }
}
