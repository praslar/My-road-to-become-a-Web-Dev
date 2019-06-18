using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    public class MonHoc
    {
        public int ID { get; set; }
        public string TenMH { get; set; }
        public int SoTC { get; set; }
        public MonHoc()
        {
        }
        public MonHoc(string ten)
        {
            this.TenMH = ten;
        }
        public MonHoc (int id, string ten, int tc )
        {
            this.ID = id;
            this.TenMH = ten;
            this.SoTC = tc;
        }
        public override string ToString()
        {
            return TenMH;
        }
    }
}
