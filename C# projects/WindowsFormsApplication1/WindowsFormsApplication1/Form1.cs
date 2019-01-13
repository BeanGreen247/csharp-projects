using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pole = new int[12];
            pole[0] = 5;
            pole[1] = -6;
            pole[2] = 12;
            pole[3] = 4;
            pole[4] = 0;
            pole[5] = -3;
            pole[6] = 7;
            pole[7] = 8;
            pole[8] = 0;
            pole[9] = -6;
            pole[10] = 0;
            pole[11] = 2;
            textBox1.Text = Convert.ToString(pole[0]);
            textBox2.Text = Convert.ToString(pole[1]);
            textBox3.Text = Convert.ToString(pole[2]);
            textBox4.Text = Convert.ToString(pole[3]);
            textBox5.Text = Convert.ToString(pole[4]);
            textBox6.Text = Convert.ToString(pole[5]);
            textBox7.Text = Convert.ToString(pole[6]);
            textBox8.Text = Convert.ToString(pole[7]);
            textBox9.Text = Convert.ToString(pole[8]);
            textBox10.Text = Convert.ToString(pole[9]);
            textBox11.Text = Convert.ToString(pole[10]);
            textBox12.Text = Convert.ToString(pole[11]);
            textBox13.Text = Convert.ToString(pole.GetValue(8));
            textBox14.Text = "1";
            textBox15.Text = Convert.ToString(pole.GetValue(11));
            textBox16.Text = Convert.ToString(pole.Average());
        }
    }
}
