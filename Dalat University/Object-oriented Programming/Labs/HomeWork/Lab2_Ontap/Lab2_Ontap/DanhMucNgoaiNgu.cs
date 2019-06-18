using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Ontap
{
    public class DanhMucNgoaiNgu
    {
        public ArrayList dsnn;
         public DanhMucNgoaiNgu()
        {
            dsnn = new ArrayList();
        }
        public NgoaiNgu this[int index]
        {
            get { return dsnn[index] as NgoaiNgu; }
            set { dsnn[index] = value; }
        }
        public void Them(NgoaiNgu nn)
        {
            this.dsnn.Add(nn);
        }
        public override string ToString()
        {
            string s = "Danh sach ngoai ngu: ";
            foreach(object nn in dsnn)
            {
                s += nn as NgoaiNgu + ";";
            }
            return s;
        }
    }
}
