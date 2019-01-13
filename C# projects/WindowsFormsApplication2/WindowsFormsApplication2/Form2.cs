using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {

        public static Question[] quest = new Question[50];
        static int currentQuest;
        static bool firstTime = true;

        Random rand = new Random();

        public struct Question
        {
            public string questText, questA, questB, questC;
            public int goodAnswer;

            public Question(string questText, string questA, string questB, string questC, int goodAnswer) : this()
            {
                this.questText = " ";
                this.questA = " ";
                this.questB = " ";
                this.questC = " ";
                this.goodAnswer = 0;
            }
        }

        public Form2()
        {
            InitializeComponent();
            currentQuest = 0;
            RefreshWindow();

        }


        public static void GetQuestionsFromPool()
        {

                quest[0]    = new Question("Jak se jmenuje největší drak, který kdy žil?", "Neltharion/Deathwing", "Vereastrasz", "Galakrond", 2);
                quest[1]    = new Question("Kdo byl první vůdce Pravé Hordy?", "Thrall", "Grommash", "Garrosh", 1);
                quest[2]    = new Question("Který klan byl proslulým svým kovářstvím?", "Blackrock", "Frostwolf", "Bleeding Hollow", 0);
                quest[3]    = new Question("Jak se jmenuje Medivhův kanonický syn?", "Garren", "Med'an", "Llane", 1);
                quest[4]    = new Question("Jaké je celé jméno Wolfhearta?", "Sir Genn Greymane", "Rend Blackhand", "King Varian Wrynn", 2);
                quest[5]    = new Question("Která událost měla za následek vpád orků na Azeroth?", "Nedostatek surovin na Draenoru", "Nedostatek nepřátel k boji", "Příchodů eredarů na Draenor", 1);
                quest[6]    = new Question("Jak se jmenuje legendární dýka Garony Halfforcen?", "Kingsbane", "Kingslayer", "Queensbane", 0);
                quest[7]    = new Question("Jak se jmenuje legendární zbraň, kterou momentálně drží Arcimág Khadgar?", "Atiesh, the Greatstaff of the Guardian", "Thunderfury, the Blessed Blade of the Windseeker", "Sulfuras, the Hand of Ragnaros", 0);
                quest[8]    = new Question("Jak se jmenuje otec Jainy?", "Othmar Garithos", "Daelin Proudmoore", "Derek Proudmoore", 1);
                quest[9]    = new Question("Kdo to byl Varimathras?", "Pán Děsu, Mal'ganisův poskok", "Lord-Velitel Nagské Armády", "Jeden z dračích aspektů", 0);
                quest[10]   = new Question("Který z následujících draků NENÍ Dračím Aspektem?", "Alexstrasza", "Nozdormu", "Sinestra", 2);
                quest[11]   = new Question("Jak se jmenoval nekromancer, který mohl za Zhoubu?", "Darkmaster Gandling", "Mal'ganis", "Kel'thuzad", 2);
                quest[12]   = new Question("Které povolání/classa není dostupná pro Noční Elfy?", "Paladin", "Priest", "Warrior", 0);
                quest[13]   = new Question("Jak se jmenuje Draeneiská úniková loď?", "Shattrath", "Mac'Aree", "Exodar", 2);
                quest[14]   = new Question("Kde se nachází 'Cleft of Shadow'?", " ", " ", " ", 1);
                quest[15]   = new Question(" ", " ", " ", " ", 2);

        }

        public void RefreshWindow()
        {
            label2.Text = Convert.ToString(currentQuest + 1);
            label3.Text = quest[currentQuest].questText;
        }

        public static int GetCurrentQuest()
        {
            if (firstTime)
            {
                currentQuest = 0;
                GetQuestionsFromPool();
                return currentQuest;
            }
            else
            {
                currentQuest++;              
                return currentQuest;
            }
        }

    }
}
