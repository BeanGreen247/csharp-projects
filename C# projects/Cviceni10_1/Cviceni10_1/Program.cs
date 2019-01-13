using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Zlomek z1 = new Zlomek();
              Zlomek z2 = new Zlomek(2,3);
              Zlomek z3 = new Zlomek();
              z1.Citatel =3;
              z1.Jmenovatel = 5;

              Console.Write("Zadej citatel zlomku: ");
              z3.Citatel =Convert.ToDouble(Console.ReadLine());
              Console.Write("Zadej jmenovatel zlomku: ");
              z3.Jmenovatel = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("Realna hodnota z1 ={0}",z1.RealnaHodnota().ToString());
              Console.WriteLine("Realna hodnota z2 ={0}",z2.RealnaHodnota().ToString());
              Console.WriteLine("Realna hodnota z3 ={0}",z3.RealnaHodnota().ToString());
              */
            Kruh k1 = new Kruh(10);
            Kruh k2 = new Kruh();
            Console.WriteLine("Zadany polomer kruhu k1: 10");
            Console.Write("Zadej polomer kruhu k2: ");
            k2.Polomer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Obvod kruznice k1={0}", k1.Obvod());
            Console.WriteLine("Obvod kruznice k2={0}", k2.Obvod());
            Console.WriteLine("Obsah kruznice k1={0}", k1.Obsah());
            Console.WriteLine("Obsah kruznice k2={0}", k2.Obsah());
            Console.ReadKey();
        }
    }
}
