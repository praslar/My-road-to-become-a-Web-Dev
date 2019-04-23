using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class KetQuaThiThuMethods
    {
        BaseMethods<KETQUATHITHU> objKetqua = new BaseMethods<KETQUATHITHU>();

        public List<KETQUATHITHU> SelectAll()
        {
            return objKetqua.SelectAll();
        }
        public List<KETQUATHITHU> Get_DanhSach_By_ID(int ID)
        {
            return objKetqua.SelectByID(ID);
        }
        public int Them_KetQuaThiThu(KETQUATHITHU obj)
        {
            return objKetqua.Add(obj);
        }
        public int Sua_KetQuaThiThu(KETQUATHITHU obj)
        {
            return objKetqua.Update(obj);
        }
        public int Delete_KetQuaThiThu(int ID)
        {
            return objKetqua.Delete(ID);
        }
    }
}

