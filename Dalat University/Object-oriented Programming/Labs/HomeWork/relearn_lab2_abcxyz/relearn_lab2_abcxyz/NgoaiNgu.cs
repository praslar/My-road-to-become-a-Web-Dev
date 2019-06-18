using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relearn_lab2_abcxyz
{
    public class NgoaiNgu
    {
        public string tenNN { get; set; }
        public NgoaiNgu(string nn)
        {
            this.tenNN = nn;
        }
        public override string ToString()
        {
            return tenNN;
        }
    }
}
