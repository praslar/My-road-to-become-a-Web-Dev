using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkThePlank
{
    public class ReadFile
    {
        public string readfile()
        {
            StreamReader sr = new StreamReader(new FileStream("words.txt", FileMode.Open));
            string wordlist = sr.ReadToEnd();
            return wordlist;
        }
    }
}
