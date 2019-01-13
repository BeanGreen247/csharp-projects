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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3x3 trixtri = new _3x3();
            trixtri.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _6x6 sestxsest = new _6x6();
            sestxsest.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _9x9 devetxdevet = new _9x9();
            devetxdevet.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
