
namespace Ze_Starve
{
    partial class HalamanUtamaFoodshelter
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblSelamatDatang = new System.Windows.Forms.Label();
            this.LblNamaFoodshelter = new System.Windows.Forms.Label();
            this.LblFoodshelter = new System.Windows.Forms.Label();
            this.LblNoTelpFoodshelter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.LblNoTelpFoodshelter);
            this.panel1.Controls.Add(this.LblFoodshelter);
            this.panel1.Controls.Add(this.LblNamaFoodshelter);
            this.panel1.Controls.Add(this.LblSelamatDatang);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 448);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(285, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 448);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblSelamatDatang
            // 
            this.LblSelamatDatang.AutoSize = true;
            this.LblSelamatDatang.Location = new System.Drawing.Point(97, 12);
            this.LblSelamatDatang.Name = "LblSelamatDatang";
            this.LblSelamatDatang.Size = new System.Drawing.Size(109, 17);
            this.LblSelamatDatang.TabIndex = 1;
            this.LblSelamatDatang.Text = "Selamat Datang";
            // 
            // LblNamaFoodshelter
            // 
            this.LblNamaFoodshelter.AutoSize = true;
            this.LblNamaFoodshelter.Location = new System.Drawing.Point(97, 29);
            this.LblNamaFoodshelter.Name = "LblNamaFoodshelter";
            this.LblNamaFoodshelter.Size = new System.Drawing.Size(124, 17);
            this.LblNamaFoodshelter.TabIndex = 2;
            this.LblNamaFoodshelter.Text = "Nama Foodshelter";
            this.LblNamaFoodshelter.Click += new System.EventHandler(this.LblNamaFoodshelter_Click);
            // 
            // LblFoodshelter
            // 
            this.LblFoodshelter.AutoSize = true;
            this.LblFoodshelter.Location = new System.Drawing.Point(97, 46);
            this.LblFoodshelter.Name = "LblFoodshelter";
            this.LblFoodshelter.Size = new System.Drawing.Size(130, 17);
            this.LblFoodshelter.TabIndex = 3;
            this.LblFoodshelter.Text = "Alamat Foodshelter";
            // 
            // LblNoTelpFoodshelter
            // 
            this.LblNoTelpFoodshelter.AutoSize = true;
            this.LblNoTelpFoodshelter.Location = new System.Drawing.Point(97, 63);
            this.LblNoTelpFoodshelter.Name = "LblNoTelpFoodshelter";
            this.LblNoTelpFoodshelter.Size = new System.Drawing.Size(74, 17);
            this.LblNoTelpFoodshelter.TabIndex = 4;
            this.LblNoTelpFoodshelter.Text = "No Telpon";
            // 
            // HalamanUtamaFoodshelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HalamanUtamaFoodshelter";
            this.Text = "s";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblNoTelpFoodshelter;
        private System.Windows.Forms.Label LblFoodshelter;
        private System.Windows.Forms.Label LblNamaFoodshelter;
        private System.Windows.Forms.Label LblSelamatDatang;
    }
}