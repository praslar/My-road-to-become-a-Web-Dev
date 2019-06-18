using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Labthree
{
    public class SinhVien
    {
        public string HoTen { get; set; }
        public List<string> ChuyenNganh { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string Hinh { get; set; }
        public string MaSo { get; set; }
        public DateTime NgaySinh { get; set; }
        public SinhVien()
        {
            ChuyenNganh = new List<string>();
        }
    }
}
