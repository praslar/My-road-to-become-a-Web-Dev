using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Relearn_abcxyz
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }
        public bool GioiTinh { get; set; }
        public List<string> ChuyenMon { get; set; }
        public NhanVien()
        {
            ChuyenMon = new List<string>();
        }
        public override string ToString()
        {
            string s = "Mã số: " + MaNhanVien + "\n"
                + "Họ tên: " + HoTen + "\n"
                + "Ngày sinh: " + NgaySinh + "\n"
                + "Địa chỉ: " + DiaChi + "\n"
                + "Giới tính: ";
            string gt = "Nữ";
            if (GioiTinh)
                gt = "Nam";
            string cn = "";
            foreach (string chuyennganh in ChuyenMon)
            {
                cn += chuyennganh + ";";
            }
            if (cn.Length > 0)
            {
                cn = cn.Substring(0, cn.Length - 1);
            }
            s += gt + "\n" + "Chuyên Môn: " + cn;
            return s;
        }
    }
}
