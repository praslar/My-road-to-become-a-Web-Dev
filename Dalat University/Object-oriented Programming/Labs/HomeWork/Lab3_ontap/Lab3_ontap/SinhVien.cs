using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ontap
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
            string s = "Mã Số: " + MaSo + "\n"
                + "Họ Tên: " + HoTen + "\n"
                + "Ngày Sinh: " + NgaySinh.ToShortDateString() + "\n"
                + "Địa chỉ: " + DiaChi + "\n"
                + "Lớp: " + Lop + "\n"
                + "Hình: " + Hinh ;
            string gt = "Nữ";
            if(GioiTinh)
                gt = "Nam";
            string cn = "";
            foreach (string a in ChuyenNganh)
                cn += a + ";";
            s += "\n" +"Giới tính: "+ gt + "\n" +"Chuyên ngành: " + cn;
            return s;
        }
    }
}
