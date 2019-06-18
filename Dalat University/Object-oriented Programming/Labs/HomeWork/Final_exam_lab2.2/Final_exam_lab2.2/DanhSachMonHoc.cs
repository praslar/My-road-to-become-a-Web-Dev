using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_exam_lab2._2
{
    public class DanhSachMonHoc
    {
        public string tenMH;
        public ArrayList dsmh;
        public DanhSachMonHoc()
        {
            this.dsmh = new ArrayList();
        }
        public void Add(MonHoc mh)
        {
            dsmh.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh sách môn học: ";
            foreach (MonHoc mh in dsmh)
            {
                s += mh + ";";
            }
            return s; 
        }
    }
}
