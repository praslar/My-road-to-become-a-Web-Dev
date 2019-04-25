using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Lop
    {

        public Lop()
        {

        }

        public int ID { get; set; }
        public string TenLop { get; set; }
        public string MoTaLop { get; set; }
        public bool TrangThai { get; set; }
      

        public Lop(int ID,string TenLop,string MoTaLop,bool TrangThai)
        {
            this.ID = ID;
            this.TenLop = TenLop;
            this.MoTaLop = MoTaLop;
            this.TrangThai = TrangThai;
         
        }

    }
}
