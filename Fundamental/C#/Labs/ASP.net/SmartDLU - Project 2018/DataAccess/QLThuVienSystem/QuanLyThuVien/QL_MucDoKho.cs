using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.QLThuVienSystem.Methods;

namespace DataAccess
{
    public class QL_MucDoKho:MucDoKhoMethods
    {
        MucDoKhoMethods objMucDoKho = new MucDoKhoMethods();

            /// <summary>
            /// Lấy tất cả số lượng độ khó trong csdl
            /// </summary>
            /// <returns></returns>
        public List<MUCDOKHO> Get_DanhSach_MucDoKho()
        {
            return objMucDoKho.SelectAll();
        }

        /// <summary>
        /// Lấy số lượng độ khó Theo ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<MUCDOKHO> Get_DanhSach_By_ID(int ID)
        {
            return objMucDoKho.SelectByID(ID);
        }

        /// <summary>
        /// Thêm một "số lượng độ khó" (3 mức độ, 4 mức độ,...)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Them_MucDoKho(MUCDOKHO obj)
        {
            return objMucDoKho.Add(obj);
        }

        /// <summary>
        /// Sửa thông tin của số lượng độ khó
        /// <para/>VD:
        /// <para/>Tên mức độ khó: 3 mức độ khó
        /// <para/>Mô tả: có 3 mức độ khó là khó, dễ, trung bình 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Sua_MucDoKho(MUCDOKHO obj)//Suả Nhóm
        {
            return objMucDoKho.Update(obj);
        }

        /// <summary>
        /// Xoá một "số lượng độ khó"
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Delete_MucDoKho(int ID)//Xoa Nhóm
        {
            return objMucDoKho.Delete(ID);
        }
    }
}
