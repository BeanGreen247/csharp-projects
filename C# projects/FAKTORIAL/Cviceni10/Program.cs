using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            double result = 1;

            Console.Write("Zadejte číslo : ");
            n = Convert.ToDouble(Console.ReadLine());

            for (ulong i = 1; i <= n; i++)
            {
                result *= i;
            }

            Console.Write(result.ToString());
            Console.ReadKey();

        }
    }
}
