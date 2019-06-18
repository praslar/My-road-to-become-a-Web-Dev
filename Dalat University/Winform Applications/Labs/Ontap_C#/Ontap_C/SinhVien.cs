using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap_C
{
    class SinhVien
    {
        //private string maso;

        ////MaSo
        //public string MaSo
        //{
        //    get
        //    { return this.maso; }
        //    set
        //    { this.maso = value; }
        //}
        public string MaSo { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string Hinh { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public DateTime NgaySinh { get; set; }
        public List<string> ChuyenNganh { get; set; }


        public SinhVien()
        {
            ChuyenNganh = new List<string>();
        }
        public SinhVien(string MaSo, string DiaChi, bool GioiTinh,
            string Hinh, string HoTen, string Lop, DateTime NgaySinh,
            List<string> ChuyenNganh)
        {
            this.MaSo = MaSo;
            this.DiaChi = DiaChi;
            this.GioiTinh = GioiTinh;
            this.Hinh = Hinh;
            this.HoTen = HoTen;
            this.Lop = Lop;
            this.NgaySinh = NgaySinh;
            this.ChuyenNganh = ChuyenNganh;
        }
    }
}
