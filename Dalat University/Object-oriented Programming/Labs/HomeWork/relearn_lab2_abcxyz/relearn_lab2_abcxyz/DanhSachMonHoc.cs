using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relearn_lab2_abcxyz
{
    public class DanhSachMonHoc
    {
        public ArrayList dsmh;
        public DanhSachMonHoc()
        {
            dsmh = new ArrayList();
        }
        public void Add(MonHoc mh)
        {
            dsmh.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh sách môn học: ";
            foreach (object mh in this.dsmh)
            {
                s += mh as MonHoc + "; ";
            }
            return s;
        }

    }
}
