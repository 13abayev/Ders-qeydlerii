using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _02._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapsulation some = new Encapsulation("kenan", 5);
            some.Setter("Babayev");
            Console.WriteLine(some.Getter());
            Console.ReadLine();

        }
    }
}
