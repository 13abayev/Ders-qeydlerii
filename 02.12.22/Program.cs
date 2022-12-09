using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _02._12._22
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Encapsulation Adam = new Encapsulation("Kenan", "Vorzakon", 8);
            Encapsulation Adam2= new Encapsulation("Turxan", "Vilkavuran", 11);
            List<int> list = new List<int>();
            List<string> AdSoyad = new List<string>();
            AdSoyad.Add(Adam.Name);
            AdSoyad.Add(Adam.Surname);
            AdSoyad.Add(Adam2.Name);
            AdSoyad.Add(Adam2.Surname);
            List<int> Age=new List<int>();
            list.Add(Adam.age); list.Add(Adam2.age);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]>10)
                {
                    Age.Add(list[i]);
                }
            }        

            Console.ReadLine();

        }
    }
}
