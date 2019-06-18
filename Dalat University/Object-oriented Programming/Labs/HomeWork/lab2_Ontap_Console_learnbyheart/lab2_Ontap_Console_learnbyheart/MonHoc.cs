using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Ontap_Console_learnbyheart
{
    public class MonHoc
    {
        public string TenMH { get; set; }
        public MonHoc()
        {
        }
        public MonHoc(string ten)
        {
            this.TenMH = ten;
        }
        public override string ToString()
        {
            return TenMH; 
        }
    }
}
