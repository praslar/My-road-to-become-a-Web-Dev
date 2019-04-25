using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

    //Table KETQUATHI
    public class KETQUATHI
    {
        public int INDEXCAUHOI { get; set; }
        public int IDDIEMTHI { get; set; }
        public int IDMADE { get; set; }
        public int CAUTRALOI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public KETQUATHI() { }
        public KETQUATHI(int INDEXCAUHOI, int IDDIEMTHI, int IDMADE, int CAUTRALOI)
        {
            this.INDEXCAUHOI = INDEXCAUHOI;
            this.IDDIEMTHI = IDDIEMTHI;
            this.IDMADE = IDMADE;
            this.CAUTRALOI = CAUTRALOI;
        }
        
    }
}

