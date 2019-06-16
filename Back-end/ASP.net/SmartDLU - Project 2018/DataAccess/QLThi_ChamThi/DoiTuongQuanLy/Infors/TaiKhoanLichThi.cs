using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TAIKHOANLICHTHI
    {
        public int ID { get; set; }
        public int IDTAIKHOAN { get; set; }
        public int IDLICHTHI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public TAIKHOANLICHTHI() { }
        public TAIKHOANLICHTHI(int ID, int IDTAIKHOAN, int IDLICHTHI)
        {
            this.ID = ID;
            this.IDTAIKHOAN = IDTAIKHOAN;
            this.IDLICHTHI = IDLICHTHI;
        }

        public TAIKHOANLICHTHI(int IDTAIKHOAN, int IDLICHTHI)
        {
            this.IDTAIKHOAN = IDTAIKHOAN;
            this.IDLICHTHI = IDLICHTHI;
        }
    }
}