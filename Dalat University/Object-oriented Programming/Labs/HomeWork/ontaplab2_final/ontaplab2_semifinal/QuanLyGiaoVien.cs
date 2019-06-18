using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontaplab2_semifinal
{
    public class QuanLyGiaoVien
    {
        public delegate int SoSanh(object a, object b);
        public List<TTGV> dsgiaovien;
        public QuanLyGiaoVien()
        {
            dsgiaovien = new List<TTGV>();
        }
        public TTGV this[int index]
        {
            get { return dsgiaovien[index] as TTGV; }
            set { dsgiaovien[index] = value; }
        }
        public void Add(TTGV gv)
        {
            dsgiaovien.Add(gv);
        }
        public TTGV KiemTra(object obj1,SoSanh ss)
        {
            TTGV gvresult = null;
            foreach(TTGV gv in dsgiaovien)
            {
                if(ss(obj1,gv)==0)
                {
                    gvresult = gv;
                    break;
                }
            }
            return gvresult;
        }
        public bool KiemTraRong()
        {
            if (dsgiaovien.Count == 0)
                return true;
            return false;
        }
        public bool Xoa(string MS)
        {
            int sogiaovien = dsgiaovien.Count;
            for (int i = 0; i < dsgiaovien.Count; i++)
            {
                if (MS.CompareTo(dsgiaovien[i].Maso)==0)
                {
                    dsgiaovien.RemoveAt(i);
                    break;
                }
            }
            if (dsgiaovien.Count == sogiaovien)
            {
                return false;
            }
            return true;
        }
    }
}
