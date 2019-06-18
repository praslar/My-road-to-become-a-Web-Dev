using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relearn_lab2_abcxyz
{
    public class QuanLyGiaoVien
    {
        public delegate int SoSanh(object obj1, object obj2);
        public List<GiaoVien> dsgv;
        public QuanLyGiaoVien()
        {
            dsgv = new List<GiaoVien>();
        }
        public void Add(GiaoVien gv)
        {
            dsgv.Add(gv);
        }
        public bool KiemTraRong()
        {
            if (dsgv.Count == 0)
                return true;
            return false;
        }
        public bool Xoa(string ms)
        {
            int sogiaovien = dsgv.Count;
            for (int i = 0; i < sogiaovien; i++)
            {
                if (ms.CompareTo(dsgv[i].MaSo)==0)
                {
                    dsgv.RemoveAt(i);
                    break;
                }
            }
            if (sogiaovien == dsgv.Count)
            {
                return false;
            }
            return true;
        }
        public GiaoVien KiemTra(object obj1,SoSanh ss)
        {
            GiaoVien gvresult = null;
            foreach (GiaoVien gv in dsgv)
            {
                if (ss(obj1,gv)==0)
                {
                    gvresult = gv;
                    break;
                }
            }
            return gvresult;
        }
    }
}
