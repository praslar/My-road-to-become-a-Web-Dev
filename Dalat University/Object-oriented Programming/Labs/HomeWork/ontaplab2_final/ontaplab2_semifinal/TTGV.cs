using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontaplab2_semifinal
{
    public class TTGV
    {
        public string Maso { get; set; }
        public string Hoten { get; set; }
        public DateTime Ngaysinh;
        public string Gioitinh;
        public string SoDT;
        public string Mail;
        public DanhSachMonHoc Danhsachmonhoc;
        public DanhSachNgoaiNgu Danhsachngoaingu;
        public TTGV()
        {
            Danhsachmonhoc = new DanhSachMonHoc();
            Danhsachngoaingu = new DanhSachNgoaiNgu();
        }
        public override string ToString()
        {
            string s = "Mã số: " + Maso + "\n"
                + "Họ tên: " + Hoten + "\n"
                + "Ngày sinh: " + Ngaysinh.ToString() + "\n"
                + "Giới tính: " + Gioitinh + "\n"
                + "Số ĐT: " + SoDT + "\n"
                + "Mail: " + Mail + "\n";
            string dsmh = "Danh sách môn giảng dạy: " + "\n";
            foreach(MonHoc mh in Danhsachmonhoc.dsmh)
            {
                dsmh += mh + ";" + "\n";
            }
            string dsnn = "Ngoại ngữ: " + "\n";
            foreach(NgoaiNgu nn in Danhsachngoaingu.dsnn)
            {
                dsnn += nn + ";" +"\n";
            }
            s += dsnn + "\n" + dsmh;
            return s;
        }
    }
}
