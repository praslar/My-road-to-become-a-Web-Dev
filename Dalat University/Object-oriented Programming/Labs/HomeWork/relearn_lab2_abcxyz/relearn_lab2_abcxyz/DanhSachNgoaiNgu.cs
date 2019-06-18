using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relearn_lab2_abcxyz
{
    public class DanhSachNgoaiNgu
    {
        public ArrayList dsnn;
        public DanhSachNgoaiNgu()
        {
            dsnn = new ArrayList();
        }
        public void Add(NgoaiNgu nn)
        {
            dsnn.Add(nn);
        }
        public NgoaiNgu this[int index]
        {
            get { return dsnn[index] as NgoaiNgu; }
            set { dsnn[index] = value; }
        }
        public override string ToString()
        {
            string s = "Danh Sách Ngoại Ngữ: ";
            foreach (object nn in this.dsnn)
            {
                s += nn as NgoaiNgu + "; ";
            }
            return s;
        }
    }
}
