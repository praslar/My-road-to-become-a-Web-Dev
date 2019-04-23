using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class THITHU
    {
        public int IDTHITHU { get; set; }
        public int IDMADE { get; set; }

        public THITHU()
        { }
        public THITHU(int IDTHITHU, int IDMADE)
        {
            this.IDTHITHU = IDTHITHU;
            this.IDMADE = IDMADE;
        }

    }
}
