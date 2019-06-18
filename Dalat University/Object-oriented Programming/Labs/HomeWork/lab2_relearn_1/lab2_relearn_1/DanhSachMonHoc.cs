using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_relearn_1
{
    public class DanhSachMonHoc
    {
        public ArrayList dsmh;
        public DanhSachMonHoc()
        {
            dsmh = new ArrayList();
        }
        public MonHoc this[int index]
        {
            get { return dsmh[index] as MonHoc; }
            set { dsmh[index] = value; }
        }
        public void Add(MonHoc mh)
        {
            dsmh.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh sách môn học: ";
            foreach (object item in dsmh)
            {
                s += item as MonHoc + ";";
            }
            return s;
        }
    }
}
