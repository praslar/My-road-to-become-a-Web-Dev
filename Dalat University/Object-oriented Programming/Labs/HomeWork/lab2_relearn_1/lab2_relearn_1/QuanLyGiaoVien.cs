using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_relearn_1
{
    public class QuanLyGiaoVien
    {
        public delegate int SoSanh(object a, object b);
        public List<GiaoVien> dsgv;
        public QuanLyGiaoVien()
        {
            dsgv = new List<GiaoVien>();
        }
        public GiaoVien KiemTra(object a,SoSanh ss)
        {
            GiaoVien gvresult = null;
            foreach (GiaoVien item in dsgv)
            {
                if (ss(a,item)==0)
                {
                    gvresult = item;
                    break;
                }
            }
            return gvresult;
        }       
        public void Them(GiaoVien gv)
        {
            this.dsgv.Add(gv);   
        }
    }
}
