using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class GETLICHTHIMODELVIEW
	{
		
		public string TENMONHOC { get; set; }
		public string TENHOCKI { get; set; }
		public string TENDOTTHI { get; set; }
		public DateTime NGAYTHI { get; set; }
		public string GIOTHI { get; set; }
		public int THOIGIANLAMBAI_PHUT_ { get; set; }
		public int SOLUONGCAUHOI { get; set; }
		public int IDBODE { get; set; }
		public int IDLICHTHI { get; set; }

		public GETLICHTHIMODELVIEW()
		{

		}

		public GETLICHTHIMODELVIEW(string TENMONHOC, string TENHOCKI, string TENDOTTHI, DateTime NGAYTHI, string GIOTHI, int THOIGIANLAMBAI_PHUT_, int SOLUONGCAUHOI, int IDBODE)
		{
			this.TENMONHOC = TENMONHOC;
			this.TENHOCKI = TENHOCKI;
			this.TENDOTTHI = TENDOTTHI;
			this.NGAYTHI = NGAYTHI;
			this.GIOTHI = GIOTHI;
			this.THOIGIANLAMBAI_PHUT_ = THOIGIANLAMBAI_PHUT_;
			this.SOLUONGCAUHOI = SOLUONGCAUHOI;
			this.IDBODE = IDBODE;
		}

	}
}
