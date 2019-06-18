using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relearn_lab2_abcxyz
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public string GioiTinh;
        public string SoDT;
        public string Mail;
        public DanhSachMonHoc dsmh;
        public DanhSachNgoaiNgu dsnn;
        public GiaoVien()
        {
            dsmh = new DanhSachMonHoc();
            dsnn = new DanhSachNgoaiNgu();
        }
        public override string ToString()
        {
            string s = "Mã số: " + MaSo  + "\n"
                + "Họ tên: " + HoTen + "\n"
                + "Ngày sinh: " + NgaySinh  + "\n"
                + "Giới tính: " + GioiTinh  + "\n"
                + "Số ĐT: " + SoDT + "\n"
                + "Địa chỉ mail: " + Mail + "\n";
            string nn = "Danh sách ngoại ngữ: ";
            foreach (NgoaiNgu ngoaingu in dsnn.dsnn)
            {
                nn += ngoaingu + " ;";
            }
            string mh = "Danh sách môn giảng dạy: ";
            foreach (MonHoc monhoc in dsmh.dsmh)
            {
                mh += monhoc + " ;";
            }
            s += "\n" + nn + "\n" + mh;
            return s;
        }

    }
}
