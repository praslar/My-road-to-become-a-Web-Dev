using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_exam_lab2._2
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public string GioiTinh;
        public string SoDT;
        public string Mail;
        public string[] NgoaiNgu;
        public DanhSachMonHoc dsmh;
        public GiaoVien()
        {
            this.dsmh = new DanhSachMonHoc();
            NgoaiNgu = new string[10];
        }

        public override string ToString()
        {
            string s = " Mã số: " + MaSo + "\n" + " Họ tên: " + HoTen + "\n"
            + " Ngày Sinh: " + NgaySinh.ToString() + "\n"
            + " Giới tính: " + GioiTinh + "\n"
            + " Số ĐT: " + SoDT + "\n"
            + " Mail: " + Mail + "\n";
            string sngoaingu = " Ngoại ngữ: ";
            foreach (string t in NgoaiNgu)
                sngoaingu += t + ";";
            string Monday = " Danh sách môn dạy: ";
            foreach (MonHoc mh in dsmh.dsmh)
                Monday += mh + ";";
            s += "\n" + sngoaingu + "\n" + Monday;
            return s;
        }       
    }
}
