using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testOOP2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Zlomek zl = new Zlomek();
            Zlomek1 zl1 = new Zlomek1();
            Console.WriteLine("Zadej citatele prvniho zlomku:");
            zl.citatel1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej jmenovatele prvniho zlomku:");
            zl.jmenovatel1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vysledek prvniho zlomku: {0}",zl.zlomek());
            Console.WriteLine("Zadej citatele druheho zlomku:");
            zl1.citatel1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej jmenovatel druheho zlomku:");
            zl1.jmenovatel1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vysledek druheho zlomku: {0}", zl1.zlomek());
            Console.WriteLine("Soucet obou zlomku: {0}", zl.zlomek()+zl1.zlomek());
            Console.WriteLine("Rozdil obou zlomku: {0}", zl.zlomek()-zl1.zlomek());
            Console.WriteLine("Soucin obou zlomku: {0}",zl.zlomek()*zl1.zlomek());
            Console.WriteLine("Podil obou zlomku: {0}", zl.zlomek()/zl1.zlomek());
            Console.ReadKey();

        }
    }
}
