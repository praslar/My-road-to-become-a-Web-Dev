using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
public class DIEMTHI
    {
        public int IDDIEMTHI { get; set; }
        public int ID { get; set; }
        public int IDHOCKI { get; set; }
        public int IDDOTTHI { get; set; }
        public int IDMONHOC { get; set; }
		public int CANHCAO { get; set; }
		public int DINHCHI { get; set; }
		public decimal TONGDIEM { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public DIEMTHI() { }
        public DIEMTHI(int IDDIEMTHI, int IDTAIKHOAN, int IDHOCKI, int IDDOTTHI, int IDMONHOC, int CANHCAO, int DINHCHI, decimal TONGDIEM)
        {
            this.IDDIEMTHI = IDDIEMTHI;
            this.ID = IDTAIKHOAN;
            this.IDHOCKI = IDHOCKI;
            this.IDDOTTHI = IDDOTTHI;
            this.IDMONHOC = IDMONHOC;
			this.CANHCAO = CANHCAO;
			this.DINHCHI = DINHCHI;
			this.TONGDIEM = TONGDIEM;
        }

		public DIEMTHI( int IDTAIKHOAN, int IDHOCKI, int IDDOTTHI, int IDMONHOC, int CANHCAO, int DINHCHI, decimal TONGDIEM)
		{
			this.ID = IDTAIKHOAN;
			this.IDHOCKI = IDHOCKI;
			this.IDDOTTHI = IDDOTTHI;
			this.IDMONHOC = IDMONHOC;
			this.CANHCAO = CANHCAO;
			this.DINHCHI = DINHCHI;
			this.TONGDIEM = TONGDIEM;
		}
	}
}