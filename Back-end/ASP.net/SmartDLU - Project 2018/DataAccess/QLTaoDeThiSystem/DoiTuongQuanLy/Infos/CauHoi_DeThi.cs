using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CAUHOI_DETHI
    {
        public int IDCAUHOIDETHI { get; set; }
        public int IDMADE { get; set; }
        public int IDCAUHOIBODE { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public CAUHOI_DETHI() { }
        public CAUHOI_DETHI(int IDCAUHOIDETHI, int IDMADE, int IDCAUHOIBODE)
        {
            this.IDCAUHOIDETHI = IDCAUHOIDETHI;
            this.IDMADE = IDMADE;
            this.IDCAUHOIBODE = IDCAUHOIBODE;
        }

        public CAUHOI_DETHI(int IDMADE, int IDCAUHOIBODE)
        {
            this.IDMADE = IDMADE;
            this.IDCAUHOIBODE = IDCAUHOIBODE;
        }
    }

}
