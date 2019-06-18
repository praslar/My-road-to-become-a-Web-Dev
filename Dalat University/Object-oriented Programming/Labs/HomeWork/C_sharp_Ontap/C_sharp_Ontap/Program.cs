using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Ontap
{
    class PhanSo
    {
        public int tu;
        public int mau;
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", tu, mau);
        }
        public PhanSo()
        {
            tu = 7;
            mau = 6;
        }
        public PhanSo(int t,int m)
        {
            tu = t;
            mau = m;
        }
        public PhanSo(PhanSo a)
        {
            tu = a.tu;
            mau = a.mau;
        }
        public PhanSo Nhan(PhanSo a)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * this.tu;
            kq.mau = a.mau * this.mau;
            return kq;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo(3, 4);
            a.Xuat();
            PhanSo b = new PhanSo();
            b.Xuat();
            PhanSo c = b.Nhan(a);
            c.Xuat();
            Console.ReadKey();
        }
    }
}
