using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontaplab2_semifinal
{
    public class NgoaiNgu
    {
        public string Tenngoaingu { get; set; }
        public NgoaiNgu()
        {
        }
        public NgoaiNgu(string nn)
        {
            this.Tenngoaingu = nn;
        }
        public override string ToString()
        {
            return Tenngoaingu;
        }
    }
}
