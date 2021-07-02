using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class LoginForm : Form
    {
        // Koneksi database.
        KoneksiDatabase db = new KoneksiDatabase();

        public LoginForm()
        {
            InitializeComponent();
        }

        // Method login.
        public void Login()
        {
            // Kondisi 1 : jika radio button penerima yang di pilih.
            if (RButtonPenerima.Checked)
            {
                // Membuat objek datatable.
                DataTable table = new DataTable();
                // Membuat objek adapter.
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                // Mengambil data pada tabel penggunapenerima pada database.
                MySqlCommand Penerima = new MySqlCommand("SELECT username, password FROM penggunapenerima WHERE username = '" + TxtUsername.Text + "' AND password = '" + TxtPassword.Text + "'", db.GetConnection());
                adapter.SelectCommand = Penerima;
                adapter.Fill(table);
                // Kondisi 1 : jika data ada dalam tabel penggunapenerima.
                if (table.Rows.Count > 0)
                {
                    // Menuju ke HalamanUtamaPenerima
                    new HalamanUtamaPenerima().Show();
                    this.Hide();
                }
                // Kondisi 2 : jika data tidak ada dalam tabel penggunapenerima.
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                }
            }
            // Kondisi 2 : jika radio button donatur yang di pilih.
            else if (RButtonDonatur.Checked)
            {
                // Membuat objek datatable.
                DataTable table = new DataTable();
                // Membuat objek adapter.
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                // Mengambil data pada tabel penggunadonatur pada database.
                MySqlCommand Donatur = new MySqlCommand("SELECT username, password FROM penggunadonatur WHERE username = '" + TxtUsername.Text + "' AND password = '" + TxtPassword.Text + "'", db.GetConnection());
                adapter.SelectCommand = Donatur;
                adapter.Fill(table);
                // Kondisi 1 : jika data ada dalam tabel penggunadonatur.
                if (table.Rows.Count > 0)
                {
                    // Menuju ke form HalamanUtamaDonatur().
                    new HalamanUtamaDonatur().Show();
                    this.Hide();
                }
                // Kondisi 2 : jika data tidak ada dalam tabel penggunadonatur.
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                }

            }
            // Kondisi 3 : jika radio button foodshelter yang di pilih.
            else if (RButtonFoodshelter.Checked)
            {
                // Membuat objek datatable.
                DataTable table = new DataTable();
                // Membuat objek adapter.
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                // Mengambil data pada tabel penggunafoodshelter pada database.
                MySqlCommand Foodshelter = new MySqlCommand("SELECT username, password FROM penggunafoodshelter WHERE username = '" + TxtUsername.Text + "' AND password = '" + TxtPassword.Text + "'", db.GetConnection());
                adapter.SelectCommand = Foodshelter;
                adapter.Fill(table);
                // Kondisi 1 : jika data ada dalam tabel penggunafoodshelter.
                if (table.Rows.Count > 0)
                {
                    // Menuju ke form HalamanUtamaFoodshelter().
                    new HalamanUtamaFoodshelter().Show();
                    this.Hide();
                }
                // Kondisi 2 : jika data tidak ada dalam tabel penggunafoodshelter.
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                }
            }
        }

        // Mengatur button Login.
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            // Mengambil value dari method Login().
            Login();
        }
        private void BtnDaftarAkun_Click(object sender, EventArgs e)
        {
            // Menuju ke form DaftarAkun().
            new DaftarAkun().Show();
            this.Hide();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : jika chekbox show password di klik maka akan menampilkan password.
            if (ShowPassword.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            // Kondisi 2 : jika chekbox show password tidak di klik maka menyembunyikan password.
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : jika chekbox show password di klik maka akan menampilkan password.
            if (ShowPassword.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            // Kondisi 2 : jika chekbox show password tidak di klik maka menyembunyikan password.
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
