using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            int input2, input3;

            Chem_Prvek vodik = new Chem_Prvek("H", 1, 1);

            Console.WriteLine("Zadejte chemickou značku:");
            input1 = Console.ReadLine();
            Console.WriteLine("Zadejte protonové číslo:");
            input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte neutronové číslo:");
            input3 = Convert.ToInt32(Console.ReadLine());

            Chem_Prvek userprvek = new Chem_Prvek(input1, input2, input3);
            vodik.info();
            userprvek.info();
            Console.ReadKey();
        }
    }
}
