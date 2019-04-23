using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccess;
namespace DataAccess
{
    public class DeThiMethods:BaseFunctions<DETHI>
    {
        public List<DETHI> getDeThiByIDBODE(int idBoDe)
        {
            return CBO.FillCollection<DETHI>(DataProvider.Instance.ExecuteReader(typeof(DETHI).Name + "_GetByIDBODE", idBoDe));
        }
        public object InsertDeThiOutput(DETHI dt)
        {
            return DataProvider.Instance.ExecuteScalar(typeof(DETHI).Name + "_InsertOutput", GetInsertUpdateValues(dt).ToArray());
        }
    }
}
