
namespace Sy_FinalProject
{
    partial class UserControlXNOR
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlXNOR));
            this.label1 = new System.Windows.Forms.Label();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnLogic = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "XNOR Gate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.BackColor = System.Drawing.SystemColors.Window;
            this.chkA.Location = new System.Drawing.Point(13, 63);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(38, 22);
            this.chkA.TabIndex = 1;
            this.chkA.Text = "A";
            this.chkA.UseVisualStyleBackColor = false;
            this.chkA.CheckedChanged += new System.EventHandler(this.chkA_CheckedChanged);
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.BackColor = System.Drawing.SystemColors.Window;
            this.chkB.Location = new System.Drawing.Point(13, 148);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(37, 22);
            this.chkB.TabIndex = 2;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = false;
            this.chkB.CheckedChanged += new System.EventHandler(this.chkB_CheckedChanged);
            // 
            // chkC
            // 
            this.chkC.AutoCheck = false;
            this.chkC.AutoSize = true;
            this.chkC.BackColor = System.Drawing.SystemColors.Window;
            this.chkC.Location = new System.Drawing.Point(324, 105);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(38, 22);
            this.chkC.TabIndex = 3;
            this.chkC.Text = "C";
            this.chkC.UseVisualStyleBackColor = false;
            this.chkC.CheckedChanged += new System.EventHandler(this.chkC_CheckedChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(57, 43);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(26, 26);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(57, 129);
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(26, 26);
            this.txtB.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(292, 85);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(26, 26);
            this.txtC.TabIndex = 6;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(597, 335);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(131, 57);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.chkC);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.chkA);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.chkB);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 219);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulate:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(412, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 219);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(7, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(314, 183);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // btnDesc
            // 
            this.btnDesc.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesc.Location = new System.Drawing.Point(45, 335);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(131, 57);
            this.btnDesc.TabIndex = 14;
            this.btnDesc.Text = "Description";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnTable
            // 
            this.btnTable.Font = new System.Drawing.Font("Lucida Fax", 9F);
            this.btnTable.Location = new System.Drawing.Point(227, 336);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(131, 57);
            this.btnTable.TabIndex = 15;
            this.btnTable.Text = "Truth Table";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnLogic
            // 
            this.btnLogic.Font = new System.Drawing.Font("Lucida Fax", 9F);
            this.btnLogic.Location = new System.Drawing.Point(412, 335);
            this.btnLogic.Name = "btnLogic";
            this.btnLogic.Size = new System.Drawing.Size(131, 57);
            this.btnLogic.TabIndex = 16;
            this.btnLogic.Text = "Logical Expression";
            this.btnLogic.UseVisualStyleBackColor = true;
            this.btnLogic.Click += new System.EventHandler(this.btnLogic_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(314, 182);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // UserControlXNOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogic);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlXNOR";
            this.Size = new System.Drawing.Size(773, 425);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnLogic;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
