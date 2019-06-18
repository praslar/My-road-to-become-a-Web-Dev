using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontaplab2_semifinal
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
            foreach (object mh in dsmh)
                s += mh as MonHoc + ";";
            return s;
        }
    } 
}
