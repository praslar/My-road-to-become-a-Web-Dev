using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{ 
    public class ThiThuMethods
    {
        BaseMethods<THITHU> objthithu = new BaseMethods<THITHU>();
        
        public List<THITHU> SelectAll()
        {
            return objthithu.SelectAll();
        }

        public List<THITHU> Get_DanhSach_By_ID(int ID)
        {
            return objthithu.SelectByID(ID);
        }

        public int Them_ThiThu(THITHU obj)
        { 
            return objthithu.AddWithOutput(obj,"@IDTHITHU");
        }
        public int Sua_ThiThu(THITHU obj)
        {
            return objthithu.Update(obj);
        }
        public int Delete_ThiThu(int ID)
        {
            return objthithu.Delete(ID);
        }
    }
}
