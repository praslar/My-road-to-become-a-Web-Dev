using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccess;
namespace DataAccess
{
    public class CauHoi_DeThiMethods:BaseFunctions<CAUHOI_DETHI>
    {
        public int InsertWithOutput(CAUHOI_DETHI cd)
        {
            return int.Parse(DataProvider.Instance.ExecuteScalar(typeof(CAUHOI_DETHI).Name + "_InsertOutput",GetInsertUpdateValues(cd).ToArray()).ToString());
        }
        public int DeleteByIdDeThi(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery(typeof(CAUHOI_DETHI).Name + "_DeleteByIdDeThi", id);
        }
        public List<CAUHOI_DETHI> GetByIdDeThi(int idDeThi)
        {
            return CBO.FillCollection<CAUHOI_DETHI>(DataProvider.Instance.ExecuteReader(typeof(CAUHOI_DETHI).Name + "_GetByIDDeThi",idDeThi));
        }
        public List<CAUHOI_DETHI> GetByIdCauHoiBoDe(int idCauHoiBoDe)
        {
            return CBO.FillCollection<CAUHOI_DETHI>(DataProvider.Instance.ExecuteReader(typeof(CAUHOI_DETHI).Name + "_GetByIDCauHoiBoDe", idCauHoiBoDe));
        }
    }
}
