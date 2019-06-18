﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1510251_PhamXuanThang_Lab03
{
    public class SinhVien
    {
        public List<string> ChuyenNganh { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string Hinh { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public string MaSo { get; set; }
        public DateTime NgaySinh { get; set; }
        public SinhVien()
        {
            ChuyenNganh = new List<string>();
        }
        public SinhVien(List<string> chuyenNganh, string diaChi, bool gioiTinh, string hinh, string hoTen, string lop, string maSo, DateTime ngaySinh)
        {
            this.ChuyenNganh = chuyenNganh;
            this.DiaChi = diaChi;
            this.GioiTinh = gioiTinh;
            this.Hinh = hinh;
            this.HoTen = hoTen;
            this.Lop = lop;
            this.MaSo = maSo;
            this.NgaySinh = ngaySinh;
        }
    }
}
