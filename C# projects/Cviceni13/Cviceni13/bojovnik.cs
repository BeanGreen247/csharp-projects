using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni13
{
    class Bojovnik
    {
        private string jmeno;
        private int sila, obratnost, pocet_zivotu;

        public Bojovnik()
        {

        }

        public Bojovnik(string jm, int s, int o, int pocZ)
        {
            jmeno = jm;
            sila = s;
            obratnost = o;
            pocet_zivotu = pocZ;
        }

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public int Obratnost
        {
            get { return obratnost;}
            set { obratnost = value;}
        }

        public int Pocet_zivotu
        {
            get { return pocet_zivotu;}
            set { pocet_zivotu = value;}
        }

        public int Sila
        {
            get { return sila;}
            set { sila = value;}
        }
        public void NastavPocZivotu(int poc)
        {
            pocet_zivotu = poc;
        }
        public void leceni()
        {

        }
        public void Bojuj()
        {

        }
    }
    
}
