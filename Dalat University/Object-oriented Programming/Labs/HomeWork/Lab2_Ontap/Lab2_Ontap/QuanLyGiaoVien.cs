using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Ontap
{
    
    public class QuanLyGiaoVien
    {
        public delegate int SoSanh(object a, object b);
        enum KieuTim
        {
            TheoMa,
            TheoHoTen,
            TheoSDT
        };
        public List<GiaoVien> dsGiaoVien;
        public QuanLyGiaoVien()
        {
            dsGiaoVien = new List<GiaoVien>();
        }
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index] as GiaoVien; }
            set { dsGiaoVien[index] = value; }
        }
        public void Them(GiaoVien gv)
        {
            this.dsGiaoVien.Add(gv);
        }
        public GiaoVien Tim(object obj,SoSanh ss)
        {
            GiaoVien gvresult = null;
            foreach (GiaoVien gv in dsGiaoVien)
            {
                if (ss(obj,gv)==0)
                {
                    gvresult = gv;
                    break;
                }
            }
            return gvresult;
        }
        public bool Xoa(string MS)
        {
            int dsgv_Before_Remove = dsGiaoVien.Count;
            for (int i = 0; i < dsGiaoVien.Count; i++)
            {
                if (MS.CompareTo(dsGiaoVien[i].MaSo)==0)
                {
                    dsGiaoVien.RemoveAt(i);
                    break;
                }
            }
            if (dsGiaoVien.Count == dsgv_Before_Remove)
            {
                return false;
            }
            return true;
        }
        public bool KiemTraRong()
        {
            if (dsGiaoVien.Count==0)
            {
                return true;
            }
            return false;
        }
    }
}
