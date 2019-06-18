using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManTester
{
    public class ReadFile
    {
        public string readfile()
        {
            StreamReader sr = new StreamReader
                  (new FileStream("Wordlist.txt", FileMode.Open));
            string wordlist = sr.ReadToEnd();
            return wordlist;
        }
    }
}
