using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test001
{
    class Program
    {
        public static int count;

        static void Main(string[] args)
        {
            int v;
            

            for (int i = 100; i <= 500; i++)
            {
                if (i % 3 == 1)
                {                  
                    if (i % 4 == 0)
                    {
                        Console.Write(i +  ", ");
                        count++;
                    }
                }
            }
            Console.WriteLine(";\n\nPočet nalezených hodnot: " + count);
            Console.ReadKey();
        }
    }
}
