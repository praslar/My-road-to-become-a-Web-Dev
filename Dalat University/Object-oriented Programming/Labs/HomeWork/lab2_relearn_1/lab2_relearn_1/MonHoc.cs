using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_relearn_1
{
    public class MonHoc
    {
        public string TenMH { get; set; }
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
