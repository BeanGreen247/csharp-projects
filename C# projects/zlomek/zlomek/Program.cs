using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zlomek
{
    class Program
    {
        public static int NSD(int a, int b)
        {
            while (a!=b)
            {
                if (a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;   
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int c, j;
            Console.Write("Zadej citatele zlomku ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej jmenovatele zlomku ");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Puvodni zlomek = {0}/{1}", c, j);
            int c1 = c;
            int j1 = j;
            c = c / NSD(c1, j1);
            j = j / NSD(c1, j1);
            
            Console.WriteLine("Zlomek po zkraceni = {0}/{1}",c,j);
            Console.ReadKey();
        }
    }
}
