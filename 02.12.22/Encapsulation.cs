using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._12._22
{
    public class Encapsulation
    {
        public string Name;
        public int age;
        public Encapsulation(string name, int age)
        {
            Name = name;
            this.age = age;
        }
        private string Surname;
        public string Getter()
        {
            return Surname;
        }
        public void Setter(string surname)
        {
            Surname = surname;
        }
        
    }

}
