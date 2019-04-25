using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess
{
    public class ThongTinTaiKhoan
    {
        public int ID { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string SoCMND { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        public int IDTaiKhoan { get; set; }

        public ThongTinTaiKhoan()
        {

        }
        public ThongTinTaiKhoan(int ID,string Ho,string Ten, string NgaySinh,bool GioiTinh,string SoCMND,string DiaChi,string HinhAnh ,int IDTaiKhoan)
        {
            this.ID = ID;
            this.Ho = Ho;
            this.Ten = Ten;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.SoCMND = SoCMND;
            this.DiaChi = DiaChi;
            this.HinhAnh = HinhAnh;
            this.IDTaiKhoan = IDTaiKhoan;
        }


    }
}
