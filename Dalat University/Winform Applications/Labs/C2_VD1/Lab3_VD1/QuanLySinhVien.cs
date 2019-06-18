using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Lab3_VD1
{
    public delegate int SoSanh(object obj1, object obj2);
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();

        }
        public int Count
        {
            get { return DanhSach.Count; }
        }
        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
        }
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }
        public void DocTuFile()
        {
            string filename = "DanhSachSV.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(
                new FileStream(filename, FileMode.Open));
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
        public void SapXep(SoSanh ss)
        { 
            int i,j, count;            
            count = this.DanhSach.Count;
            for (i = 0; i < count-1; i++)
                for(j=i+1; j<count; j++)
                    if (ss(this[i], this[j]) > 0)
                    {
                        SinhVien sv = this[i];
                        this[i] = this[j];
                        this[j] = sv;
                    }
        }
      

    }
}
