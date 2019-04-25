using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccess;
namespace DataAccess
{
    public class CauHoi_BoDeMethods:BaseFunctions<CAUHOI_BODE>
    {
        public List<CAUHOI_BODE> GetByIdBoDe(int idBoDe)
        {
            return CBO.FillCollection<CAUHOI_BODE>(DataProvider.Instance.ExecuteReader(typeof(CAUHOI_BODE).Name + "_GetByIdBoDe", idBoDe));
        }
        public List<CAUHOI_BODE> GetByIdBoDeAndIdCauHoi(int idBoDe,int idCauHoi)
        {
            return CBO.FillCollection<CAUHOI_BODE>(DataProvider.Instance.ExecuteReader(typeof(CAUHOI_BODE).Name + "_GetByIdBoDeAndIdCauHoi", idBoDe,idCauHoi));
        }
    }
}
