using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP1a
{
    class Program
    {
        static void Main(string[] args)
        {
            mocnina m = new mocnina();
            Console.WriteLine("Zadej zaklad:");
            m.zaklad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej exponent:");
            m.exponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}^{1}={2}",m.zaklad,m.exponent,m.realnahodnota());
            Console.ReadKey();
        }
    }
}
