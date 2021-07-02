
namespace Ze_Starve
{
    partial class LupaPassword
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailEntry = new System.Windows.Forms.TextBox();
            this.passEntry = new System.Windows.Forms.TextBox();
            this.konpassEntry = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(131)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.finish);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.konpassEntry);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.passEntry);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.emailEntry);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(288, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = "Pemulihan Password";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(32, 77);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(280, 17);
            label2.TabIndex = 1;
            label2.Text = "Masukkan email atau nomor telepon anda :";
            // 
            // emailEntry
            // 
            this.emailEntry.Location = new System.Drawing.Point(35, 155);
            this.emailEntry.Name = "emailEntry";
            this.emailEntry.Size = new System.Drawing.Size(218, 20);
            this.emailEntry.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(32, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 17);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(32, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 17);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // passEntry
            // 
            this.passEntry.Location = new System.Drawing.Point(35, 208);
            this.passEntry.Name = "passEntry";
            this.passEntry.Size = new System.Drawing.Size(218, 20);
            this.passEntry.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(32, 241);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(143, 17);
            label5.TabIndex = 6;
            label5.Text = "Konfirmasi Password:";
            // 
            // konpassEntry
            // 
            this.konpassEntry.Location = new System.Drawing.Point(35, 261);
            this.konpassEntry.Name = "konpassEntry";
            this.konpassEntry.Size = new System.Drawing.Size(218, 20);
            this.konpassEntry.TabIndex = 7;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(52, 318);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 8;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(165, 318);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 9;
            this.finish.Text = "finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // LupaPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "LupaPassword";
            this.Text = "LupaPassword";
            this.Load += new System.EventHandler(this.LupaPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox emailEntry;
        private System.Windows.Forms.TextBox konpassEntry;
        private System.Windows.Forms.TextBox passEntry;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button back;
    }
}