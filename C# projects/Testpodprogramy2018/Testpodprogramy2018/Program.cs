using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testpodprogramy2018
{
    class Program
    {
        public static int n1, n2, pc;
        
        static void Main(string[] args)
        {
            n1 = n2 = pc = 0;
            Console.WriteLine("Počet prvočísel v daném intervalu\n\nZadejte interval (každý na nový řádek):");
            try
            {
                n1 = Convert.ToInt32(Console.ReadLine());
                n2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Zadaná hodnota není platné číslo.");
            }

            Console.WriteLine("\nNalezená čísla:  ");
            Console.WriteLine("\n\nPočet prvočísel v intervalu od " + n1 + " do " + n2 + " se rovná: " + pocet_prvocisel(n1, n2));

            Console.ReadKey();
        }

        static bool test(int n)
        {
            if (n == 1 || n == 0) return false;
            if (n == 2) { Console.Write(n + "; "); return true; }

            for (int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            Console.Write(n + "; ");
            return true;
        }

        static int pocet_prvocisel(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                if(test(i) == true)
                {
                    pc++;
                }
            }

            return pc;            
        }
    }
}
