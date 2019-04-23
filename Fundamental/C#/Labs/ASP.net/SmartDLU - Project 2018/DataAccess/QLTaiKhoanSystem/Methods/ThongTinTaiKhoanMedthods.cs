using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public  class ThongTinTaiKhoanMedthods : BaseMethods<ThongTinTaiKhoan>
    {
        public ThongTinTaiKhoanMedthods() { }
        public string Get_HoTen_TK(int IDTK)
        {
            string HoTen = "";
            foreach (var row in SelectBy(IDTK, "IDTaiKhoan"))
            {
                HoTen = row.Ho+ " "+row.Ten;
            }
            return HoTen;
        }
    }
}
