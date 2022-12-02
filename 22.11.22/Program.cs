using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11._22
{
    internal class Program
    {
        static void Method(List<string> list)
        {
            Dictionary<int,string> a=new Dictionary<int,string>();
            for (int i = 0; i <list.Count; i++)
            {
                a.Add(i+1, list[i]);
            }
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            #region
            //Dictionary<double, double> d = new Dictionary<double, double>();
            //d.Add(1, 2);
            //d.Add(2, 3);
            //d.Add(3, 4);
            //d.Add(4, 5);
            //foreach (var item in d)
            //{
            //    Console.WriteLine(item.Value);
            //}
            #endregion
            List<string> list = new List<string>()
            {
                "salam" , "dunya" , "turxan", "Kenan"
            };
            Method(list);
            Console.ReadLine();
        }
    }
}
