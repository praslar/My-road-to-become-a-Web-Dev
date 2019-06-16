using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class XuLySuCoMethods
	{
		BaseMethods<XULYSUCO> objxulysuco = new BaseMethods<XULYSUCO>();
		public List<XULYSUCO> SelectAll()
		{
			return objxulysuco.SelectAll();
		}
        public List<XULYSUCO> Get_DanhSach_By_ID(int ID)
        {
            return objxulysuco.SelectByID(ID);
        }
        public int Them_XuLySuCo(XULYSUCO obj)
        {
            return objxulysuco.AddWithOutput(obj,"@IDXULYSUCO");
        }
        public int Sua_XuLySuCo(XULYSUCO obj)
        {
            return objxulysuco.Update(obj);
        }
        public int Delete_XuLySuCo(int ID)
        {
            return objxulysuco.Delete(ID);
        }
    }
}
