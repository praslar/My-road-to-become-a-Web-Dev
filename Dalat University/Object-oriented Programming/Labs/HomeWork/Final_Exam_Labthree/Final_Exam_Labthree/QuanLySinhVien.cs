using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Labthree
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
        public void Xoa(object obj,SoSanh ss)
        {
            for (int i = this.dssv.Count; i >= 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                    this.dssv.RemoveAt(i);
            }
        }
    }
}
