
namespace Sy_FinalProject
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radNAND = new System.Windows.Forms.RadioButton();
            this.radNOR = new System.Windows.Forms.RadioButton();
            this.radXOR = new System.Windows.Forms.RadioButton();
            this.radAND = new System.Windows.Forms.RadioButton();
            this.radXNOR = new System.Windows.Forms.RadioButton();
            this.radOR = new System.Windows.Forms.RadioButton();
            this.btnSim = new System.Windows.Forms.Button();
            this.radNOT = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picXNOR = new System.Windows.Forms.PictureBox();
            this.picXOR = new System.Windows.Forms.PictureBox();
            this.picNAND = new System.Windows.Forms.PictureBox();
            this.picNOR = new System.Windows.Forms.PictureBox();
            this.picAND = new System.Windows.Forms.PictureBox();
            this.picOR = new System.Windows.Forms.PictureBox();
            this.picNOT = new System.Windows.Forms.PictureBox();
            this.userControlOR1 = new Sy_FinalProject.UserControlOR();
            this.userControlNOT1 = new Sy_FinalProject.UserControlNOT();
            this.userControlAND1 = new Sy_FinalProject.UserControlAND();
            this.userControlNOR1 = new Sy_FinalProject.UserControlNOR();
            this.userControlNAND1 = new Sy_FinalProject.UserControlNAND();
            this.userControlXOR1 = new Sy_FinalProject.UserControlXOR();
            this.userControlXNOR1 = new Sy_FinalProject.UserControlXNOR();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXNOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNAND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNOT)).BeginInit();
            this.SuspendLayout();
            // 
            // radNAND
            // 
            this.radNAND.AutoSize = true;
            this.radNAND.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNAND.Location = new System.Drawing.Point(6, 208);
            this.radNAND.Name = "radNAND";
            this.radNAND.Size = new System.Drawing.Size(114, 22);
            this.radNAND.TabIndex = 5;
            this.radNAND.TabStop = true;
            this.radNAND.Text = "NAND Gate";
            this.radNAND.UseVisualStyleBackColor = true;
            this.radNAND.CheckedChanged += new System.EventHandler(this.radNAND_CheckedChanged);
            // 
            // radNOR
            // 
            this.radNOR.AutoSize = true;
            this.radNOR.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNOR.Location = new System.Drawing.Point(7, 168);
            this.radNOR.Name = "radNOR";
            this.radNOR.Size = new System.Drawing.Size(103, 22);
            this.radNOR.TabIndex = 4;
            this.radNOR.TabStop = true;
            this.radNOR.Text = "NOR Gate";
            this.radNOR.UseVisualStyleBackColor = true;
            this.radNOR.CheckedChanged += new System.EventHandler(this.radNOR_CheckedChanged);
            // 
            // radXOR
            // 
            this.radXOR.AutoSize = true;
            this.radXOR.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radXOR.Location = new System.Drawing.Point(6, 248);
            this.radXOR.Name = "radXOR";
            this.radXOR.Size = new System.Drawing.Size(101, 22);
            this.radXOR.TabIndex = 6;
            this.radXOR.TabStop = true;
            this.radXOR.Text = "XOR Gate";
            this.radXOR.UseVisualStyleBackColor = true;
            this.radXOR.CheckedChanged += new System.EventHandler(this.radXOR_CheckedChanged);
            // 
            // radAND
            // 
            this.radAND.AutoSize = true;
            this.radAND.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAND.Location = new System.Drawing.Point(6, 128);
            this.radAND.Name = "radAND";
            this.radAND.Size = new System.Drawing.Size(102, 22);
            this.radAND.TabIndex = 3;
            this.radAND.TabStop = true;
            this.radAND.Text = "AND Gate";
            this.radAND.UseVisualStyleBackColor = true;
            this.radAND.CheckedChanged += new System.EventHandler(this.radAND_CheckedChanged);
            // 
            // radXNOR
            // 
            this.radXNOR.AutoSize = true;
            this.radXNOR.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radXNOR.Location = new System.Drawing.Point(6, 288);
            this.radXNOR.Name = "radXNOR";
            this.radXNOR.Size = new System.Drawing.Size(113, 22);
            this.radXNOR.TabIndex = 7;
            this.radXNOR.TabStop = true;
            this.radXNOR.Text = "XNOR Gate";
            this.radXNOR.UseVisualStyleBackColor = true;
            this.radXNOR.CheckedChanged += new System.EventHandler(this.radXNOR_CheckedChanged);
            // 
            // radOR
            // 
            this.radOR.AutoSize = true;
            this.radOR.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOR.Location = new System.Drawing.Point(6, 88);
            this.radOR.Name = "radOR";
            this.radOR.Size = new System.Drawing.Size(91, 22);
            this.radOR.TabIndex = 2;
            this.radOR.TabStop = true;
            this.radOR.Text = "OR Gate";
            this.radOR.UseVisualStyleBackColor = true;
            this.radOR.CheckedChanged += new System.EventHandler(this.radOR_CheckedChanged);
            // 
            // btnSim
            // 
            this.btnSim.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.Location = new System.Drawing.Point(619, 351);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(131, 57);
            this.btnSim.TabIndex = 8;
            this.btnSim.Text = "Simulate";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // radNOT
            // 
            this.radNOT.AutoSize = true;
            this.radNOT.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNOT.Location = new System.Drawing.Point(6, 48);
            this.radNOT.Name = "radNOT";
            this.radNOT.Size = new System.Drawing.Size(103, 22);
            this.radNOT.TabIndex = 1;
            this.radNOT.TabStop = true;
            this.radNOT.Text = "NOT Gate";
            this.radNOT.UseVisualStyleBackColor = true;
            this.radNOT.CheckedChanged += new System.EventHandler(this.radNOT_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logic Gate Simulator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSim);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.radNOT);
            this.groupBox1.Controls.Add(this.radNOR);
            this.groupBox1.Controls.Add(this.radOR);
            this.groupBox1.Controls.Add(this.radXNOR);
            this.groupBox1.Controls.Add(this.radAND);
            this.groupBox1.Controls.Add(this.radXOR);
            this.groupBox1.Controls.Add(this.radNAND);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 347);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logic Gates";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picXNOR);
            this.groupBox2.Controls.Add(this.picXOR);
            this.groupBox2.Controls.Add(this.picNAND);
            this.groupBox2.Controls.Add(this.picNOR);
            this.groupBox2.Controls.Add(this.picAND);
            this.groupBox2.Controls.Add(this.picOR);
            this.groupBox2.Controls.Add(this.picNOT);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(301, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 230);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview:";
            // 
            // picXNOR
            // 
            this.picXNOR.Image = ((System.Drawing.Image)(resources.GetObject("picXNOR.Image")));
            this.picXNOR.Location = new System.Drawing.Point(9, 29);
            this.picXNOR.Name = "picXNOR";
            this.picXNOR.Size = new System.Drawing.Size(469, 195);
            this.picXNOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXNOR.TabIndex = 16;
            this.picXNOR.TabStop = false;
            this.picXNOR.Visible = false;
            // 
            // picXOR
            // 
            this.picXOR.Image = ((System.Drawing.Image)(resources.GetObject("picXOR.Image")));
            this.picXOR.Location = new System.Drawing.Point(9, 29);
            this.picXOR.Name = "picXOR";
            this.picXOR.Size = new System.Drawing.Size(469, 195);
            this.picXOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXOR.TabIndex = 15;
            this.picXOR.TabStop = false;
            this.picXOR.Visible = false;
            // 
            // picNAND
            // 
            this.picNAND.Image = ((System.Drawing.Image)(resources.GetObject("picNAND.Image")));
            this.picNAND.Location = new System.Drawing.Point(9, 29);
            this.picNAND.Name = "picNAND";
            this.picNAND.Size = new System.Drawing.Size(469, 195);
            this.picNAND.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNAND.TabIndex = 14;
            this.picNAND.TabStop = false;
            this.picNAND.Visible = false;
            // 
            // picNOR
            // 
            this.picNOR.Image = ((System.Drawing.Image)(resources.GetObject("picNOR.Image")));
            this.picNOR.Location = new System.Drawing.Point(9, 29);
            this.picNOR.Name = "picNOR";
            this.picNOR.Size = new System.Drawing.Size(469, 195);
            this.picNOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNOR.TabIndex = 13;
            this.picNOR.TabStop = false;
            this.picNOR.Visible = false;
            // 
            // picAND
            // 
            this.picAND.Image = ((System.Drawing.Image)(resources.GetObject("picAND.Image")));
            this.picAND.Location = new System.Drawing.Point(9, 29);
            this.picAND.Name = "picAND";
            this.picAND.Size = new System.Drawing.Size(469, 195);
            this.picAND.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAND.TabIndex = 12;
            this.picAND.TabStop = false;
            this.picAND.Visible = false;
            // 
            // picOR
            // 
            this.picOR.Image = ((System.Drawing.Image)(resources.GetObject("picOR.Image")));
            this.picOR.Location = new System.Drawing.Point(9, 29);
            this.picOR.Name = "picOR";
            this.picOR.Size = new System.Drawing.Size(469, 195);
            this.picOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOR.TabIndex = 11;
            this.picOR.TabStop = false;
            this.picOR.Visible = false;
            // 
            // picNOT
            // 
            this.picNOT.Image = ((System.Drawing.Image)(resources.GetObject("picNOT.Image")));
            this.picNOT.Location = new System.Drawing.Point(9, 29);
            this.picNOT.Name = "picNOT";
            this.picNOT.Size = new System.Drawing.Size(469, 195);
            this.picNOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNOT.TabIndex = 10;
            this.picNOT.TabStop = false;
            this.picNOT.Visible = false;
            // 
            // userControlOR1
            // 
            this.userControlOR1.Location = new System.Drawing.Point(15, 13);
            this.userControlOR1.Name = "userControlOR1";
            this.userControlOR1.Size = new System.Drawing.Size(773, 425);
            this.userControlOR1.TabIndex = 11;
            // 
            // userControlNOT1
            // 
            this.userControlNOT1.Location = new System.Drawing.Point(15, 13);
            this.userControlNOT1.Name = "userControlNOT1";
            this.userControlNOT1.Size = new System.Drawing.Size(773, 425);
            this.userControlNOT1.TabIndex = 10;
            // 
            // userControlAND1
            // 
            this.userControlAND1.Location = new System.Drawing.Point(15, 12);
            this.userControlAND1.Name = "userControlAND1";
            this.userControlAND1.Size = new System.Drawing.Size(773, 425);
            this.userControlAND1.TabIndex = 12;
            // 
            // userControlNOR1
            // 
            this.userControlNOR1.Location = new System.Drawing.Point(13, 13);
            this.userControlNOR1.Name = "userControlNOR1";
            this.userControlNOR1.Size = new System.Drawing.Size(773, 425);
            this.userControlNOR1.TabIndex = 13;
            // 
            // userControlNAND1
            // 
            this.userControlNAND1.Location = new System.Drawing.Point(13, 13);
            this.userControlNAND1.Name = "userControlNAND1";
            this.userControlNAND1.Size = new System.Drawing.Size(773, 425);
            this.userControlNAND1.TabIndex = 14;
            // 
            // userControlXOR1
            // 
            this.userControlXOR1.Location = new System.Drawing.Point(12, 12);
            this.userControlXOR1.Name = "userControlXOR1";
            this.userControlXOR1.Size = new System.Drawing.Size(773, 425);
            this.userControlXOR1.TabIndex = 15;
            // 
            // userControlXNOR1
            // 
            this.userControlXNOR1.Location = new System.Drawing.Point(13, 13);
            this.userControlXNOR1.Name = "userControlXNOR1";
            this.userControlXNOR1.Size = new System.Drawing.Size(773, 425);
            this.userControlXNOR1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlOR1);
            this.Controls.Add(this.userControlNOT1);
            this.Controls.Add(this.userControlAND1);
            this.Controls.Add(this.userControlNOR1);
            this.Controls.Add(this.userControlNAND1);
            this.Controls.Add(this.userControlXOR1);
            this.Controls.Add(this.userControlXNOR1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logic Gate Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picXNOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNAND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNOT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControlNOT userControlNOT1;
        private UserControlOR userControlOR1;
        private System.Windows.Forms.RadioButton radNAND;
        private System.Windows.Forms.RadioButton radNOR;
        private System.Windows.Forms.RadioButton radXOR;
        private System.Windows.Forms.RadioButton radAND;
        private System.Windows.Forms.RadioButton radXNOR;
        private System.Windows.Forms.RadioButton radOR;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.RadioButton radNOT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private UserControlAND userControlAND1;
        private UserControlNOR userControlNOR1;
        private UserControlNAND userControlNAND1;
        private UserControlXOR userControlXOR1;
        private UserControlXNOR userControlXNOR1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picNOT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picXNOR;
        private System.Windows.Forms.PictureBox picXOR;
        private System.Windows.Forms.PictureBox picNAND;
        private System.Windows.Forms.PictureBox picNOR;
        private System.Windows.Forms.PictureBox picAND;
        private System.Windows.Forms.PictureBox picOR;
    }
}

