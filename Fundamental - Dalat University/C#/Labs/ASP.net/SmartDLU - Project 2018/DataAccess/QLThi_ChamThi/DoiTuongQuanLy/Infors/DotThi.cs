using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DOTTHI
    {
        public int IDDOTTHI { get; set; }
        public string TENDOTTHI { get; set; }
        public string MOTA { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public DOTTHI() { }
        public DOTTHI(int IDDOTTHI, string TENDOTTHI, string MOTA)
        {
            this.IDDOTTHI = IDDOTTHI;
            this.TENDOTTHI = TENDOTTHI;
            this.MOTA = MOTA;
        }

        public DOTTHI(string TENDOTTHI, string MOTA)
        {
            this.TENDOTTHI = TENDOTTHI;
            this.MOTA = MOTA;
        }
    }
}