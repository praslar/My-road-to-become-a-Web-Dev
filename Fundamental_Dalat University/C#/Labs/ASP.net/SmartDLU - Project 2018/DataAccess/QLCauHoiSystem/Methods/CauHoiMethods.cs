using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccess
{
    public class CauHoiMethods:BaseMethods<CAUHOI>
    {
        //Nhóm 3
        public List<CAUHOI> GetByIdDeThi(int idDeThi)
        {
            return CBO.FillCollection<CAUHOI>(DataProvider.Instance.ExecuteReader(typeof(CAUHOI).Name + "_GetByIdDeThi", idDeThi));
        }
        public List<CAUHOI> GetByIdBoDe(int idBoDe)
        {
            return CBO.FillCollection<CAUHOI>(DataProvider.Instance.ExecuteReader(typeof(CAUHOI).Name + "_GetByIdBoDe", idBoDe));
        }
        public List<CAUHOI> GetByIdMonHoc(int idMonHoc)
        {
            return CBO.FillCollection<CAUHOI>(DataProvider.Instance.ExecuteReader(typeof(CAUHOI).Name + "_GetByIdMonHoc", idMonHoc));
        }
        public List<CAUHOI> GetByIdChuongHoc(int idChuongHoc)
        {
            return CBO.FillCollection<CAUHOI>(DataProvider.Instance.ExecuteReader(typeof(CAUHOI).Name + "_GetByIdChuongHoc", idChuongHoc));
        }
        public List<CAUHOI> GetByNameDoKho_IdMonHoc(string tenDoKho, int idMonHoc)
        {
            return CBO.FillCollection<CAUHOI>(DataProvider.Instance.ExecuteReader(typeof(CAUHOI).Name + "_GetByNameDoKho", tenDoKho, idMonHoc));
        }
        //End Nhóm 3
    }
}
