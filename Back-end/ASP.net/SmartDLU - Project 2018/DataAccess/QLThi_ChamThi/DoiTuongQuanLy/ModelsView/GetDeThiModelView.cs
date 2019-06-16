using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GETDETHIMODELVIEW
    {
		public string TENMONHOC { get; set; }
		public string TENDETHI { get; set; }
		public int THOIGIANLAMBAI_PHUT_ { get; set; }
		public string TENHOCKI { get; set; }
		public string TENDOTTHI { get; set; }
		public DateTime NGAYTHI { get; set; }
		public int SOLUONGCAUHOI { get; set; }
        public int IDMADE { get; set; }

        public GETDETHIMODELVIEW()
        {

        }
        public GETDETHIMODELVIEW(string TENMONHOC, string TENDETHI, int THOIGIANLAMBAI_PHUT_, string TENHOCKI, string TENDOTTHI, DateTime NGAYTHI, int SOLUONGCAUHOI, int IDMADE)
        {
            this.TENMONHOC = TENMONHOC;
            this.TENDETHI = TENDETHI;
            this.THOIGIANLAMBAI_PHUT_ = THOIGIANLAMBAI_PHUT_;
            this.TENHOCKI = TENHOCKI;
            this.TENDOTTHI = TENDOTTHI;
            this.NGAYTHI = NGAYTHI;
            this.SOLUONGCAUHOI = SOLUONGCAUHOI;
            this.IDMADE = IDMADE;
        }
    }
}
