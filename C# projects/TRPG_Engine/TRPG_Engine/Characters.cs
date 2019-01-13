using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_Engine
{
    public class Characters
    {
        public int id = 0;

        public string name = null;
        public int str = 0;
        public int wis = 0;
        public int agi = 0;

        public int hp = 0;
        public int mana = 0;

        public int clss = 0;

        public static float hpmult = 0.6f;
        public static float mpmult = 0.5f;

        public Characters(int id, string name, int str, int wis, int agi)
        {
            this.id = id;
            this.name = name;
            this.str = str;
            this.wis = wis;
            this.agi = agi;

            hp = Convert.ToInt32(str * hpmult);
            mana = Convert.ToInt32(wis * mpmult);

            if (str > agi && str > wis)
                clss = 0;
            else if (agi > str && agi > wis)
               clss = 1;
            else if (wis > str && wis > agi)
                clss = 2;
            else if (wis == str && str == agi)
                clss = 0;
            else
                clss = 0;
        }

        
    }   
}
