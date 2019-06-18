using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_exam_lab2._2
{
    public class MonHoc
    {
        public string tenMH { get; set; }
        public MonHoc()
        {
        }
        public MonHoc(string ten)
        {
            this.tenMH = ten;
        }
        public override string ToString()
        {
            return tenMH;
        }
    }
}
