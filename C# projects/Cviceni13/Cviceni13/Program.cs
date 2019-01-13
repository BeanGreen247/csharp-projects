using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni13
{
    class Program
    {
        static void Main(string[] args)
        {
            Bojovnik bojovnik1 = new Bojovnik("Karlos",10,5,3);
            Bojovnik bojovnik2 = new Bojovnik("Petr",10,3,3);

            bojovnik1.Bojuj();
            bojovnik2.Bojuj();

            bojovnik1.NastavPocZivotu(3);
        }
    }
}
