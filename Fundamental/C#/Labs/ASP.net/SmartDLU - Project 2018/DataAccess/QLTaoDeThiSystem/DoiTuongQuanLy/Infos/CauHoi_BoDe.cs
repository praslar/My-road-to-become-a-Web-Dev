using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CAUHOI_BODE
    {
        public int IDCAUHOIBODE { get; set; }
        public int IDBODE { get; set; }
        public int IDCAUHOI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public CAUHOI_BODE() { }
        public CAUHOI_BODE(int IDCAUHOIBODE, int IDBODE, int IDCAUHOI)
        {
            this.IDCAUHOIBODE = IDCAUHOIBODE;
            this.IDBODE = IDBODE;
            this.IDCAUHOI = IDCAUHOI;
        }

        public CAUHOI_BODE(int IDBODE, int IDCAUHOI)
        {
            this.IDBODE = IDBODE;
            this.IDCAUHOI = IDCAUHOI;
        }
    }

}
