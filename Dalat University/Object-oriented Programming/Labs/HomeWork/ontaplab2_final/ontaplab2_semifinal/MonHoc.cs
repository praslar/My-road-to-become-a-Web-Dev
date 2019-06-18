using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontaplab2_semifinal
{
    public class MonHoc
    {
        public string TenMH { get; set; }
        public MonHoc()
        {
        }
        public MonHoc(string mh)
        {
            this.TenMH = mh;
        }
        public override string ToString()
        {
            return TenMH;
        }
    }
}
