using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccess;
namespace DataAccess
{
    public class CauTraLoiCuaCauHoiDeThiMethods:BaseFunctions<CAUTRALOICUACAUHOIDETHI>
    {
        public int DeleteByIdCauHoiDeThi(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery(typeof(CAUTRALOICUACAUHOIDETHI).Name + "_DeleteByIdCauHoiDeThi", id);
        }
    }
}
