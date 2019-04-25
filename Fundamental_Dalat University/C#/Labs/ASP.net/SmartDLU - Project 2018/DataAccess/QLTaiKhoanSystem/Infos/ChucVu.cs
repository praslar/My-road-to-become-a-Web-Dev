using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ChucVu
    {

        public ChucVu()
        {

        }

        public int ID { get; set; }
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public string MoTaCV { get; set; }

        public ChucVu(int iD,string MaCV,string TenCV,string MoTaCV)
        {
            this.ID = ID;
            this.MaCV = MaCV;
            this.TenCV = TenCV;
            this.MoTaCV = MoTaCV;
        }
        


    }
}
