using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
namespace DataAccess
{
    public class ChuongHocMethods : BaseMethods<CHUONGHOC>
    {
        //Nhóm 3
        /// <summary>
        /// lấy chương học theo id của môn học đó
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CHUONGHOC> GetByIdMonHoc(int id)
        {
            return CBO.FillCollection<CHUONGHOC>(DataProvider.Instance.ExecuteReader(typeof(CHUONGHOC).Name + "_GetByIDMonHoc", id));
        }
    }
}
