using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mandelbrot_set
{
    public partial class Form1 : Form
    {
        static double currentmaxr = 0;
        static double currentminr = 0;
        static double currentmaxi = 0;
        static double currentmini = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap img = MandelbrotSet(pictureBox1, 2, -2, 2, -2);
            pictureBox1.Image = img;
        }
        static Bitmap MandelbrotSet(PictureBox pictureBox1, double maxr, double minr, double maxi, double mini)
        {
            currentmaxr = maxr;
            currentmaxi = maxi;
            currentminr = minr;
            currentmini = mini;
            Bitmap img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            double zx = 0;
            double zy = 0;
            double cx = 0;
            double cy = 0;
            double xjump = ((maxr - minr) / Convert.ToDouble(img.Width));
            double yjump = ((maxi - mini) / Convert.ToDouble(img.Height));
            double tempzx = 0;
            int loopmax = 1000;
            int loopgo = 0;
            for (int x = 0; x < img.Width; x++)
            {
                cx = (xjump * x) - Math.Abs(minr);
                for (int y = 0; y < img.Height; y++)
                {
                    zx = 0;
                    zy = 0;
                    cy = (yjump * y) - Math.Abs(mini);
                    loopgo = 0;
                    while (zx * zx + zy * zy <= 4 && loopgo < loopmax)
                    {
                        loopgo++;
                        tempzx = zx;
                        zx = (zx * zx) - (zy * zy) + cx;
                        zy = (2 * tempzx * zy) + cy;
                    }
                    if (loopgo != loopmax)
                        img.SetPixel(x, y, Color.FromArgb(loopgo % 128 * 2, loopgo % 32 * 7, loopgo % 16 * 14));
                    else
                        img.SetPixel(x, y, Color.Black);
                }
            }
            return img;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int ex = e.X;
            int ey = e.Y;
            double currentxjump = ((currentmaxr - currentminr) / Convert.ToDouble(pictureBox1.Width));
            double currentyjump = ((currentmaxi  - currentmini) / Convert.ToDouble(pictureBox1.Height));
            int zoomx = pictureBox1.Width/5 ;
            int zoomy = pictureBox1.Height/5;
            Bitmap img = MandelbrotSet(pictureBox1,((ex +zoomx) * currentxjump) -Math.Abs(currentminr) , ((ex-zoomx) * currentxjump) -Math.Abs(currentminr) , ((ey+zoomy ) * currentyjump) - Math.Abs(currentmini) , ((ey- zoomy) * currentyjump) - Math.Abs(currentmini));
            pictureBox1.Image.Dispose();
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Bitmap img = MandelbrotSet(pictureBox1, 2, -2, 2, -2);
            pictureBox1.Image.Dispose();
            pictureBox1.Image = img;
        }

        private void button2_Click(object sender, EventArgs e)
        {         
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filename = @"\Mandelbrot_set";
            string filetype = @".jpeg";
            int mone=0;       
            while (File.Exists(path + filename + mone.ToString() + filetype))
            {
                mone++;
            }    
            pictureBox1.Image.Save(path + filename + mone.ToString() + filetype);
            MessageBox.Show("Saved To Desktop");
        }
    }

}


