using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_relearn_abc
{
    public class QuanLySinhVien
    {
        public delegate int SoSanh(object obj1, object obj2);
        public List<SinhVien> dssv;
        public QuanLySinhVien()
        {
            dssv = new List<SinhVien>();
        }
        public SinhVien this[int index]
        {
            get { return dssv[index]; }
            set { dssv[index] = value; }
        }
        public void Them(SinhVien sv)
        {
            this.dssv.Add(sv);
        }
        public SinhVien Tim(object obj1,SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in dssv)
            {
                if (ss(obj1,sv)==0)
                {
                    svresult = sv;
                    break;
                }
            }
            return svresult;
        }
        public void Xoa(object obj1, SoSanh ss)
        {
            for (int i = 0; i < this.dssv.Count; i++)
            {
                if (ss(obj1, this[i]) == 0)
                {
                    dssv.RemoveAt(i);
                    break;
                }
            }
        }
        public bool Sua(SinhVien svsua,object obj1,SoSanh ss)
        {
            bool kq = false;
            for (int i = 0; i < this.dssv.Count; i++)
            {
                if (ss(obj1,this[i])==0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }
        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i < this.dssv.Count-1; i++)
                for (int j = i+1; j < this.dssv.Count; j++)
                {
                    if (ss(this[i],this[j])>0)
                    {
                        SinhVien sv = this[i];
                        this[i] = this[j];
                        this[j] = sv;
                    }
                }
        }
        public void ReadFile()
        {
            string filename = "DanhSachSV.txt";
            string t;
            string[] s;
            StreamReader sr = new StreamReader(new FileStream(filename,FileMode.Open));
            while((t=sr.ReadLine())!=null)
            {
                s = t.Split('*');
                SinhVien sv = new SinhVien();
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
                foreach (string chuyennganh in cn)
                    sv.ChuyenNganh.Add(chuyennganh);
                this.Them(sv);
            }
        }
        public bool KiemTraRong()
        {
            if (this.dssv.Count == 0)
                return true;
            return false;
        }
    }
}
