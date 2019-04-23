using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class KETQUATHITHU
    {
        public int IDTHITHU { get; set; }
        public int INDEXCAUHOI { get; set; }
        public int CAUTRALOI { get; set; }
        public KETQUATHITHU()
        { }

        public KETQUATHITHU(int IDTHITHU,int INDEXCAUHOI,int CAUTRALOI)
        {
            this.IDTHITHU = IDTHITHU;
            this.INDEXCAUHOI = INDEXCAUHOI;
            this.CAUTRALOI = CAUTRALOI;
        }
    }
}
