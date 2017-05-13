using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int el = 0;
            int s=0;
            try
            {
                s = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)  { }
            int[] a = new int[s];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
                {
                    a[i] = r.Next(0, 1000);
                    Console.Write(a[i] + " ");
                }
            int[] a1 = new int[s+1];
            try { 
            el = Convert.ToInt32(Console.ReadLine());
        }
            catch(FormatException)  { }
            a1 = a;
            a1[s+1] = el;
            Console.Write(a1);
            Console.ReadLine();
        }
    }
}
