using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LICHTHI
    {
        public int IDLICHTHI { get; set; }
        public int IDBODE { get; set; }
        public int IDDOTTHI { get; set; }
        public int IDHOCKI { get; set; }
        public int ID { get; set; }
        public DateTime NGAYTHI { get; set; }
        public string GIOTHI { get; set; }
        public string PHONGTHI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public LICHTHI() { }
        public LICHTHI(int IDLICHTHI, int IDBODE, int IDDOTTHI, int IDHOCKI, int IDTAIKHOAN, DateTime NGAYTHI, string GIOTHI, string PHONGTHI)
        {
            this.IDLICHTHI = IDLICHTHI;
            this.IDBODE = IDBODE;
            this.IDDOTTHI = IDDOTTHI;
            this.IDHOCKI = IDHOCKI;
            this.ID = IDTAIKHOAN;
            this.NGAYTHI = NGAYTHI;
            this.GIOTHI = GIOTHI;
            this.PHONGTHI = PHONGTHI;
        }

        public LICHTHI(int IDBODE, int IDDOTTHI, int IDHOCKI, int IDTAIKHOAN, DateTime NGAYTHI, string GIOTHI, string PHONGTHI)
        {
            this.IDBODE = IDBODE;
            this.IDDOTTHI = IDDOTTHI;
            this.IDHOCKI = IDHOCKI;
            this.ID = IDTAIKHOAN;
            this.NGAYTHI = NGAYTHI;
            this.GIOTHI = GIOTHI;
            this.PHONGTHI = PHONGTHI;
        }
    }
}