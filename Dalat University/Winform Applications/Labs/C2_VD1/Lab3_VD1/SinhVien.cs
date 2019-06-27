﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3_VD1
{
public class SinhVien
{
    public string MaSo { get; set; }
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public string DiaChi { get; set; }
    public string Lop { get; set; }
    public string Hinh { get; set; }
    public bool GioiTinh { get; set; }
    public List<string> ChuyenNganh { get; set;}
       
        public string Ten
        {
            get
            {
                string[] ht = this.HoTen.Trim().Split(' ');
                return ht[ht.Length - 1];
            }
        }
    public SinhVien()
    {
        ChuyenNganh = new List<string>();

    }
    public SinhVien(string ms, string ht, DateTime ngay, 
        string dc, string lop, string hinh, bool gt, List<string>cn)
    {
        this.MaSo = ms;
        this.HoTen = ht;
        this.NgaySinh = ngay;
        this.DiaChi = dc;
        this.Lop = lop;
        this.Hinh = hinh;
        this.GioiTinh = gt;
        this.ChuyenNganh = cn;
    }
}
}