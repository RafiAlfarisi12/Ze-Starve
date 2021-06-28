
namespace Ze_Starve
{
    partial class LoginForm
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
            this.LblPasswordInLoginForm = new System.Windows.Forms.Label();
            this.LblUsernameInLoginForm = new System.Windows.Forms.Label();
            this.BtnDaftarAkun = new System.Windows.Forms.Button();
            this.LblBelumPunyaAkunInLoginForm = new System.Windows.Forms.Label();
            this.LinkLabelLupaPassword = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPasswordInLoginForm
            // 
            this.LblPasswordInLoginForm.AutoSize = true;
            this.LblPasswordInLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasswordInLoginForm.Location = new System.Drawing.Point(388, 163);
            this.LblPasswordInLoginForm.Name = "LblPasswordInLoginForm";
            this.LblPasswordInLoginForm.Size = new System.Drawing.Size(83, 20);
            this.LblPasswordInLoginForm.TabIndex = 19;
            this.LblPasswordInLoginForm.Text = "Password";
            // 
            // LblUsernameInLoginForm
            // 
            this.LblUsernameInLoginForm.AutoSize = true;
            this.LblUsernameInLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsernameInLoginForm.Location = new System.Drawing.Point(388, 94);
            this.LblUsernameInLoginForm.Name = "LblUsernameInLoginForm";
            this.LblUsernameInLoginForm.Size = new System.Drawing.Size(86, 20);
            this.LblUsernameInLoginForm.TabIndex = 18;
            this.LblUsernameInLoginForm.Text = "Username";
            // 
            // BtnDaftarAkun
            // 
            this.BtnDaftarAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDaftarAkun.Location = new System.Drawing.Point(525, 357);
            this.BtnDaftarAkun.Name = "BtnDaftarAkun";
            this.BtnDaftarAkun.Size = new System.Drawing.Size(130, 34);
            this.BtnDaftarAkun.TabIndex = 17;
            this.BtnDaftarAkun.Text = "Daftar";
            this.BtnDaftarAkun.UseVisualStyleBackColor = true;
            this.BtnDaftarAkun.Click += new System.EventHandler(this.BtnDaftarAkun_Click);
            // 
            // LblBelumPunyaAkunInLoginForm
            // 
            this.LblBelumPunyaAkunInLoginForm.AutoSize = true;
            this.LblBelumPunyaAkunInLoginForm.Location = new System.Drawing.Point(472, 322);
            this.LblBelumPunyaAkunInLoginForm.Name = "LblBelumPunyaAkunInLoginForm";
            this.LblBelumPunyaAkunInLoginForm.Size = new System.Drawing.Size(236, 17);
            this.LblBelumPunyaAkunInLoginForm.TabIndex = 16;
            this.LblBelumPunyaAkunInLoginForm.Text = "Belum Punya Akun? Silahkan Daftar";
            // 
            // LinkLabelLupaPassword
            // 
            this.LinkLabelLupaPassword.AutoSize = true;
            this.LinkLabelLupaPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelLupaPassword.Location = new System.Drawing.Point(387, 231);
            this.LinkLabelLupaPassword.Name = "LinkLabelLupaPassword";
            this.LinkLabelLupaPassword.Size = new System.Drawing.Size(158, 25);
            this.LinkLabelLupaPassword.TabIndex = 15;
            this.LinkLabelLupaPassword.TabStop = true;
            this.LinkLabelLupaPassword.Text = "Lupa Password?";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(392, 186);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(379, 30);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(392, 117);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(379, 30);
            this.txtUsername.TabIndex = 12;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(517, 38);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(138, 44);
            this.LblLogin.TabIndex = 11;
            this.LblLogin.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ze_Starve.Properties.Resources.logoZStarve01;
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(525, 276);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(130, 34);
            this.BtnLogin.TabIndex = 20;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblPasswordInLoginForm);
            this.Controls.Add(this.LblUsernameInLoginForm);
            this.Controls.Add(this.BtnDaftarAkun);
            this.Controls.Add(this.LblBelumPunyaAkunInLoginForm);
            this.Controls.Add(this.LinkLabelLupaPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.LblLogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPasswordInLoginForm;
        private System.Windows.Forms.Label LblUsernameInLoginForm;
        private System.Windows.Forms.Button BtnDaftarAkun;
        private System.Windows.Forms.Label LblBelumPunyaAkunInLoginForm;
        private System.Windows.Forms.LinkLabel LinkLabelLupaPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLogin;
    }
}

