using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Ontap
{
    public class NgoaiNgu
    {
        public string tenMH { get; set; }
        public NgoaiNgu(string ten)
        {
            this.tenMH = ten;
        }
        public override string ToString()
        {
            return tenMH;
        }
    }
}
