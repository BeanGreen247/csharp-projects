using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni13_1
{
    class Zlomek
    {
        private double citatel, jemnovatel;

        public Zlomek()
        { }

        public Zlomek(double c, double j)
        {
            citatel = c;
            jemnovatel = j;
        }

        public double Citatel
        {
            get { return citatel;}
            set { citatel = value;}
        }

        public double Jmenovatel
        {
            get { return jemnovatel;}
            set { jemnovatel = value;}
        }

        public double DejCitatel()
        {
            return Citatel;
        }
        public double DejJmenovatel()
        {
            return Jmenovatel;
        }
        public void NastavCitatel(double c)
        {
            Citatel = c;
        }

        public double RealnaHodnota()
        {
            if (jemnovatel!=0)
            {
                 return citatel / jemnovatel;
            }
            else
            {
                return 0;
            }
        }
    }
}
