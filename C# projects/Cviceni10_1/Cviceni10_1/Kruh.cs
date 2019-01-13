using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni13_1
{
    class Kruh
    {
        private double polomer;
        public Kruh()
        { }

        public Kruh(double r)
        {
            polomer = r;
        }
        public double Polomer
        {
            get
            {
                return polomer;
            }

            set
            {
                polomer = value;
            }
        }
        public double Obvod()
        {
            return 2 * Math.PI * Polomer;
        }
        public double Obsah()
        {
            return Math.PI * (Polomer * Polomer);
        }
    }
}
