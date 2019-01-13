using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetLabGUI
{
    public partial class Form1 : Form
    {
        public int currentplanet = 0;

        public string[] plname = new string[8] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
        public string[] plarea = new string[8] { "0.147", "0.902", "1", "0.284", "120", "83.7", "15.8", "14.9" };
        public string[] plradius = new string[8] { "2439.7", "6051.85", "6378", "3396.2", "71 492", "60 268", "25 559", "24 764" };
        public string[] plmass = new string[8] { "0.055", "0.815", "1", "0.531", "120.5", "95.162", "14.536", "17.1" };
        public string[] pldens = new string[8] { "5.427", "5.204", "5.515", "3.933", "1.326", "0.6873", "1.270", "1.638" };
        public string[] plsundist = new string[8] { "0.307", "0.718", "1", "1.381", "4.951", "9.020", "18.286", "29.766" };
        public string[] platmo = new string[8] { "0", "9 321", "100", "0.9", "110", "140", "120", ">>100" };
        public string[] plshi = new string[8] { "", "", "", "", "", "", "", "" };

        public Form1()
        {
            InitializeComponent();
            RefreshValues();
        }

        private void RefreshValues()
        {
            planetName.Text = plname[currentplanet];
            planetArea.Text = plarea[currentplanet] + " Earth";
            planetRadius.Text = plradius[currentplanet] + " km";
            planetMass.Text = plmass[currentplanet] + " Earth";
            planetDensity.Text = pldens[currentplanet] + " g/cm³";
            planetSunDist.Text = plsundist[currentplanet] + " AU";
            planetAtmo.Text = platmo[currentplanet] + " kPa";
            planetSHI.Text = plshi[currentplanet];
        }

        private void btMercury_Click(object sender, EventArgs e)
        {
            currentplanet = 0;
            RefreshValues();
        }

        private void btVenus_Click(object sender, EventArgs e)
        {
            currentplanet = 1;
            RefreshValues();
        }

        private void btEarth_Click(object sender, EventArgs e)
        {
            currentplanet = 2;
            RefreshValues();
        }

        private void btMars_Click(object sender, EventArgs e)
        {
            currentplanet = 3;
            RefreshValues();
        }

        private void btJupiter_Click(object sender, EventArgs e)
        {
            currentplanet = 4;
            RefreshValues();
        }

        private void btSaturn_Click(object sender, EventArgs e)
        {
            currentplanet = 5;
            RefreshValues();
        }

        private void btUranus_Click(object sender, EventArgs e)
        {
            currentplanet = 6;
            RefreshValues();
        }

        private void btNeptune_Click(object sender, EventArgs e)
        {
            currentplanet = 7;
            RefreshValues();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit?", "Planetlab", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Application.Exit();
                }
                catch
                {
                    Console.Write("Error with exiting application, shutting down the process.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
