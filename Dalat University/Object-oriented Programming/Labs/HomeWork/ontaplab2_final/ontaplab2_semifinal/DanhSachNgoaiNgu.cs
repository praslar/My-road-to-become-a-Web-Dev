using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontaplab2_semifinal
{
    public class DanhSachNgoaiNgu
    {
        public ArrayList dsnn;
        public DanhSachNgoaiNgu()
        {
            dsnn = new ArrayList();
        }
        public NgoaiNgu this[int index]
        {
            get { return dsnn[index] as NgoaiNgu; }
            set { dsnn[index] = value; }
        }
        public void Add(NgoaiNgu nn)
        {
            dsnn.Add(nn);
        }
        public override string ToString()
        {
            string s = "Ngoại ngữ: ";
            foreach (object item in dsnn)
            {
                s += item as NgoaiNgu + ";" ;
            }
            return s;
        }
    }
}
