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
    public partial class UserControlAND : UserControl
    {
        public UserControlAND()
        {
            InitializeComponent();
            txtA.Text = "0";
            txtB.Text = "0";
            txtC.Text = "0";
            richTextBox1.Text = "\tThe AND gate is a digital logic gate with ‘n’ i/ps one o/p, which performs logical conjunction based on the combinations of its inputs. The output of this gate is true only when all the inputs are true." +
                " When one or more inputs of the AND gate’s i/ps are false, then only the output of the AND gate is false.";
        }


        private void chkA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB.Checked && chkA.Checked)
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
                chkC.Checked = false;
                txtC.Text = "0";
            }
        }

        private void chkB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA.Checked && chkB.Checked)
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
                chkC.Checked = false;
                txtC.Text = "0";
            }
        }

        private void chkC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UserControlAND_Load(object sender, EventArgs e)
        {

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
