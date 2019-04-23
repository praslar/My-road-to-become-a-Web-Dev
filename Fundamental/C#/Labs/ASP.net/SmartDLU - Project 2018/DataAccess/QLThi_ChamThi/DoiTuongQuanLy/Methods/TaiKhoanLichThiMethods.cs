using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
namespace DataAccess
{
    public class TaiKhoanLichThiMethods
    {
        BaseMethods<TAIKHOANLICHTHI> objTaiKhoanLichThi = new BaseMethods<TAIKHOANLICHTHI>();
        /*===== Hiển thị điểm thi ====== */

        public List<TAIKHOANLICHTHI> SelectAll()
        {
            return objTaiKhoanLichThi.SelectAll();
        }

        public List<TAIKHOANLICHTHI> Get_DanhSach_By_ID(int ID)
        {
            return objTaiKhoanLichThi.SelectByID(ID);
        }

        public List<TAIKHOANLICHTHI> Get_DanhSach_By_IDTaiKhoan(int ID)
        {
            return CBO.FillCollection<TAIKHOANLICHTHI>(DataProvider.Instance.ExecuteReader(typeof(TAIKHOANLICHTHI).Name + "_GetBy_IDTaiKhoan", ID));
        }
        public List<TAIKHOANLICHTHI> Get_DanhSach_By_IDLichThi(int ID)
        {
            return CBO.FillCollection<TAIKHOANLICHTHI>(DataProvider.Instance.ExecuteReader(typeof(TAIKHOANLICHTHI).Name + "_GetBy_IDLichThi", ID));
        }
        public int Them_TaiKhoanLichThi(TAIKHOANLICHTHI obj)
        {
            return objTaiKhoanLichThi.Add(obj);
        }
        public int Sua_TaiKhoanLichThi(TAIKHOANLICHTHI obj)
        {
            return objTaiKhoanLichThi.Update(obj);
        }
        public int Delete_TaiKhoanLichThi(int ID)
        {
            return objTaiKhoanLichThi.Delete(ID);
        }
    }
}
