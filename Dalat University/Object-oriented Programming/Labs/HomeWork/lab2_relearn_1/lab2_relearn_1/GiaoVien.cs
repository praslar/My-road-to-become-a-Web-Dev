using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_relearn_1
{
    public class GiaoVien
    {
        public string HoTen { get; set; }
        public string MaSo { get; set; }
        public string GioiTinh;
        public DateTime NgaySinh;
        public string SoDT;
        public string Mail;
        public string[] NgoaiNgu;
        public DanhSachMonHoc dsmh;
        public GiaoVien()
        {
            dsmh = new DanhSachMonHoc();
            NgoaiNgu = new string[10];
        }
        public override string ToString()
        {
            string s = "Thong tin giao vien";
            string nn = "Ngoai ngu: ";
            foreach (string item in NgoaiNgu)
            {
                nn += item + ";";
            }
            string monhoc = "Danh sach mon hoc: ";
            foreach (MonHoc mh in dsmh.dsmh)
                monhoc += mh + ";";
            s += nn + "\n" + monhoc;
            return s;
        }
    }
}
