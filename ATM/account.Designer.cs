namespace ATM
{
    partial class account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AccNametb = new System.Windows.Forms.TextBox();
            this.AccNumtb = new System.Windows.Forms.TextBox();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.FaNametb = new System.Windows.Forms.TextBox();
            this.pintb = new System.Windows.Forms.TextBox();
            this.phonetb = new System.Windows.Forms.TextBox();
            this.occupationtb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.educationtb = new System.Windows.Forms.ComboBox();
            this.dobdatetb = new System.Windows.Forms.DateTimePicker();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 55);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(656, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "ACC NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(23, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(366, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "OCCUPATION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label6.ForeColor = System.Drawing.Color.MediumPurple;
            this.label6.Location = new System.Drawing.Point(366, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "EDUCATION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label7.ForeColor = System.Drawing.Color.MediumPurple;
            this.label7.Location = new System.Drawing.Point(366, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "PIN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label8.ForeColor = System.Drawing.Color.MediumPurple;
            this.label8.Location = new System.Drawing.Point(366, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "MOBILE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label10.ForeColor = System.Drawing.Color.MediumPurple;
            this.label10.Location = new System.Drawing.Point(23, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "ADDRESS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label11.ForeColor = System.Drawing.Color.MediumPurple;
            this.label11.Location = new System.Drawing.Point(23, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "FNAME";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label12.ForeColor = System.Drawing.Color.MediumPurple;
            this.label12.Location = new System.Drawing.Point(366, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "DOB";
            // 
            // AccNametb
            // 
            this.AccNametb.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNametb.Location = new System.Drawing.Point(113, 141);
            this.AccNametb.Multiline = true;
            this.AccNametb.Name = "AccNametb";
            this.AccNametb.Size = new System.Drawing.Size(163, 28);
            this.AccNametb.TabIndex = 15;
            // 
            // AccNumtb
            // 
            this.AccNumtb.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumtb.Location = new System.Drawing.Point(113, 96);
            this.AccNumtb.Multiline = true;
            this.AccNumtb.Name = "AccNumtb";
            this.AccNumtb.Size = new System.Drawing.Size(163, 29);
            this.AccNumtb.TabIndex = 14;
            // 
            // addresstb
            // 
            this.addresstb.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstb.Location = new System.Drawing.Point(113, 231);
            this.addresstb.Multiline = true;
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(163, 70);
            this.addresstb.TabIndex = 17;
            // 
            // FaNametb
            // 
            this.FaNametb.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaNametb.Location = new System.Drawing.Point(113, 186);
            this.FaNametb.Multiline = true;
            this.FaNametb.Name = "FaNametb";
            this.FaNametb.Size = new System.Drawing.Size(163, 26);
            this.FaNametb.TabIndex = 16;
            // 
            // pintb
            // 
            this.pintb.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pintb.Location = new System.Drawing.Point(497, 93);
            this.pintb.Multiline = true;
            this.pintb.Name = "pintb";
            this.pintb.Size = new System.Drawing.Size(166, 32);
            this.pintb.TabIndex = 18;
            // 
            // phonetb
            // 
            this.phonetb.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetb.Location = new System.Drawing.Point(499, 231);
            this.phonetb.Multiline = true;
            this.phonetb.Name = "phonetb";
            this.phonetb.Size = new System.Drawing.Size(164, 21);
            this.phonetb.TabIndex = 21;
            // 
            // occupationtb
            // 
            this.occupationtb.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationtb.Location = new System.Drawing.Point(497, 185);
            this.occupationtb.Multiline = true;
            this.occupationtb.Name = "occupationtb";
            this.occupationtb.Size = new System.Drawing.Size(166, 27);
            this.occupationtb.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 10);
            this.panel2.TabIndex = 24;
            // 
            // educationtb
            // 
            this.educationtb.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educationtb.FormattingEnabled = true;
            this.educationtb.Items.AddRange(new object[] {
            "Under Graduate",
            "Post Graduate"});
            this.educationtb.Location = new System.Drawing.Point(499, 138);
            this.educationtb.Name = "educationtb";
            this.educationtb.Size = new System.Drawing.Size(164, 25);
            this.educationtb.TabIndex = 25;
            // 
            // dobdatetb
            // 
            this.dobdatetb.CalendarFont = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobdatetb.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobdatetb.Location = new System.Drawing.Point(499, 278);
            this.dobdatetb.Name = "dobdatetb";
            this.dobdatetb.Size = new System.Drawing.Size(164, 32);
            this.dobdatetb.TabIndex = 26;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Submit";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.MediumOrchid;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton21.Location = new System.Drawing.Point(289, 320);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(116, 41);
            this.bunifuThinButton21.TabIndex = 27;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumPurple;
            this.label9.Location = new System.Drawing.Point(311, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "LOGOUT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 411);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dobdatetb);
            this.Controls.Add(this.educationtb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.phonetb);
            this.Controls.Add(this.occupationtb);
            this.Controls.Add(this.pintb);
            this.Controls.Add(this.addresstb);
            this.Controls.Add(this.FaNametb);
            this.Controls.Add(this.AccNametb);
            this.Controls.Add(this.AccNumtb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AccNametb;
        private System.Windows.Forms.TextBox AccNumtb;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.TextBox FaNametb;
        private System.Windows.Forms.TextBox pintb;
        private System.Windows.Forms.TextBox phonetb;
        private System.Windows.Forms.TextBox occupationtb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox educationtb;
        private System.Windows.Forms.DateTimePicker dobdatetb;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label9;
    }
}