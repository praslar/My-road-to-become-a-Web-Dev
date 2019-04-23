using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CAUTRALOICUACAUHOIDETHI
    {
        public int IDCAUTRALOICUACAUHOIDETHI { get; set; }
        public int IDCAUHOIDETHI { get; set; }
        public int IDCAUTL { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public CAUTRALOICUACAUHOIDETHI() { }
        public CAUTRALOICUACAUHOIDETHI(int IDCAUTRALOICUACAUHOIDETHI, int IDCAUHOIDETHI, int IDCAUTL)
        {
            this.IDCAUTRALOICUACAUHOIDETHI = IDCAUTRALOICUACAUHOIDETHI;
            this.IDCAUHOIDETHI = IDCAUHOIDETHI;
            this.IDCAUTL = IDCAUTL;
        }

        public CAUTRALOICUACAUHOIDETHI(int IDCAUHOIDETHI, int IDCAUTL)
        {
            this.IDCAUHOIDETHI = IDCAUHOIDETHI;
            this.IDCAUTL = IDCAUTL;
        }
    }
}
