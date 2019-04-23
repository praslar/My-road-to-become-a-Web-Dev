using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

    //Table XULYSUCO
    public class XULYSUCO
    {
        public int IDXULYSUCO { get; set; }
        public int IDBODE { get; set; }
        public int ID { get; set; }
        public string THOIGIAN { get; set; }
        public string NOIDUNG { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public XULYSUCO() { }
        public XULYSUCO(int IDXULYSUCO, int IDBODE, int IDTAIKHOAN, string THOIGIAN, string NOIDUNG)
        {
            this.IDXULYSUCO = IDXULYSUCO;
            this.IDBODE = IDBODE;
            this.ID = IDTAIKHOAN;
            this.THOIGIAN = THOIGIAN;
            this.NOIDUNG = NOIDUNG;
        }

        public XULYSUCO(int IDBODE, int IDTAIKHOAN, string THOIGIAN, string NOIDUNG)
        {
            this.IDBODE = IDBODE;
            this.ID = IDTAIKHOAN;
            this.THOIGIAN = THOIGIAN;
            this.NOIDUNG = NOIDUNG;
        }
    }
}
