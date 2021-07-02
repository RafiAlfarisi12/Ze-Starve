using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class LupaPassword : Form
    {
        public enum Password_banned
        {
            nopassword, 123456, abcdef, 3periode;
        }


        public LupaPassword()
        {
            InitializeComponent();
        }

        private void LupaPassword_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void finish_Click(object sender, EventArgs e)
        {
            // Teknik 1 defensive programing jika data yang dimasukan kosong. 
            if (konpassEntry.Text.Equals("") || passEntry.Text.Equals("") || emailEntry.Text.Equals(""))
            {
                // Teknik defensive programming error message.
                MessageBox.Show("Konfirmasi Password yang anda input salah");
            }
            // Teknik 2 defensive programming jika konfirmasi passwordnya berbeda.
            else if (konpassEntry.Text != passEntry.Text)
            {
                // Teknik defensive programming error message.
                MessageBox.Show("Konfirmasi Password harus sama");
            }
            else if ((konpassEntry.Text != passEntry.Text) && !konpassEntry.Text.Equals("") && !passEntry.Text.Equals("") && !emailEntry.Text.Equals("") && passEntry.Text != Password_banned) 
            {
                // Teknik defensive programming error message.
                MessageBox.Show("Password berhasil diperbaharui");
                // Menuju login form.
                new LoginForm().Show(); 
                this.Hide();
            }
        }
    }
}
