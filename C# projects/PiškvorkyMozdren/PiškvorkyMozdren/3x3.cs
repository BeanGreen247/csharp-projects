using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiškvorkyMozdren
{
    public partial class _3x3 : Form
    {
        string o ="o.png";
        string x ="x.png";
        public _3x3()
        {
            InitializeComponent();
            label2.Text = "Hrac 1";
            pictureBox11.Image = Image.FromFile("pozadi.png");
            if (label2.Text=="Hrac 1")
            {
                player1.Image = Image.FromFile(o);
            }
            else if (label2.Text == "Hrac 2")
            {
                player1.Image = Image.FromFile(x);
            }
    }
        public void hrac1()
        {
            label2.Text = "Hrac 2";
            player1.Image = Image.FromFile(x);
        }
        public void hrac2()
        {
            label2.Text = "Hrac 1";
            player1.Image = Image.FromFile(o);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Hrac 1")
            {
                pictureBox1.Image = Image.FromFile(o);
                hrac1();
            }
            else if (label2.Text == "Hrac 2")
            {
                pictureBox1.Image = Image.FromFile(x);
                hrac2();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Hrac 1")
            {
                pictureBox2.Image = Image.FromFile(o);
                hrac1();
            }
            else if (label2.Text == "Hrac 2")
            {
                pictureBox2.Image = Image.FromFile(x);
                hrac2();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Hrac 1")
            {
                pictureBox3.Image = Image.FromFile(o);
                hrac1();
            }
            else if (label2.Text == "Hrac 2")
            {
                pictureBox3.Image = Image.FromFile(x);
                hrac2();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Hrac 1")
            {
                pictureBox6.Image = Image.FromFile(o);
                hrac1();
            }
            else if (label2.Text == "Hrac 2")
            {
                pictureBox6.Image = Image.FromFile(x);
                hrac2();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Hrac 1")
            {
                pictureBox5.Image = Image.FromFile(o);
                hrac1();
            }
            else if (label2.Text == "Hrac 2")
            {
                pictureBox5.Image = Image.FromFile(x);
                hrac2();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Hrac 1")
            {
                pictureBox4.Image = Image.FromFile(o);
                hrac1();
            }
            else if (label2.Text == "Hrac 2")
            {
                pictureBox4.Image = Image.FromFile(x);
                hrac2();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Hrac 1")
            {
                pictureBox9.Image = Image.FromFile(o);
                hrac1();
            }
            else if (label2.Text == "Hrac 2")
            {
                pictureBox9.Image = Image.FromFile(x);
                hrac2();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Hrac 1")
            {
                pictureBox8.Image = Image.FromFile(o);
                hrac1();
            }
            else if (label2.Text == "Hrac 2")
            {
                pictureBox8.Image = Image.FromFile(x);
                hrac2();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Hrac 1")
            {
                pictureBox7.Image = Image.FromFile(o);
                hrac1();
            }
            else if (label2.Text == "Hrac 2")
            {
                pictureBox7.Image = Image.FromFile(x);
                hrac2();
            }
        }
        public void rada1x()
        {
            if (pictureBox1.Image==Image.FromFile(x)& pictureBox2.Image == Image.FromFile(x)& pictureBox3.Image == Image.FromFile(x))
            {
                MessageBox.Show("Konec","Vyhrává hrac 2");
            }
        }
        public void rada1o()
        {
            if (pictureBox1.Image == Image.FromFile(o) & pictureBox2.Image == Image.FromFile(o) & pictureBox3.Image == Image.FromFile(o))
            {
                MessageBox.Show("Konec", "Vyhrává hrac 1");
            }
        }
    }
}
