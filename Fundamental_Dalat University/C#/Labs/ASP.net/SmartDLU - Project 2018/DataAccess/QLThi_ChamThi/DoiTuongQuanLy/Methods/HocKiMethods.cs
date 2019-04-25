using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
public	class HocKiMethods:BaseMethods<HOCKI>
	{
		BaseMethods<HOCKI> ObjHocKi = new BaseMethods<HOCKI>();

		public List<HOCKI> SelectAll()
		{
			return ObjHocKi.SelectAll();
		}

		public List<HOCKI> Get_DanhSach_By_ID(int ID)
        {
            return ObjHocKi.SelectByID(ID);
        }
        public int Them_HocKi(HOCKI obj)
        {
            return ObjHocKi.Add(obj);
        }
        public int Sua_HocKi(HOCKI obj)
        {
            return ObjHocKi.Update(obj);
        }
        public int Delete_HocKi(int ID)
        {
            return ObjHocKi.Delete(ID);
        }
    }
}
