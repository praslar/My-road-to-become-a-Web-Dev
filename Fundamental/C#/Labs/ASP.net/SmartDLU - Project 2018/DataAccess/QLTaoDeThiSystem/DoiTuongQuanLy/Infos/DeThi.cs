using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DETHI
    {
        public int IDMADE { get; set; }
        public int IDBODE { get; set; }

        [Required(ErrorMessage = "Vui lòng điền tên đề thi!")]
        public string TENDETHI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public DETHI() { }
        public DETHI(int IDMADE, int IDBODE, string TENDETHI)
        {
            this.IDMADE = IDMADE;
            this.IDBODE = IDBODE;
            this.TENDETHI = TENDETHI;
        }

        public DETHI(int IDBODE, string TENDETHI)
        {
            this.IDBODE = IDBODE;
            this.TENDETHI = TENDETHI;
        }
    }
}
