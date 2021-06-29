using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class DaftarAkunDonatur : Form
    {
        KoneksiDatabase db = new KoneksiDatabase();
        public DaftarAkunDonatur()
        {
            InitializeComponent();
        }
        //Connector ke databases
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
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
        //Mengatur tombol reset untuk mengosongkan text entry dan menonaktifkan pilihan gaji.
        private void resetButton_Click(object sender, EventArgs e)
        {
            ndepanEntry.Clear();
            nbelakangEntry.Clear();
            userEntry.Clear();
            passEntry.Clear();
            nikEntry.Clear();
            pekerjaanEntry.Clear();
            gajiRadio1.Checked = false;
            gajiRadio2.Checked = false;
            gajiRadio3.Checked = false;
            gajiRadio4.Checked = false;
        }
        //Mengatur tombol selesai untuk menyelesaikan pendaftaran akun.
        private void nextButton_Click(object sender, EventArgs e)
        {
            //Kondisi gagal 1 : jika nik tidak sama dengan 16 karakter.
            if (nikEntry.Text.Length != 16)
            {
                MessageBox.Show("Nomor NIK anda tidak valid");
            }
            //Kondisi gagal 2 : jika masih ada yang kosong
            else if (pekerjaanEntry.Text.Equals("") || nikEntry.Text.Equals("") || passEntry.Text.Equals("") ||
                    userEntry.Text.Equals("") || passEntry.Text.Equals("") || ndepanEntry.Text.Equals("") || nbelakangEntry.Text.Equals(""))
            {
                MessageBox.Show("Data Anda masih kosong");
            }
            //Kondisi gagal 3 : jika password kurang dari 6 karakter.
            else if (passEntry.Text.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter");
            }
            //Kondisi berhasil.
            else if (nikEntry.Text.Length == 16 && !pekerjaanEntry.Text.Equals("") && passEntry.Text.Length >= 6)
            {
                MessageBox.Show("Selamat, Akun anda berhasil didaftarkan");
                new HalamanUtamaDonatur().Show();
                this.Hide();
                MySqlCommand command = new MySqlCommand("INSERT INTO donatur (namaD, namaB, username, pass, nik, pekerjaan, gaji) " +
                    "VALUES (@namaD, @namaB, @username, @pass, @nik, @pekerjaan, @gaji)", 
                    db.GetConnection());

                command.Parameters.Add("namaD", MySqlDbType.VarChar).Value = ndepanEntry.Text;
                command.Parameters.Add("namaB", MySqlDbType.VarChar).Value = nbelakangEntry.Text;
                command.Parameters.Add("user", MySqlDbType.VarChar).Value = userEntry.Text;
                command.Parameters.Add("pass", MySqlDbType.VarChar).Value = passEntry.Text;
                command.Parameters.Add("nik", MySqlDbType.VarChar).Value = nikEntry.Text;
                command.Parameters.Add("pekerjaan", MySqlDbType.VarChar).Value = pekerjaanEntry.Text;
                command.Parameters.Add("gaji", MySqlDbType.VarChar).Value = gajiBox.Select;
                db.OpenConnection();
                db.CloseConnection();
            }
        }
        //Mengatur kembali untuk membatalkan pendaftaran akun.
        private void backButton_Click(object sender, EventArgs e)
        {
            new DaftarAkun().Show();
            this.Hide();
        }
    }
}
