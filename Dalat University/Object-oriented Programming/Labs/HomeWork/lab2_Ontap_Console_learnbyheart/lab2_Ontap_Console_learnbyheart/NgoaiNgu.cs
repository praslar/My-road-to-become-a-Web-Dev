using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Ontap_Console_learnbyheart
{
    public class NgoaiNgu
    {
        public string TenNN { get; set; }
        public NgoaiNgu()
        {
        }
        public NgoaiNgu(string ten)
        {
            this.TenNN = ten;
        }
        public override string ToString()
        {
            return TenNN;
        }
    }
}
