using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TRPG_Engine
{
    class Program
    {
        public static List<Characters> Character = new List<Characters>();
        

        public static string GetStringClss(int clss)
        {           
            if (clss == 1)
                return "Rogue";
            if (clss == 2)
                return "Wizard";
            else
                return "Warrior";
        }


        static int InitDB()
        {
            Character.Add(new Characters(0, "Player", 3, 3, 3));
            Character.Add(new Characters(1, "Rat", 2, 1, 1));
            Character.Add(new Characters(2, "Bear", 6, 3, 1));
            Character.Add(new Characters(3, "Bandit", 1, 1, 5));
            Character.Add(new Characters(4, "Bandit Healer", 1, 4, 1));
            Character.Add(new Characters(5, "Bandit Boss", 10, 10, 10));
            return 0;           
        }

        static void TestDB()
        {
            try
            {
                foreach (Characters id in Character)
                {
                    Console.WriteLine(
                           id.name + "\n" +
                           id.str + " | " +
                           id.wis + " | " +
                           id.agi + " | " +
                           id.hp + " hp | " +
                           id.mana + " mp | " +
                           GetStringClss(id.clss)
                           );
                }
            }
            catch (Exception)
            {
                //let it just fail silently
            }
        }

        static void GameOver()
        {
            Console.WriteLine("\n\n\n YOU DIED\n\n\n PRESS ANY KEY TO EXIT");

            Console.ReadKey();
            Environment.Exit(0);
        }

        static bool DetermineTurns(Characters a, Characters b)
        {
            if (a.agi < b.agi)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void FightRound(Characters a, Characters b)
        {
            bool afirst = DetermineTurns(a, b);

            if (afirst)
            {
                int dmg = Convert.ToInt32(a.str * 0.3);
                b.hp -= dmg;
                Console.WriteLine(b.name + " takes " + dmg + " damage.");

                if (b.hp > 0)
                {
                    dmg = Convert.ToInt32(b.str * 0.3);
                    a.hp -= dmg;
                    Console.WriteLine(a.name + " takes " + dmg + " damage.");
                }
            }
            else
            {
                int dmg = Convert.ToInt32(b.str * 0.3);
                a.hp -= dmg;
                Console.WriteLine(a.name + " takes " + dmg + " damage.");

                if (a.hp > 0)
                {
                    dmg = Convert.ToInt32(a.str * 0.3);
                    b.hp -= dmg;
                    Console.WriteLine(b.name + " takes " + dmg + " damage.");
                }
            }

        }

        static void Fight(Characters a, Characters b)
        {
            Console.WriteLine("\n\n" + a.name + " approaches " + b.name + "!");

            while (a.hp > 0 && b.hp > 0)
            {
                FightRound(a,b);
            }

            if (a.hp <= 0)
            {
                GameOver();
            }
            else if (b.hp <= 0)
            {
                Console.WriteLine(a.name + " won the fight. " + b.name + " was defeated.");
            }         
        }

        static void Main(string[] args)
        {
            InitDB();

            TestDB();
            Fight(Character[0], Character[1]);
            Fight(Character[0], Character[2]);
            Fight(Character[0], Character[3]);

            while (true)
            {

            }
        }
    }
}

