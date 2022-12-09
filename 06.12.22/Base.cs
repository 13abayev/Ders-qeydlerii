using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._12._22
{
    public class Base
    {
        public Base(int id,string name)
        {
            Id= id;
            Name= name;
            Console.WriteLine("Hello base");
        }
        public int Id;
        public string Name;
        public int Num;


    }
}
