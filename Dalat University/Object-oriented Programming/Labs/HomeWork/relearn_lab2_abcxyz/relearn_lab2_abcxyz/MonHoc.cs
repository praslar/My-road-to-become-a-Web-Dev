using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relearn_lab2_abcxyz
{
    public class MonHoc
    {
        public string tenMH { get; set; }
        public MonHoc(string mh)
        {
            this.tenMH = mh;
        }
        public override string ToString()
        {
            return tenMH;
        }
    }
}
