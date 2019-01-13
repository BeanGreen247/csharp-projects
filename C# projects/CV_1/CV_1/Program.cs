using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //cv1
            Console.WriteLine("Cviceni 1 opakovani 3.rocnik");
            //cv2
            int a, b;
            string at, bt;
            Console.WriteLine("Zadej prvni cislo:");
            a = Convert.ToInt32(at = Console.ReadLine());
            Console.WriteLine("Zadej druhe cislo:");
            b = Convert.ToInt32(bt = Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            //cv3
            double c, x, y;
            string ct, a1t, b1t;
            Console.WriteLine("Zadej hodnotu a:");
            x = Convert.ToInt32(a1t = Console.ReadLine());
            Console.WriteLine("Zadej hodnotu b:");
            y = Convert.ToInt32(b1t = Console.ReadLine());
            Console.WriteLine("Zadej hodnotu c:");
            c = Convert.ToInt32(ct = Console.ReadLine());
            Console.WriteLine("ax^2+bx+c=0");
            Console.WriteLine("{0}x^2+{1}x+{2}=0", a, b, c);
            Console.WriteLine("Zjistuji koren:");
            Console.WriteLine("============================");
            Console.WriteLine("{0}+{1}/{2}=>x1={3}", -y, Math.Sqrt(y - 4 * x * c), 2 * x, -y + Math.Sqrt((y * y) - 4 * x * c) / (2 * x));
            Console.WriteLine("{0}-{1}/{2}=>x1={3}", -y, Math.Sqrt(y - 4 * x * c), 2 * x, -y - Math.Sqrt((y * y) - 4 * x * c) / (2 * x));
            Console.WriteLine("x1={0}", -y + Math.Sqrt((y * y) - 4 * x * c) / (2 * x));
            Console.WriteLine("x2={0}", -y - Math.Sqrt((y * y) - 4 * x * c) / (2 * x));
            //cv4 FUNGUJE
            int o, p, q;
            string ot, pt, qt;
            Console.WriteLine("Zadej prvni cislo:");
            o = Convert.ToInt32(ot = Console.ReadLine());
            Console.WriteLine("Zadej druhe cislo:");
            p = Convert.ToInt32(pt = Console.ReadLine());
            Console.WriteLine("Zadej treti cislo:");
            q = Convert.ToInt32(qt = Console.ReadLine());
            Console.WriteLine("1.cislo={0}", o);
            Console.WriteLine("2.cislo={0}", p);
            Console.WriteLine("3.cislo={0}", q);
            if (o > p & o > q)
            {
                Console.WriteLine("Prvni cislo je nejvetsi");
            }
            if (p > q & p > o)
            {
                Console.WriteLine("Druhe cislo je nejvetsi");
            }
            if (q > o & q > p)
            {
                Console.WriteLine("Treti cislo je nejvetsi");
            }
            //cv5 FUNGUJE
            int d, e, f;
            string dt, et, ft;
            Console.WriteLine();
            Console.WriteLine("Zadej hodnotu a:");
            d = Convert.ToInt32(dt = Console.ReadLine());
            Console.WriteLine("Zadej hodnotu b:");
            e = Convert.ToInt32(et = Console.ReadLine());
            Console.WriteLine("Zadej hodnotu c:");
            f = Convert.ToInt32(ft = Console.ReadLine());
            Console.WriteLine("Velikosti stran trojuhelniku:");
            Console.WriteLine("a={0}", d);
            Console.WriteLine("b={0}", e);
            Console.WriteLine("c={0}", f);
            Console.WriteLine("Zjistuji zda jde sestrojit...");
            Console.WriteLine("==================================");
            if (d + e > f & e + f > d & f + d > e)
            {
                Console.WriteLine("Trojuhelnik lze sestrojit.");
            }
            else
            {
                Console.WriteLine("Trojuhelnik nelze sestrojit.");
            }
            //cv6
            Console.WriteLine("Prvocisla od 1 do 1000:");
            Console.WriteLine("");
            bool isPrime = true;
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            //konec
            Console.WriteLine("");
            Console.WriteLine("Konec...");
            Console.ReadKey();
        }
    }
}
