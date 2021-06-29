
namespace Ze_Starve
{
    partial class DaftarAkunDonatur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.ndepanEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nbelakangEntry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userEntry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passEntry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nikEntry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pekerjaanEntry = new System.Windows.Forms.TextBox();
            this.gajiBox = new System.Windows.Forms.GroupBox();
            this.gajiRadio1 = new System.Windows.Forms.RadioButton();
            this.gajiRadio2 = new System.Windows.Forms.RadioButton();
            this.gajiRadio4 = new System.Windows.Forms.RadioButton();
            this.gajiRadio3 = new System.Windows.Forms.RadioButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gajiBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(131)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.gajiBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pekerjaanEntry);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nikEntry);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.passEntry);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.userEntry);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nbelakangEntry);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ndepanEntry);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 524);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buat Akun Donatur";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nextButton.Location = new System.Drawing.Point(588, 455);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(97, 41);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Selesai";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backButton.Location = new System.Drawing.Point(12, 455);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 41);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Kembali";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ndepanEntry
            // 
            this.ndepanEntry.Location = new System.Drawing.Point(19, 118);
            this.ndepanEntry.Name = "ndepanEntry";
            this.ndepanEntry.Size = new System.Drawing.Size(311, 22);
            this.ndepanEntry.TabIndex = 3;
            this.ndepanEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Depan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama Belakang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nbelakangEntry
            // 
            this.nbelakangEntry.Location = new System.Drawing.Point(19, 183);
            this.nbelakangEntry.Name = "nbelakangEntry";
            this.nbelakangEntry.Size = new System.Drawing.Size(311, 22);
            this.nbelakangEntry.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username / Gmail";
            // 
            // userEntry
            // 
            this.userEntry.Location = new System.Drawing.Point(19, 249);
            this.userEntry.Name = "userEntry";
            this.userEntry.Size = new System.Drawing.Size(311, 22);
            this.userEntry.TabIndex = 7;
            this.userEntry.TextChanged += new System.EventHandler(this.userEntry_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // passEntry
            // 
            this.passEntry.Location = new System.Drawing.Point(21, 307);
            this.passEntry.Name = "passEntry";
            this.passEntry.Size = new System.Drawing.Size(311, 22);
            this.passEntry.TabIndex = 9;
            this.passEntry.TextChanged += new System.EventHandler(this.passEntry_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(369, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nomor Induk Kependudukan (KTP)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // nikEntry
            // 
            this.nikEntry.Location = new System.Drawing.Point(374, 125);
            this.nikEntry.Name = "nikEntry";
            this.nikEntry.Size = new System.Drawing.Size(311, 22);
            this.nikEntry.TabIndex = 11;
            this.nikEntry.TextChanged += new System.EventHandler(this.nikEntry_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(369, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pekerjaan";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pekerjaanEntry
            // 
            this.pekerjaanEntry.Location = new System.Drawing.Point(374, 183);
            this.pekerjaanEntry.Name = "pekerjaanEntry";
            this.pekerjaanEntry.Size = new System.Drawing.Size(311, 22);
            this.pekerjaanEntry.TabIndex = 13;
            this.pekerjaanEntry.TextChanged += new System.EventHandler(this.pekerjaanEntry_TextChanged);
            // 
            // gajiBox
            // 
            this.gajiBox.Controls.Add(this.gajiRadio4);
            this.gajiBox.Controls.Add(this.gajiRadio3);
            this.gajiBox.Controls.Add(this.gajiRadio2);
            this.gajiBox.Controls.Add(this.gajiRadio1);
            this.gajiBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gajiBox.ForeColor = System.Drawing.Color.White;
            this.gajiBox.Location = new System.Drawing.Point(374, 218);
            this.gajiBox.Name = "gajiBox";
            this.gajiBox.Size = new System.Drawing.Size(311, 152);
            this.gajiBox.TabIndex = 15;
            this.gajiBox.TabStop = false;
            this.gajiBox.Text = "Penghasilan Per-Bulan";
            // 
            // gajiRadio1
            // 
            this.gajiRadio1.AutoSize = true;
            this.gajiRadio1.Location = new System.Drawing.Point(21, 31);
            this.gajiRadio1.Name = "gajiRadio1";
            this.gajiRadio1.Size = new System.Drawing.Size(131, 24);
            this.gajiRadio1.TabIndex = 0;
            this.gajiRadio1.TabStop = true;
            this.gajiRadio1.Text = "< Rp. 1.000.000";
            this.gajiRadio1.UseVisualStyleBackColor = true;
            // 
            // gajiRadio2
            // 
            this.gajiRadio2.AutoSize = true;
            this.gajiRadio2.Location = new System.Drawing.Point(21, 58);
            this.gajiRadio2.Name = "gajiRadio2";
            this.gajiRadio2.Size = new System.Drawing.Size(214, 24);
            this.gajiRadio2.TabIndex = 1;
            this.gajiRadio2.TabStop = true;
            this.gajiRadio2.Text = "Rp. 1.001.000 - Rp.5.000.000";
            this.gajiRadio2.UseVisualStyleBackColor = true;
            // 
            // gajiRadio4
            // 
            this.gajiRadio4.AutoSize = true;
            this.gajiRadio4.Location = new System.Drawing.Point(21, 114);
            this.gajiRadio4.Name = "gajiRadio4";
            this.gajiRadio4.Size = new System.Drawing.Size(135, 24);
            this.gajiRadio4.TabIndex = 3;
            this.gajiRadio4.TabStop = true;
            this.gajiRadio4.Text = "> Rp.15.001.000";
            this.gajiRadio4.UseVisualStyleBackColor = true;
            // 
            // gajiRadio3
            // 
            this.gajiRadio3.AutoSize = true;
            this.gajiRadio3.Location = new System.Drawing.Point(21, 87);
            this.gajiRadio3.Name = "gajiRadio3";
            this.gajiRadio3.Size = new System.Drawing.Size(222, 24);
            this.gajiRadio3.TabIndex = 2;
            this.gajiRadio3.TabStop = true;
            this.gajiRadio3.Text = "Rp. 5.001.000 - Rp.15.000.000";
            this.gajiRadio3.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetButton.Location = new System.Drawing.Point(588, 386);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 41);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // DaftarAkunDonatur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 521);
            this.Controls.Add(this.panel1);
            this.Name = "DaftarAkunDonatur";
            this.Text = "DaftarAkunDonatur";
            this.Load += new System.EventHandler(this.DaftarAkunDonatur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gajiBox.ResumeLayout(false);
            this.gajiBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox ndepanEntry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pekerjaanEntry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nikEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nbelakangEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gajiBox;
        private System.Windows.Forms.RadioButton gajiRadio4;
        private System.Windows.Forms.RadioButton gajiRadio3;
        private System.Windows.Forms.RadioButton gajiRadio2;
        private System.Windows.Forms.RadioButton gajiRadio1;
        private System.Windows.Forms.Button resetButton;
    }
}