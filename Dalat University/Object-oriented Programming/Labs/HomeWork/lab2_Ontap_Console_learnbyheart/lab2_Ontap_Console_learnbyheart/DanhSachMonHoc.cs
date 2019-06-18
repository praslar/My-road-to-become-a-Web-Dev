using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Ontap_Console_learnbyheart
{
    public class DanhSachMonHoc
    {
        public ArrayList ds;
        public DanhSachMonHoc()
        {
            ds = new ArrayList();
        }
        public MonHoc this[int index]
        {
            get { return ds[index] as MonHoc; }
            set { ds[index] = value; }
        }
        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh sach mon hoc: ";
            foreach (object mh in ds)
                s += mh as MonHoc + ";";
            return s;
        }
    }
}
