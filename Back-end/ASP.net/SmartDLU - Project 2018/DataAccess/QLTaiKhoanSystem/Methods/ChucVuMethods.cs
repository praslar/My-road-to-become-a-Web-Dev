using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ChucVuMethods : BaseMethods<ChucVu>
    {
        public ChucVuMethods() { }
        public string Get_By_MaCV(string MaCV)
        {
            return SelectBy(MaCV, "MaCV")[0].TenCV;
        }
    }
}
