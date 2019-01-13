using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektmozdren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyberte Velikost hraciho pole" +"\n"+"1)3x3" + "\n" + "2)6x6" + "\n" + "3)9x9");
            int volba1;
            Console.Write("Volba: ");
            volba1 = Convert.ToInt32(Console.ReadLine());
            switch (volba1)
            {
                case 1:
                Console.WriteLine("__|__|__" + "\n"+"__|__|__"+"\n"+"  |  |  ");
                break;
                case 2:
                Console.WriteLine("__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__" + "\n" + "  |  |  |  |  |  ");
                break;
                case 3:
                Console.WriteLine("__|__|__|__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__|__|__|__" + "\n" + "__|__|__|__|__|__|__|__|__" + "\n" + "  |  |  |  |  |  |  |  |  ");
                break;
            }


            Console.ReadKey();
        }
    }
}
