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
    public partial class UserControlXNOR : UserControl
    {
        public UserControlXNOR()
        {
            InitializeComponent();
            txtA.Text = "0";
            txtB.Text = "0";
            txtC.Text = "1";
            chkC.Checked = true;
            richTextBox1.Text = "\tThe Exclusive-NOR gate is a digital logic gate with two inputs and one output. " +
                "The short form of this gate is Ex-NOR. It performs based on the operation of the NOR gate. " +
                "When both the inputs of this gate are high, then the output of the EX-NOR gate will be high. But, if any one of the inputs is high (but not both), then the output will be low. ";
        }

        private void chkA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA.Checked && chkB.Checked)
            {
                txtA.Text = "1";
                txtB.Text = "1";
                chkC.Checked = true;
                txtC.Text = "1";
            }

            else if (chkA.Checked == false && chkB.Checked)
            {
                txtA.Text = "0";
                txtB.Text = "1";
                chkC.Checked = false;
                txtC.Text = "0";
            }

            else if (chkB.Checked == false && chkA.Checked)
            {
                txtA.Text = "1";
                txtB.Text = "0";
                chkC.Checked = false;
                txtC.Text = "0";
            }

            else
            {
                txtA.Text = "0";
                txtB.Text = "0";
                chkC.Checked = true;
                txtC.Text = "1";
            }
        }

        private void chkB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB.Checked && chkA.Checked)
            {
                txtA.Text = "1";
                txtB.Text = "1";
                chkC.Checked = true;
                txtC.Text = "1";
            }
            else if (chkB.Checked == false && chkA.Checked)
            {
                txtA.Text = "1";
                txtB.Text = "0";
                chkC.Checked = false;
                txtC.Text = "0";
            }

            else if (chkA.Checked == false && chkB.Checked)
            {
                txtA.Text = "0";
                txtB.Text = "1";
                chkC.Checked = false;
                txtC.Text = "0";
            }
            else
            {
                txtA.Text = "0";
                txtB.Text = "0";
                chkC.Checked = true;
                txtC.Text = "1";
            }
        }

        private void chkC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            richTextBox1.Show();
            richTextBox1.BringToFront();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox2.BringToFront();
        }

        private void btnLogic_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox3.BringToFront();
        }
    }
}
