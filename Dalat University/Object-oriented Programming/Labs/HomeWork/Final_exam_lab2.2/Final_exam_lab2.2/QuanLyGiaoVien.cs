using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_exam_lab2._2
{
    public class QuanLyGiaoVien
    {
        public delegate int SoSanh(object obj1, object obj2);
        public enum KieuTim
        {
            TheoMaSo,
            TheoTen,
            TheoSDT
        }
        public List<GiaoVien> dsgv;
        public QuanLyGiaoVien()
        {
             dsgv = new List<GiaoVien>();
        }
        public void Them(GiaoVien gv)
        {
            dsgv.Add(gv);
        }
        public GiaoVien KiemTra(object a,SoSanh ss)
        {
            GiaoVien gvresult = null;
            foreach (GiaoVien gv in dsgv)
            {
                if (ss(a,gv)==0)
                {
                    gvresult = gv;
                    break;
                }
            }
            return gvresult;
        }
        public bool KiemTraRong()
        {
            if (dsgv.Count == 0)
                return true;
            return false;
        }
        public bool Xoa(string ms)
        {
            int gv = dsgv.Count;
            for (int i = 0; i < dsgv.Count; i++)
            {
                if (dsgv[i].MaSo.CompareTo(ms)==0)
                {
                    dsgv.RemoveAt(i);
                    break;
                }
            }
            if (gv.CompareTo(dsgv.Count) == 0)
                return false;
            return true;
        }
    }
}
