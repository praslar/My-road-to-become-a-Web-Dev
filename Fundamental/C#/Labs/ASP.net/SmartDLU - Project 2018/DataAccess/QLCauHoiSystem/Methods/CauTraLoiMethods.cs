using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccess
{
    public class CauTraLoiMethods:BaseMethods<CAUTRALOI>
    {
        //Nhóm 3
        public List<CAUTRALOI> GetByIdCauHoi(int idCauHoi)
        {
            return CBO.FillCollection<CAUTRALOI>(DataProvider.Instance.ExecuteReader(typeof(CAUTRALOI).Name + "_GetByIdCauHoi", idCauHoi));
        }
        public List<CAUTRALOI> GetByIdDeThi(int idDeThi)
        {
            return CBO.FillCollection<CAUTRALOI>(DataProvider.Instance.ExecuteReader(typeof(CAUTRALOI).Name + "_GetByIdDeThi", idDeThi));
        }
        public List<CAUTRALOI> GetByIdCauHoiDeThi(int id)
        {
            return CBO.FillCollection<CAUTRALOI>(DataProvider.Instance.ExecuteReader(typeof(CAUTRALOI).Name + "_GetByIDCauHoiDeThi", id));
        }
        //End
    }
}
