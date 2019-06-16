using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GETDIEMTHIMODELVIEW
	{
        public string TENMONHOC { get; set; }
        public string TENHOCKI { get; set; }
        public string TENDOTTHI { get; set; }
        public int ID { get; set; }
        public int CANHCAO { get; set; }
        public int DINHCHI { get; set; }
		public decimal TONGDIEM { get; set; }
		public int IDMADE { get; set; }

		public GETDIEMTHIMODELVIEW()
        {

        }

        public GETDIEMTHIMODELVIEW(string TENMONHOC, string TENHOCKI, string TENDOTTHI, int ID, int CANHCAO, int DINHCHI, decimal TONGDIEM, int IDMADE)
        {
            this.TENMONHOC = TENMONHOC;
            this.TENHOCKI = TENHOCKI;
            this.TENDOTTHI = TENDOTTHI;
            this.ID = ID;
            this.CANHCAO = CANHCAO;
            this.DINHCHI = DINHCHI;
            this.TONGDIEM = TONGDIEM;
			this.IDMADE = IDMADE;
		}

    }
}
