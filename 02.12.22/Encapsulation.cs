using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02._12._22
{
    public class Encapsulation
    {
        public string Name;
        public int age;
        public string Surname;
        public Encapsulation(string name,string surname, int age)
        {
            Name = name;
            Surname= surname;
            this.age = age;
            
        }
        public void Checker()
        {

        }

        
    }

}
