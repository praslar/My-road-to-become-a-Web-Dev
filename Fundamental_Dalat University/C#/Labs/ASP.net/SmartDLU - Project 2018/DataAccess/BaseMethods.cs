using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using System.Reflection;

namespace DataAccess
{
    public class BaseMethods<T> where T : class, new()
    {
        private string GetTypeT()
        {
            return typeof(T).Name;
        }

        /// <summary>
        /// Hàm l?y danh sách các giá tr? các thu?c tính c?a m?t ??i t??ng
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private List<object> GetInsertUpdateValues(T item)
        {
            //Lây danh sách các thu?c tính c?a m?t ?t
            object[] props = item.GetType().GetProperties();

            //Danh sách giá tr? các thu?c tính
            List<object> objvalue = new List<object>();

            //Duy?t danh sách các thu?c tính
            foreach (PropertyInfo prop in props)
            {
                //L?y giá tr? c?a m?t thu?c tính và add và danh sách giá tr? các thu?c tính
                objvalue.Add(prop.GetValue(item, null));
            }

            return objvalue;
        }

        public List<T> SelectAll()
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_GetAll"));
        }

        public List<T> SelectPage(object From, object To)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_SelectPage", From, To));
        }

        public int Add(T obj)
        {
            return DataProvider.Instance.ExecuteNonQuery(this.GetTypeT() + "_Insert", this.GetInsertUpdateValues(obj).ToArray());
        }
        
        public int Update(T obj)
        {

            return DataProvider.Instance.ExecuteNonQuery(this.GetTypeT() + "_Update", this.GetInsertUpdateValues(obj).ToArray());
        }

        public int Delete(object ID)
        {

            return DataProvider.Instance.ExecuteNonQuery(this.GetTypeT() + "_Delete", ID);
        }

        public List<T> SelectBy(object item, string Name)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_GetBy_" + Name, item));
        }

        public List<T> SelectByID(object ID)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_GetByID", ID));
        }
        public List<T> SelectByNID(int ID1,int ID2)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_GetByID", ID1,ID2));
        }

        public List<T> FindKeyWord(object item)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_FindKeyWord", item));
        }


        //----------------------------------------Phan Phat Trien Them Ham của nhóm 9 --------------------------------------//
        public List<T> DangNhap(string ten, string matkhau)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_Login", ten, matkhau));
        }
        public List<T> TaiKhoanLichThi(int IDLop,int IDLichThi)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_TaiKhoanLichThi", IDLop, IDLichThi));
        }
        public int DeleteBy(object ID, string name)
        {
            return DataProvider.Instance.ExecuteNonQuery(this.GetTypeT() + "_DeleteBy_" + name, ID);
        }
        public int UpdatePassword(int ID,string MatKhauMoi)
        {
            return DataProvider.Instance.ExecuteNonQuery(this.GetTypeT() + "_UpdatePassword", ID ,MatKhauMoi);
        }
        public List<T> Check_PassWord(string MatKhauCu ,string Email)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_CheckPassWord", MatKhauCu, Email));
        }

        //--------------------------Them tra ve ID---------------------------
        public int AddWithOutput(T obj, string S)
        {
			return Convert.ToInt32(DataProvider.Instance.ExecuteNonQueryWithOutput(S, this.GetTypeT() + "_Insert", this.GetInsertUpdateValues(obj).ToArray()));
			

		}

        public DataTable SelectTables(string SPName, params object[] parameterValues)
        {
            return null;
        }

    }
}
