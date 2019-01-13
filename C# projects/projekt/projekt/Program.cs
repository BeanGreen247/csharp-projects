using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Program
    {
           public struct zak {
            public int ProC;
            public string jmeno;
            public string prijmeni;
            public string trida;
            public decimal prumer;}
        zak z1 = new zak();
        public static zak[] zaci = new zak[30];
        static void Main(string[] args)
        {
            int pocet;
            Console.WriteLine("pocet zaku ve tride ?");
            pocet = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= pocet; i++)
            {
                zaci[i].ProC = i;
                Console.WriteLine("Zadej Prijmeni "+i+". žáka:");
                zaci[i].prijmeni = Console.ReadLine();
                Console.WriteLine("Zadej jmeno zaka:");
                zaci[i].jmeno = Console.ReadLine();
                Console.WriteLine("Zadej tridu zaka:");
                zaci[i].trida = Console.ReadLine();
                Console.WriteLine("Zadej prumer zaka:");
                zaci[i].prumer = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("");
            }
            for (int i = 1; i <= pocet; i++)
            {
                Console.WriteLine(i+".zak");
                Console.WriteLine("Prijmeni: " + zaci[i].prijmeni);
                Console.WriteLine("Jmeno: " + zaci[i].jmeno);
                Console.WriteLine("Trida: " + zaci[i].trida);
                Console.WriteLine("Prumer: " + zaci[i].prumer);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

