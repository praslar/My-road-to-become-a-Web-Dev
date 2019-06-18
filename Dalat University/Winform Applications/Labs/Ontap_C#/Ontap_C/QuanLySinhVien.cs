using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap_C
{
    delegate int SoSanh(object obj1, object obj2);

    class QuanLySinhVien
    {
        public List<SinhVien> DanhSach=new List<SinhVien>();

       

        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        public SinhVien this[string ms]
        {
            get
            {
                for (int i = 0; i < DanhSach.Count; i++)
                {
                    if (DanhSach[i].MaSo == ms)
                        return DanhSach[i];
                }
                return null;
            }           
        }
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }
        public void NhapCD()
        {
            DateTime nt = new DateTime(2017, 8, 7);
            List<string> dsach = new List<string>() { "Cong nghe phan mem", "Mang may tinh" };
            //dsach[0] = "cong nghe phan mem";
            SinhVien sv1 = new SinhVien("sv201", "DL", true, "a", "Nguyen Van A",
                "CTK39", nt, dsach);
            this.DanhSach.Add(sv1);

            nt = new DateTime(2005, 8, 17);
            dsach = new List<string>() { "Cong nghe phan mem"};
            sv1 = new SinhVien("sv010", "DL", true, "a", "Nguyen Van B",
                "CTK38", nt, dsach);

            this.DanhSach.Add(sv1);

            nt = new DateTime(2006,8, 17);
            dsach = new List<string>() { "Cong nghe phan mem" };
            sv1 = new SinhVien("sv110", "DL", true, "a", "Nguyen Van C",
                "CTK38", nt, dsach);

            this.DanhSach.Add(sv1);
        }
        public int TimMaso(string ms)
        {
            int kq = -1;
            for (int i = 0; i < DanhSach.Count; i++)
                if (DanhSach[i].MaSo == ms)
                {
                    kq = i;
                    break;
                }
            return kq;
        }
        public int Tim(object text, SoSanh ss)
        {
            int kq = -1;
            for (int i = 0; i < DanhSach.Count; i++)
                if (ss(text, DanhSach[i])==0)
                {
                    kq = i;
                    break;
                }
            return kq;
        }
        public void SapXepTheoMS()
        {
            //int kq = -1;
            for (int i = 0; i < DanhSach.Count - 1; i++)
                for (int j = i + 1; j < DanhSach.Count; j++)
                    if (DanhSach[i].MaSo.CompareTo(DanhSach[j].MaSo) > 0)
                    {
                        SinhVien sv = DanhSach[i];
                        DanhSach[i] = DanhSach[j];
                        DanhSach[j] = sv;
                    }
                
            //return kq;
        }
        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i < DanhSach.Count - 1; i++)
                for (int j = i + 1; j < DanhSach.Count; j++)
                    if (ss(DanhSach[i], DanhSach[j]) > 0)
                    {
                        SinhVien sv = DanhSach[i];
                        DanhSach[i] = DanhSach[j];
                        DanhSach[j] = sv;
                    }
        }
        public void Xuat()
        {
            for (int i = 0; i < DanhSach.Count; i++)
            {
                Console.WriteLine(DanhSach[i].MaSo+"\t"+DanhSach[i].HoTen);
            }
        }
    }
}
