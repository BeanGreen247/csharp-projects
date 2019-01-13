using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEKERU
{
    class Mocnina
    {

        public int zaklad, exponent;

        public Mocnina(int zak, int exp)
        {
            zaklad = zak;
            exponent = exp;
        }

        public double RealnaHodnota()
        {
            return Math.Pow(this.zaklad, this.exponent);
        }
    }
}
