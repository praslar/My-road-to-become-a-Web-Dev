using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Ontap
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public DanhMucNgoaiNgu dsNgoaiNgu;
        public string GioiTinh;
        //public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien()
        {
            DanhMucMonHoc dsMonHoc = new DanhMucMonHoc();
            DanhMucNgoaiNgu dsNgoaiNgu = new DanhMucNgoaiNgu();
        }
        public GiaoVien(string maso,string hoten,DateTime ns,
            DanhMucMonHoc mh,string gt,DanhMucNgoaiNgu nn, string dt,string mail)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ns;
            this.dsMonHoc = mh;
            this.GioiTinh = gt;
            this.dsNgoaiNgu = nn;
            this.SoDT = dt;
            this.Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã số: " + MaSo + "\n"
                + "Họ tên: " + HoTen + "\n"
                + "Ngày Sinh: " + NgaySinh.ToString() + "\n"
                + "Giới Tính: " + GioiTinh + "\n"
                + "Số ĐT: " + SoDT + "\n"
                + "Mail: " + Mail + "\n";
            string sngoaingu = "Ngoại Ngữ: ";
            foreach (NgoaiNgu nn in dsNgoaiNgu.dsnn)
                sngoaingu += "\n" + "-" +  nn + ";";
            string monday = "Danh sách môn dạy: ";
            foreach (MonHoc mh in dsMonHoc.ds)
                monday += "\n" + "-" + mh + ";" ;
            s += "\n" + sngoaingu + "\n" + monday;
            return s;
        }
    }
}
 