using Core;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BoDeMethods: BaseFunctions<BODE>
    {
        public List<BODE> GetByIDMonHoc(int id)
        {
            return CBO.FillCollection<BODE>(DataProvider.Instance.ExecuteReader(typeof(BODE).Name+ "_GetByIDMonHoc",id));
        }
        public int InsertWithOutput(BODE bode)
        {
            return int.Parse(DataProvider.Instance.ExecuteScalar(typeof(BODE).Name + "_InsertOutput", GetInsertUpdateValues(bode).ToArray()).ToString());
        }
    }
}
