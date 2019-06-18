using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string soDT;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maso, string hoten, DateTime NgaySinh,
        DanhMucMonHoc ds, string gt, string[] nn, string sdt, string mail)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = NgaySinh;
            this.dsMonHoc = ds;
            this.GioiTinh = gt;
            this.NgoaiNgu = nn;
            this.soDT = sdt;
            this.Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã số:" + MaSo + "\n" + "Họ tên:" + HoTen + "\n"
                + "Ngày Sinh:" + NgaySinh.ToString() + "\n"     
                + "Giới tính:" + GioiTinh + "\n"
                + "Số ĐT:" + soDT + "\n"
                + "Mail:" + Mail + "\n";
            string sngoaingu = "Ngoại ngữ:";
            foreach (string t in NgoaiNgu)
                sngoaingu += t + ";";
            string Monday = "Danh sách môn dạy:";
            foreach (MonHoc mh in dsMonHoc.ds)
                Monday += mh + ";";
            s += "\n" + sngoaingu + "\n" + Monday;
            return s;
        }
    }
}
