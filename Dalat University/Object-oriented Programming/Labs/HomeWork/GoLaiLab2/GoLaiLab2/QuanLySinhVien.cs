using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoLaiLab2
{
    
    class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }
        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }
        public void DocTuFile()
        {
            string  filename="DanhSachSV.txt",test;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while ((test=sr.ReadLine())!=null)
            {
                s = test.Split('*');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                sv.NgaySinh = DateTime.Parse(s[2]);
                sv.DiaChi = s[3];
                sv.Lop = s[4];
                sv.Hinh = s[5];
                sv.GioiTinh = false;
                if (s[6] == "1")
                    sv.GioiTinh = true;
                string[] cn = s[7].Split(',');
                foreach (string c in cn)
                    sv.ChuyenNganh.Add(c);
                this.Them(sv);
            }

        }
    }
}
