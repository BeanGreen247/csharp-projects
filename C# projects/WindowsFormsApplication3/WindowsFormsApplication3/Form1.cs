using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        double a, b, c, r, v,pi = 3.14,s;
        string vys;
        public int objekt;

        public void button5_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            hodnotastranac_textbox.Visible = false;
            polomerr_textbox.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            objekt = 1;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (objekt==1)
            {
                obvod_obdelnik();
            }
            if (objekt==2)
            {
                obvod_kruh();
            }
            if (objekt == 3)
            {
                obvod_trojuhelnik();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        public void prevodab()
        {
            a = Convert.ToInt32(hodnotastranaa_textbox.Text);
            b = Convert.ToInt32(hodnotastranab_textbox.Text); 
        }
        public void prevodabc()
        {
            a = Convert.ToInt32(hodnotastranaa_textbox.Text);
            b = Convert.ToInt32(hodnotastranab_textbox.Text);
            c = Convert.ToInt32(hodnotastranac_textbox.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (objekt == 1)
            {
                obsah_obdelnik();
            }
            if (objekt == 2)
            {
                obsah_kruh();
            }
            if (objekt == 3)
            {
                obsah_trojuhelnik();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = false;
            hodnotastranac_textbox.Visible = false;
            polomerr_textbox.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            objekt=2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = true;
            hodnotastranac_textbox.Visible = true;
            polomerr_textbox.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            objekt = 3;
        }

        public void prevodr()
        {
            r = Convert.ToInt32(polomerr_textbox.Text);
        }

        public void obvod_obdelnik()
        {
            prevodab();
            v = a + b;
            vys=Convert.ToString(v);
            label5.Text = vys;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = true;
            hodnotastranac_textbox.Visible = true;
            polomerr_textbox.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            objekt = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (objekt == 4)
            {
                kvadr_obsah();
            }
        }

        public void obsah_obdelnik()
        {
            prevodab();
            v = a * b;
            vys = Convert.ToString(v);
            label6.Text = vys;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (objekt == 4)
            {
                kvadr_objem();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            hodnotastranaa_textbox.Visible = true;
            hodnotastranab_textbox.Visible = true;
            hodnotastranac_textbox.Visible = true;
            polomerr_textbox.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        public void obvod_kruh()
        {
            prevodr();
            v =2 * pi * r;
            vys = Convert.ToString(v);
            label5.Text = vys;
        }
        public void obsah_kruh()
        {
            prevodr();
            v = pi * (r*r);
            vys = Convert.ToString(v);
            label6.Text = vys;
        }
        public void obvod_trojuhelnik()
        {
            prevodabc();
            v = a + b + c;
            vys = Convert.ToString(v);
            label5.Text = vys;
        }
        public void obsah_trojuhelnik()
        {
            prevodabc();
            s =(a + b + c) / 2;
            v = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            vys = Convert.ToString(v);
            label6.Text = vys;
        }
        public void kvadr_obsah()
        {
            prevodabc();
            v =2*((a*b)+(a*c)+(b*c));
            vys = Convert.ToString(v);
            label7.Text = vys;
        }
        public void kvadr_objem()
        {
            prevodabc();
            v = a*b*c;
            vys = Convert.ToString(v);
            label8.Text = vys;
        }
    }
}
