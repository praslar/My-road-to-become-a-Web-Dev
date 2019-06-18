using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_relearn_abc
{
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }
        public bool GioiTinh { get; set; }
        public List<string> ChuyenNganh { get; set; }
        public SinhVien()
        {
            ChuyenNganh = new List<string>();
        }
        public override string ToString()
        {
            string s= "Mã số: " + MaSo + "\n"
                + "Họ tên: " + HoTen + "\n"
                + "Ngày Sinh: " + NgaySinh + "\n"
                + "Địa Chỉ: " + DiaChi+ "\n"
                + "Lớp: " + Lop + "\n"
                + "Giới tính: ";
            string gt = "Nữ";
            if (GioiTinh)
                gt = "Nam";
            string cn = "Chuyên Ngành: ";
            foreach (string chuyennganh in ChuyenNganh)
                cn += chuyennganh + ";";
            s += gt + "\n" + cn;
            return s;
        }
    }
}
