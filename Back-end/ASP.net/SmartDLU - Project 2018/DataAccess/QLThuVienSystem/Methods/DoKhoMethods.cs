using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
namespace DataAccess.QLThuVienSystem.Methods
{
    public class DoKhoMethods:BaseMethods<DOKHO>
    {
        //Nhóm 3
        /// <summary>
        /// Lấy độ khó theo id của môn học truyền vào
        /// </summary>
        /// <param name="idMonHoc"></param>
        /// <returns></returns>
        public List<DOKHO> GetByIdMonHoc(int idMonHoc)
        {
            return CBO.FillCollection<DOKHO>(DataProvider.Instance.ExecuteReader(typeof(DOKHO).Name + "_GetByIdMonHoc", idMonHoc));
        }

        /// <summary>
        /// lấy một độ khó trong số mức độ khó
        /// </summary>
        /// <param name="idMucDoKho"></param>
        /// <returns></returns>
        public List<DOKHO> GetByIdMucDoKho(int idMucDoKho)
        {
            return CBO.FillCollection<DOKHO>(DataProvider.Instance.ExecuteReader(typeof(DOKHO).Name + "_GetByIdMucDoKho", idMucDoKho));
        }

        /// <summary>
        /// lấy một độ khó trong số mức độ khó
        /// </summary>
        /// <param name="idMucDoKho"></param>
        /// <returns></returns>
        public List<DOKHO> GetById_MucDoKho(int idMucDoKho)
        {
            return CBO.FillCollection<DOKHO>(DataProvider.Instance.ExecuteReader(typeof(DOKHO).Name + "_GetById_MucDoKho", idMucDoKho));
        }
    }
}
