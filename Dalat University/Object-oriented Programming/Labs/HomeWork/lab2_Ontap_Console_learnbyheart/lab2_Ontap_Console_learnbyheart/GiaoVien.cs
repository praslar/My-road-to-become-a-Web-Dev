using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Ontap_Console_learnbyheart
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public DanhSachMonHoc DSMonHoc { get; set; }
        public DanhSachNgoaiNgu DSNgoaiNgu { get; set; }
        public string GioiTinh { get; set; }
        public string SoDT { get; set; }
        public string Mail { get; set; }
        public GiaoVien()
        {
            DSMonHoc = new DanhSachMonHoc();
            DSNgoaiNgu = new DanhSachNgoaiNgu();
        }
        public override string ToString()
        {
            string s = "Mã số: " + MaSo + "\n"
                     + "Họ tên: " + HoTen + "\n"
                     + "Ngày sinh: " + NgaySinh.ToString() + "\n"
                     + "Giới tính: " + GioiTinh + "\n"
                     + "Số ĐT: " + SoDT + "\n"
                     + "Mail: " + Mail + "\n";
            string ngoaingu = "Ngoại Ngữ: ";
            foreach (NgoaiNgu nn in DSNgoaiNgu.ds)
                ngoaingu += "\n" + "-"+ nn ;
            string monday = "Danh sách môn dạy: ";
            foreach (MonHoc mh in DSMonHoc.ds)
                monday += "\n" +"-"+ mh  ;
            s += ngoaingu + "\n" + monday;
            return s;
        }
    }
}
