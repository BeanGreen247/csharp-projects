using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_cvic6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct student
        {
            public int cislo, dtm_naroz;
            public string jmeno, prijmeni, adresa;
        }

        public void button_uloz_Click(object sender, EventArgs e)
        {
            student[] studenti= new student[4];
            studenti[0].cislo = Convert.ToInt32(textBox_cislo.Text);
            studenti[1].jmeno = Convert.ToString(TextBox_jmeno.Text);
            studenti[2].prijmeni = Convert.ToString(TextBox_prijmeni.Text);
            studenti[3].adresa = Convert.ToString(TextBox_adresa.Text);
            
        }

        public void button_narozen_Click(object sender, EventArgs e)
        {
            string studentc, studentj, studentp, studenta,studentr;
            student[] student2 = new student[5];
            student2[0].cislo = Convert.ToInt32(textBox_cislo.Text);
            student2[1].jmeno = Convert.ToString(TextBox_jmeno.Text);
            student2[2].prijmeni = Convert.ToString(TextBox_prijmeni.Text);
            student2[3].prijmeni = Convert.ToString(TextBox_adresa.Text);
            studentc =textBox_cislo.Text;
            studentj = TextBox_jmeno.Text;
            studentp = TextBox_prijmeni.Text;
            studenta = TextBox_adresa.Text; 
            textBox_veta.Text ="Student"+" "+ studentj+" "+studentp+" ma cislo "+studentc+" a pochazi z mesta "+studenta+".";
        }
    }
}
