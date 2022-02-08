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
    public partial class UserControlNOT : UserControl
    {
        
        public UserControlNOT()
        {
            InitializeComponent();
            txtA.Text = "0";
            txtB.Text = "1";
            chkB.Checked = true;
            richTextBox1.Text = "\tThe NOT gate is a digital logic gate with one input and one output that operates an inverter operation of the input. " +
                "The output of the NOT gate is the reverse of the input. When the input of the NOT gate is true then the output will be false and vice versa." +
                "By using this gate, we can implement NOR and NAND gates";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chkA_CheckedChanged(object sender, EventArgs e)
        {
           if(chkA.Checked)
            {
                txtA.Text = "1";
                txtB.Text = "0";
                chkB.Checked = false;
            }

            else
            {
                txtA.Text = "0";
                txtB.Text = "1";
                chkB.Checked = true;
            }
        }

        private void chkB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserControlNOT_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox2.BringToFront();
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {

            richTextBox1.Show();
            richTextBox1.BringToFront();
        }

        private void btnLogic_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox3.BringToFront();
        }
    }
}
