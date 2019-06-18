using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Ontap_Console_learnbyheart
{
    public class DanhSachNgoaiNgu
    {
        public ArrayList ds;
        public DanhSachNgoaiNgu()
        {
            ds = new ArrayList();
        }
        public void Them(NgoaiNgu nn)
        {
            ds.Add(nn);
        }
        public override string ToString()
        {
            string s = "Danh sach ngoai ngu: ";
            foreach (object nn in ds)
                s += nn as NgoaiNgu + ";";
            return s;
        }
    }
}
