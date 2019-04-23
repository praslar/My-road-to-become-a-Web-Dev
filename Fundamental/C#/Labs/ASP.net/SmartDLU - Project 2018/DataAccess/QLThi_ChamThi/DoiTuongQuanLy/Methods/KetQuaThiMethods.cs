using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
public	class KetQuaThiMethods
	{
		BaseMethods <KETQUATHI> objKetqua = new BaseMethods<KETQUATHI>();

		public List<KETQUATHI> SelectAll()
		{
			return objKetqua.SelectAll();
		}
        public List<KETQUATHI> Get_DanhSach_By_ID(int IDDIEMTHI,int IDMADE)
        {
            return objKetqua.SelectByNID(IDDIEMTHI,IDMADE);
        }
        public int Them_KetQuaThi(KETQUATHI obj)
        {
            return objKetqua.Add(obj);
        }
        public int Sua_KetQuaThi(KETQUATHI obj)
        {
            return objKetqua.Update(obj);
        }
        public int Delete_KetQuaThi(int ID)
        {
            return objKetqua.Delete(ID);
        }
    }
}
