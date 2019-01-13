using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keygen
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Generátor hesel ke školním účtům");
            while(true)
            {
                Console.WriteLine("1. bruteforce\n2. manual\n3. automat");
                int volba = Convert.ToInt32(Console.ReadLine());
                switch (volba)
                {
                    case 1:
                        Bruteforce();
                        break;

                    case 2:
                        Keygen();
                        break;

                    case 3:
                        KeygenAuto();
                        break;
                    default:
                        break;
                }
            }        
        }

        static public void Bruteforce()
        {
            //bruteforce
            for (int i = 00000; i <= 99999; i++)
            {
                Console.WriteLine(i.ToString("00000"));
            }
            Console.ReadKey();
        }
        static public void Keygen()
        {
            Random rnd = new Random();
            int iter = 0;
            while(true)
            {
                iter++;
                Console.WriteLine("Iterace: " + iter.ToString("00000") + " | Generovaná hodnota: " + rnd.Next(0, 99999).ToString("00000"));
                Console.ReadKey();
            }
        }

        static public void WriteToFile(string[] data)
        {
            FileStream fs = new FileStream("keys.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            fs.Close();
            StreamWriter sw = new StreamWriter("keys.txt", true, Encoding.ASCII);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != null || data[i] != "" || data[i] != " " || data[i] != String.Empty)
                {
                    sw.WriteLine(data[i]);
                }               
            }           
            sw.Close();           
            
        }

        static public void KeygenAuto()
        {
            Random rnd = new Random();
            int iterations = 0, iterationsCount = 0;

            do
            {
                Console.Write("Zadejte počet iterací (max 99999): ");
                iterationsCount = Convert.ToInt32(Console.ReadLine());
            }
            while (iterationsCount > 100000 | iterationsCount < 0);

            Console.Clear();
            string[] data = new string[99999];

            for (int i = 0; i < iterationsCount; i++)            
            {
                iterations++;
                data[i] = "Iterace: " + iterations.ToString("00000") + " | Generovana hodnota: " + rnd.Next(0, 99999).ToString("00000") + "\n ";               
            }

            WriteToFile(data);
            Console.WriteLine("Hotovo.\nVýstup se nachází v souboru keys.txt");
            Console.ReadKey();
            
            Environment.Exit(0);
        }
    }
}
