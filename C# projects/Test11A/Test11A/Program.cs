using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11A
{
    class Program
    {
        static int k, n, buffer;
        

        static void Main(string[] args)
        {
            // pass-by-reference zavedení hodnot
            n = k = buffer = 0;

            // čekání na user input
            Console.WriteLine("Zadejte parametr n: ");
            try // ošetření špatného vstupu
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("zadaná hodnota není legitimní číslo");
            }
            
            Console.WriteLine("Zadejte parametr k: ");
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("zadaná hodnota není legitimní číslo");
            }


            Console.WriteLine("\n\nVýsledek se rovná: " + komb_cislo(n, k));
            Console.ReadKey();
        }

        // funkce pro výpočet faktoriálu
        static Int64 fakt(int n)
        {
            if (n == 0)
                return 1; // při nule vracíme jedničku
            else if (n < 0)
                return 0;
            else
                return n * fakt(n - 1);  // jednoduchá rekurze
        }
        
        // pokud je k větší než n, prohodí se parametry
        static void vymena() 
        {
            if (k > n)
            {
                buffer = k;
                k = n;
                n = buffer;
            }
            else return;
                
        }

        static Int64 komb_cislo(int n, int k)
        {
            vymena();
            try
            {
               return (fakt(n)) / (fakt(n - k) * fakt(k));
            }
            catch (Exception)
            {
                // prostě to nechme víceméně potichu selhat
            }
            return 0;           
        }
        

    }
}
