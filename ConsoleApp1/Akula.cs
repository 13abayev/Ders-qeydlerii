using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Akula
    {
        public Akula(string a)
        {
            a = "x";
        }
        public Akula(string a,string b):this(a)
        {
            b = "y";
        }
        public Akula(string a ,string b,string c):this(a,b)
        {
            c = "z";
        }       
    }
}
