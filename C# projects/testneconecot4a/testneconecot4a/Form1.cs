using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testneconecot4a
{
    public partial class Form1 : Form
    {
        int[,] data = new int[3,3] { { 0, 1, 2 },{ 3, 4, 5 },{ 6, 7, 8 } };
        int[] suda = new int[3] { 0, 0, 0 };
        int soucet = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();                        
            refreshData();           
        }

        private void refreshData()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    data[i, j] = rand.Next(1, 10);
                }
            }

            checkEven();
            refreshValues();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    soucet += data[i, j];
                }
            }

            label10.Text = Convert.ToString(soucet);
            
        }

        public void checkEven()
        {
            soucet = suda[0] = suda[1] = suda[2] = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(data[i,j] % 2 == 0)
                    {
                        suda[i] += 1;
                    }
                }
            }
        }

        public void refreshValues()
        {
            label1.Text = Convert.ToString(data[0, 0]);
            label2.Text = Convert.ToString(data[0, 1]);
            label3.Text = Convert.ToString(data[0, 2]);
            label4.Text = Convert.ToString(data[1, 0]);
            label5.Text = Convert.ToString(data[1, 1]);
            label6.Text = Convert.ToString(data[1, 2]);
            label7.Text = Convert.ToString(data[2, 0]);
            label8.Text = Convert.ToString(data[2, 1]);
            label9.Text = Convert.ToString(data[2, 2]);
            soucet0.Text = Convert.ToString(suda[0]);
            soucet1.Text = Convert.ToString(suda[1]);
            soucet2.Text = Convert.ToString(suda[2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
        }

    }
}
