using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BODE
    {
        public int IDBODE { get; set; }
        public int IDMONHOC { get; set; }
        public string TENBODE { get; set; }
        public int SOLUONGCAUHOI { get; set; }
        public DateTime NGAYTAOBODE { get; set; }
        public int DIEMTOIDA { get; set; }
        public int MUCDIEMDAT { get; set; }
        public int THOIGIANLAMBAI_PHUT_ { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public BODE() { }
        public BODE(int IDBODE, int IDMONHOC, string TENBODE, int SOLUONGCAUHOI, DateTime NGAYTAOBODE, int DIEMTOIDA, int MUCDIEMDAT, int THOIGIANLAMBAI_PHUT_)
        {
            this.IDBODE = IDBODE;
            this.IDMONHOC = IDMONHOC;
            this.TENBODE = TENBODE;
            this.SOLUONGCAUHOI = SOLUONGCAUHOI;
            this.NGAYTAOBODE = NGAYTAOBODE;
            this.DIEMTOIDA = DIEMTOIDA;
            this.MUCDIEMDAT = MUCDIEMDAT;
            this.THOIGIANLAMBAI_PHUT_ = THOIGIANLAMBAI_PHUT_;
        }

        public BODE(int IDMONHOC, string TENBODE, int SOLUONGCAUHOI, DateTime NGAYTAOBODE, int DIEMTOIDA, int MUCDIEMDAT, int THOIGIANLAMBAI_PHUT_)
        {
            this.IDMONHOC = IDMONHOC;
            this.TENBODE = TENBODE;
            this.SOLUONGCAUHOI = SOLUONGCAUHOI;
            this.NGAYTAOBODE = NGAYTAOBODE;
            this.DIEMTOIDA = DIEMTOIDA;
            this.MUCDIEMDAT = MUCDIEMDAT;
            this.THOIGIANLAMBAI_PHUT_ = THOIGIANLAMBAI_PHUT_;
        }
    }
}
