using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testpodprogram2018
{
    class Program
    {
        public static int n1, n2, pc=0;
        static void Main(string[] args)
        {
          
            Console.WriteLine("Pocet prvocisel");
            Console.WriteLine("Zadejte interval:");
            try
            {
                n1 = Convert.ToInt32(Console.ReadLine());
                n2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Zadana hodnota neni platne cislo.");
            }
            Console.WriteLine("Nalezena cisla:  ");
            Console.WriteLine("Pocet prvocisel: " + pocet_prvocisel(n2, n1));
            Console.WriteLine("Konec Programu...");
            Console.ReadKey();
        }
        public static bool test(int n)
        {
            if (n == 1 || n == 0) return true;
            if (n == 2) { Console.Write(n + " "); return false; }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            Console.Write(n + " ");
            return true;
        }
        static public int pocet_prvocisel(int n2, int n1)
        {
            for (int i = n1; i <= n2; i++)
            {
                if (test(i) == true)
                {
                    pc++;
                }
            }
            return pc;
        }  
    }
}
