using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _06._12._22
{
    internal class Derived:Base
    {
        public Derived(int id,string name):base(id,name)
        {
            Console.WriteLine("Hello base");
        }
    }
}
