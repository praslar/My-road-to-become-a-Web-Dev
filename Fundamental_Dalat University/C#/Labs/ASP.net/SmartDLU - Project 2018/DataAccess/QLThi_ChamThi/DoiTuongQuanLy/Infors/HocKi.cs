using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HOCKI
    {
        public int IDHOCKI { get; set; }
        public string TENHOCKI { get; set; }
        public string MOTA { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public HOCKI() { }
        public HOCKI(int IDHOCKI, string TENHOCKI, string MOTA)
        {
            this.IDHOCKI = IDHOCKI;
            this.TENHOCKI = TENHOCKI;
            this.MOTA = MOTA;
        }

        public HOCKI(string TENHOCKI, string MOTA)
        {
            this.TENHOCKI = TENHOCKI;
            this.MOTA = MOTA;
        }
    }
}
