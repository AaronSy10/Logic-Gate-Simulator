using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sy_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            if (radNOT.Checked)
            {
                userControlNOT1.Show();
                userControlNOT1.BringToFront();
                picNOT.Visible = true;
            }

            else if (radOR.Checked)
            {
                userControlOR1.Show();
                userControlOR1.BringToFront();

            }

            else if (radAND.Checked)
            {
                userControlAND1.Show();
                userControlAND1.BringToFront();
            }

            else if (radNOR.Checked)
            {
                userControlNOR1.Show();
                userControlNOR1.BringToFront();
            }

            else if (radNAND.Checked)
            {
                userControlNAND1.Show();
                userControlNAND1.BringToFront();
            }
            else if (radXOR.Checked)
            {
                userControlXOR1.Show();
                userControlXOR1.BringToFront();
            }

            else if (radXNOR.Checked)
            {
                userControlXNOR1.Show();
                userControlXNOR1.BringToFront();
            }

            else
            {
                string message = "Please select a logic gate";
                MessageBox.Show(message);
            }
        }

        private void userControlNOT1_Load(object sender, EventArgs e)
        {
            
        }

        private void userControlAND1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radNOT_CheckedChanged(object sender, EventArgs e)
        {
            if (radNOT.Checked)
            {
                picNOT.Visible = true;
            }
            else
            {
                picNOT.Visible = false;
            }

        }

        private void radOR_CheckedChanged(object sender, EventArgs e)
        {
            if (radOR.Checked)
            {
                picOR.Visible = true;
            }
            else
            {
                picOR.Visible = false;
            }
        }

        private void radAND_CheckedChanged(object sender, EventArgs e)
        {
            if (radAND.Checked)
            {
                picAND.Visible = true;
            }
            else
            {
                picAND.Visible = false;
            }
        }

        private void radNOR_CheckedChanged(object sender, EventArgs e)
        {
            if (radNOR.Checked)
            {
                picNOR.Visible = true;
            }
            else
            {
                picNOR.Visible = false;
            }
        }

        private void radNAND_CheckedChanged(object sender, EventArgs e)
        {
            if (radNAND.Checked)
            {
                picNAND.Visible = true;
            }
            else
            {
                picNAND.Visible = false;
            }
        }

        private void radXOR_CheckedChanged(object sender, EventArgs e)
        {
            if (radXOR.Checked)
            {
                picXOR.Visible = true;
            }
            else
            {
                picXOR.Visible = false;
            }
        }

        private void radXNOR_CheckedChanged(object sender, EventArgs e)
        {
            if (radXNOR.Checked)
            {
                picXNOR.Visible = true;
            }
            else
            {
                picXNOR.Visible = false;
            }
        }
    }
}
