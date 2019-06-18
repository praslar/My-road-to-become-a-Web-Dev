using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Relearn_abcxyz
{
    public class QuanLySinhVien
    {
        public delegate int SoSanh(object obj1, object obj2);
        public List<NhanVien> dssv;
        public QuanLySinhVien()
        {
            dssv = new List<NhanVien>();
        }
        public void Them(NhanVien sv)
        {
            this.dssv.Add(sv);
        }
        public NhanVien this[int index]
        {
            get { return dssv[index]; }
            set { dssv[index] = value; }
        }
        public NhanVien Tim(object obj1, SoSanh ss)
        {
            NhanVien svresult = null;
            foreach (NhanVien sv in dssv)
                if (ss(obj1, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }
        public void ReadFile()
        {
            string filename = "DanhSachSV.txt";
            string t;
            string[] s;
            NhanVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new NhanVien();
                sv.MaNhanVien = s[0];
                sv.HoTen = s[1];
                sv.NgaySinh = DateTime.Parse(s[2]);
                sv.DiaChi = s[3];
                sv.EventManager = s[4];
                sv.Hinh = s[5];
                sv.GioiTinh = false;
                if (s[6] == "1")
                    sv.GioiTinh = true;               
                string[] cn = s[7].Split(',');
                foreach (string item in cn)
                {
                    sv.ChuyenMon.Add(item);
                }
                this.Them(sv);
            }
        }
        public void Xoa(object obj1, SoSanh ss)
        {
            int i = this.dssv.Count-1;
            for (; i >= 0; i--)
                if (ss(obj1, this[i]) == 0)
                    this.dssv.RemoveAt(i);
        }
        public bool Sua(NhanVien svsua, object obj1, SoSanh ss)
        {
            int i, count = this.dssv.Count ;
            bool kq = false;
            for (i = 0; i < count; i++)
                if (ss(obj1,this[i])==0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            return kq;
        }
        public bool KiemTraRong()
        {
            if (dssv.Count == 0)
                return true;
            return false;
        }
        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i < dssv.Count-1; i++)
                for (int j = i; j < dssv.Count; j++)
                    if (ss(this[i],this[j])>0)
                    {
                        NhanVien sv = this[i];
                        this[i] = this[j];
                        this[j] = sv;
                    }
        }
    }
}
