using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Relearn
{
    public class QuanLySinhVien
    {
        public delegate int SoSanh(object obj1, object obj2);
        public List<SinhVien> dssv;
        public QuanLySinhVien()
        {
            dssv = new List<SinhVien>();
        }
        public void Them(SinhVien sv)
        {
            this.dssv.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return dssv[index]; }
            set { dssv[index] = value; }
        }
        public void Xoa(object obj1, SoSanh ss)
        {
            int i = dssv.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj1, this[i]) == 0)
                    this.dssv.RemoveAt(i);
        }
        public void ReadFile()
        {
            string filename = "DanhSachSV.txt";
            string t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
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
        public SinhVien KiemTra(object obj1, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in dssv)
            {
                if (ss(obj1, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            }
            return svresult;
        }
        public bool Sua(SinhVien svsua, object obj1, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.dssv.Count;
            for (i = 0; i < count; i++)
                if (ss(obj1, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            return kq;
        }

    }
}
