using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Ontap_Console_learnbyheart
{
    public class QuanLyGiaoVien
    {
        public enum KieuTim
        {
            MaSo,
            HoTen,
            SoSDT
        }
        public delegate int SoSanh(object a, object b); 
        public List<GiaoVien> DSGiaoVien;
        public QuanLyGiaoVien()
        {
            DSGiaoVien = new List<GiaoVien>();
        }
        public void Them(GiaoVien gv)
        {
            this.DSGiaoVien.Add(gv);
        }
        public GiaoVien KiemTra(object obj1,SoSanh ss)
        {
            GiaoVien gvresult = null;
            foreach(GiaoVien gv in DSGiaoVien)
            {
                if (ss(obj1,gv)==0)
                {
                    gvresult = gv;
                    break;
                }
            }
            return gvresult;
        }
        public bool Xoa(string MS)
        {
            int sogiaovien = DSGiaoVien.Count;
            for (int i = 0; i < DSGiaoVien.Count; i++)
            {
                if (MS.CompareTo(DSGiaoVien[i].MaSo)==0)
                {
                    DSGiaoVien.RemoveAt(i);
                    break;
                }
            }
            if (DSGiaoVien.Count == sogiaovien)
            {
                return false;
            }
            return true;
        }
        public bool KiemTraRong()
        {
            if (DSGiaoVien.Count==0)
                return true;
            return false;
        }
    }
}
