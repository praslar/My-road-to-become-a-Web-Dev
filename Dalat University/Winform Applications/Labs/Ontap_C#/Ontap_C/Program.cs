using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap_C
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLySinhVien ql = new QuanLySinhVien();
            ql.NhapCD();
            ql.Xuat();
            //Console.WriteLine(ql["sv010"].HoTen);
            int kq1 = ql.TimMaso("abc");

            //int kq = ql.Tim("Nguyen Van B", SoSanhTheoHT);
            //Console.WriteLine(ql[kq].MaSo+"\t"+ql[kq].HoTen);
            //ql.SapXepTheoMS();
            ql.SapXep(SoSanhTheoMaSX);
            Console.WriteLine("Danh sach tang theo maso:");
            ql.Xuat();

            //SDList();
            Console.ReadKey();

        }
        static int SoSanhTheoHT(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;//(SinhVien)obj2;
            return sv.HoTen.CompareTo(obj1);
        }
        static int SoSanhTheoMS(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;//(SinhVien)obj2;
            return sv.MaSo.CompareTo(obj1);
        }
        static int SoSanhTheoMaSX(object obj1, object obj2)
        {
            SinhVien sv1 = (SinhVien)obj1;
            SinhVien sv2 = obj2 as SinhVien;//(SinhVien)obj2;
            return sv1.MaSo.CompareTo(sv2.MaSo);
        }

        static void SDList()
        {
            List<string> ds2 = new List<string>();
            ArrayList ds = new ArrayList();
            string[] ds1 = new string[100];
            DateTime ngaysinh = new DateTime(2010, 10, 20);
            Console.WriteLine(ngaysinh.ToShortDateString());


            ds.Add("CTK39");
            ds.Add("CTK38");
            ds.Add("CTK37");
            ds.Add("CTK36");

            Console.WriteLine("Ds ban dau:");
            foreach (string item in ds)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < ds.Count; i++)
            //{
            //    Console.WriteLine(ds[i].ToString());
            //}
            //ds.Remove("CTK37");
            ds.RemoveAt(2);
            Console.WriteLine("Ds sau khi xoa:");
            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(ds[i].ToString());
            }

        }
    }
}
