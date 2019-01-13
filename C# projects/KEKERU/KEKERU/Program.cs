using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEKERU
{
    class Program
    {
        static void Main(string[] args)
        {
            int zak, exp;

                Console.Write("Zadejte základ: ");
                zak = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zadejte exponenta: ");
                exp = Convert.ToInt32(Console.ReadLine());
                Mocnina m = new Mocnina(zak, exp);

                // Console.WriteLine("Byla zadána špatná hodnota. Aplikace bude nyní ukončena.");
                // Environment.Exit(0);

                Console.Write("Zadejte základ 2: ");
                zak = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zadejte exponenta 2: ");
                exp = Convert.ToInt32(Console.ReadLine());
                Mocnina f = new Mocnina(zak, exp);

            

            Console.WriteLine("Realna hodnota 1 je: " + m.RealnaHodnota() + "\nRealna hodnota 2 je: " + f.RealnaHodnota());
            Console.ReadKey();
        }
    }
}
