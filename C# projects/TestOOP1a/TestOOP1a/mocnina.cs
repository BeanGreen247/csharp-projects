using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP1a
{
    class mocnina
    {
        public int zaklad, exponent;

        public mocnina()
        {
        }

        public mocnina(int zak, int expo)
        {
            zaklad =zak;
            exponent =expo;
        }
        public double realnahodnota()
        {
            return Math.Pow(zaklad, exponent);
        }
    }
}
