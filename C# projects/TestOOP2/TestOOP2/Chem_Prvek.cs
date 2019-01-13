using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2
{
    public class Chem_Prvek
    {
        string znacka;
        int p_cislo;
        int n_cislo;

        public string Znacka
        {
            get
            {
                return znacka;
            }

            set
            {
                znacka = value;
            }
        }

        public int P_cislo
        {
            get
            {
                return p_cislo;
            }

            set
            {
                p_cislo = value;
            }
        }

        public int N_cislo
        {
            get
            {
                return n_cislo;
            }

            set
            {
                n_cislo = value;
            }
        }

        public Chem_Prvek(string znacka, int p_cislo, int n_cislo)
        {
            this.Znacka = znacka;
            this.P_cislo = p_cislo;
            this.n_cislo = n_cislo;
        }

        public void info()
        {
            Console.WriteLine("\n\nZnačka prvku: " + Znacka +
                "\nPočet protonů: " + P_cislo + "\nPočet neutronů: "
                + n_cislo / 2 + "\nPočet elektronů: " + P_cislo);
        }
    }
}
