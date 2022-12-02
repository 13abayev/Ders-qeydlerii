using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Cryptography;

namespace Ders_18._11._22_
{
    internal class Program
    {
        static void Yoxlayan(string []a)
        {
            bool c = true;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; i < a[i].Length/2; i++)
                {
                    for (int k = a[i].Length; i > a[i].Length / 2; i++)
                    {
                        if (a[i][j] == a[i][k])
                        {
                            Console.WriteLine(c);
                        }
                    }
                }
            }
        }

        static void Akula(params int[] a)
        {         
            double koka = Math.Sqrt(a[0]);
            double kokb = Math.Sqrt(a[1]);
            double quvveta = Math.Pow(a[0], 2);
            double quvvetb = Math.Pow(a[1], 2);
            List<double> list = new List<double>()
            {
                koka,kokb,quvveta,quvvetb
            };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        static void Minus(List<int> a)
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        static void Method(params int[] a)
        {
            List<int> b = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b.Add(a[i]);
                }               
            }
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
        }
        static bool Checker(List<string> a)
        {
            string target = "akula";
            return a.Contains("akula");
        }
        static void Main(string[] args)
        {
            #region
            //List<string> a = new List<string>();
            //string[] b = Console.ReadLine().Split();
            //for (int i = 0; i < b.Length; i++)
            //{
            //    a.Add(b[i]);
            //}
            //Console.WriteLine(Checker(a));
            //Console.ReadLine();
            //List<int> list = new List<int>()
            //{
            //  0,3,1,2,-4,-9,2,7
            //};
            //Minus(list);
            //Console.ReadLine();
            #endregion
            //Random random = new Random();
            //int a = random.Next(0, 10);
            //int b = random.Next(0, 10);
            //Akula(a, b);
            //ezize cavad rehim murad kelek
            string[] a = new string[] { "ezize", "cavad", "rehim", "murad", "kelek" };
            Console.ReadLine();
        }
    }
}
