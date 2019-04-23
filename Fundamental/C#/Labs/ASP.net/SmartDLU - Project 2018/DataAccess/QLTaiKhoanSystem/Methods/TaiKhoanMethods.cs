using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccess
{
    public class TaiKhoanMethods : BaseMethods<TaiKhoan>
    {
        public TaiKhoanMethods() { }
        public string Get_Mail_TaiKhoan(int ID)
        {
            string value = "";
            foreach (var row in SelectByID(ID))
            {
                value = row.Email;
            }
            return value;
        }
    }
}
