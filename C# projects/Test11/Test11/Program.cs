using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11
{
    class Program
    {
        static int k, n, swap;
        static Int64 fakt(int n)
        {
            if (n == 0)
                return 1; 
            else if (n < 0)
                return 0;
            else
                return n * fakt(n - 1);
        }
        static void vymena(ref int k,ref  int n)
        {
                swap = k;
                k = n;
                n = swap;
        }
        static void Main(string[] args)
        {
            n = k = swap = 0;
            Console.Write("Zadej n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej k:");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Výsledek je " + komb_cislo(n, k));
            Console.ReadKey();
        }
        static Int64 komb_cislo(int n, int k)
        {
            vymena(ref k, ref n);
            return (fakt(n)) / (fakt(n - k) * fakt(k));
        }
    }
}
