using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ze_Starve
{
    public partial class DaftarAkunDonatur : Form
    {
        // Relasi ke database.
        KoneksiDatabase db = new KoneksiDatabase();

        public DaftarAkunDonatur()
        {
            InitializeComponent();
        }
        private void DaftarAkunDonatur_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pekerjaanEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void passEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void userEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void nikEntry_TextChanged(object sender, EventArgs e)
        {

        }

        // Mengatur tombol reset untuk mengosongkan text entry dan menonaktifkan pilihan gaji.
        private void resetButton_Click(object sender, EventArgs e)
        {
            ndepanEntry.Clear();
            nbelakangEntry.Clear();
            userEntry.Clear();
            passEntry.Clear();
            nikEntry.Clear();
            pekerjaanEntry.Clear();
            gajiEntry.Clear();
        }

        // Mengatur tombol selesai untuk menyelesaikan pendaftaran akun.
        private void nextButton_Click(object sender, EventArgs e)
        {
            // Kondisi 1 : Jika nik tidak sama dengan 16 karakter.
            if (nikEntry.Text.Length != 16)
            {
                MessageBox.Show("Nomor NIK anda tidak valid");
            }
            // Kondisi 2 : Jika masih ada yang kosong.
            else if (pekerjaanEntry.Text.Equals("") || nikEntry.Text.Equals("") || passEntry.Text.Equals("") ||
                    userEntry.Text.Equals("") || passEntry.Text.Equals("") || ndepanEntry.Text.Equals("") || nbelakangEntry.Text.Equals("") ||
                    gajiEntry.Text.Equals(""))
            {
                MessageBox.Show("Data Anda masih kosong");
            }
            // Kondisi 3 : Jika password kurang dari 6 karakter.
            else if (passEntry.Text.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter");
            }
            // Kondisi 4 : Kondisi 1, 2, dan 3 tidak terpenuhi.
            else if (nikEntry.Text.Length == 16 && !pekerjaanEntry.Text.Equals("") && passEntry.Text.Length >= 6)
            {
                // Teknik 3 : API beserta desainnya.
                // Mengirim data ke database sql untuk mendaftarkan akun baru.
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO donatur(id_donatur, namaD, namaB, username, pass, nik, pekerjaan, gaji) " +
                "VALUES(NULL, '" + ndepanEntry.Text + "', '" + nbelakangEntry.Text + "', '" + userEntry.Text + "', '" +
                "" + passEntry.Text + "', '" + nikEntry.Text + "', '" + pekerjaanEntry.Text + "', '" + gajiEntry.Text + "')", db.GetConnection());
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Selamat, Akun anda berhasil didaftarkan");
                    new HalamanUtamaDonatur().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Daftar akun error. Periksa kembali data Anda");
                }
                db.CloseConnection();
            }
        }
        // Mengatur kembali untuk membatalkan pendaftaran akun.
        private void backButton_Click(object sender, EventArgs e)
        {
            new DaftarAkun().Show();
            this.Hide();
        }

        private void gajiRadio3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
