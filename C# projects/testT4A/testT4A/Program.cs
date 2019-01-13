using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testT4A
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1,c2;
            string c1t, c2t;
            Console.WriteLine("Zadej prvni cislo");
            c1= Convert.ToInt32(c1t=Console.ReadLine());
            Console.WriteLine("Zadej druhe cislo");
            c2 = Convert.ToInt32(c2t = Console.ReadLine());
            Console.WriteLine("=========Provadim Vypocet=============");
            if (c1!=0&&c2!=0)
            {
                Console.WriteLine("{0}+{1}={2}",c1,c2,c1+c2);
                Console.WriteLine("{0}-{1}={2}",c1,c2,c1-c2);
                Console.WriteLine("{0}*{1}={2}",c1,c2,c1*c2);
                Console.WriteLine("{0}/{1}={2}",c1,c2,c1/c2);
                Console.WriteLine("=========Vypocet Proveden=============");
            }
            else
            {
                Console.WriteLine("!!!!! NULOU NELZE DĚLIT!!!!!"+"\n"+"Proto neprovedu vypocet!"+"\n"+ "=========Vypocet neproveden===========");
            }
            Console.WriteLine("Konec...");
            Console.ReadKey();
        }
    }
}
