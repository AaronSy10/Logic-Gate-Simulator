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
    public partial class UserControlNOR : UserControl
    {
        public UserControlNOR()
        {
            InitializeComponent();
            txtA.Text = "0";
            txtB.Text = "0";
            txtC.Text = "1";
            chkC.Checked = true;
            richTextBox1.Text = "\tThe NOR gate is a digital logic gate with n inputs and one output, that performs the operation of the OR gate followed by the NOT gate. " +
                "NOR gate is designed by combining the OR and NOT gate. When any one of the i/ps of the NOR gate is true, then the output of the NOR gate will be false.";
        }

        private void chkA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA.Checked && chkB.Checked)
            {
                txtA.Text = "1";
                txtB.Text = "1";
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
