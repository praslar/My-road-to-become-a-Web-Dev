using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess
{
    public class TaiKhoan
    {

        public TaiKhoan()
        {

        }

        public int ID { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string MaCV { get; set; }
        public int ? IDLop { get; set; }
        public TaiKhoan(int ID,string TenDangNhap,string MatKhau,string Email, string MaCV,int IDLop)

        {
            this.ID = ID;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.Email = Email;
            this.MaCV = MaCV;
            this.IDLop = IDLop; 

        }
    }
}
