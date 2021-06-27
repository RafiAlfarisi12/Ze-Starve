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
    public partial class DaftarAkun : Form
    {
        string username { set; get; }

        KoneksiDatabase db = new KoneksiDatabase();

        public DaftarAkun()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void DaftarAkun_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Selanjutnya_In_Daftar_Akun_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO pengguna (Username, Password, NamaDepan, NamaBelakang, DaftarSebagai) VALUES (@Username,@Password,@NamaDepan,@NamaBelakang, @DaftarSebagai)", db.GetConnection());

            String Sebagai = " ";
            if (Rbutton_Input_Penerima.Checked)
            {
                Sebagai = "Penerima";
                new DaftarAkunPenerima().Show();
                this.Hide();
            }
            else if (Rbutton_Input_Donatur.Checked)
            {
                Sebagai = "Donatur";
                new DaftarAkunDonatur().Show();
                this.Hide();
            }
            else if (Rbutton_Input_Foodshelter.Checked)
            {
                Sebagai = "Foodshelter";
                new DaftarAkunFoodshelter().Show();
                this.Hide();
            }
            command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = txtUsername.Text;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = txtPassword.Text;
            command.Parameters.Add("@NamaDepan", MySqlDbType.VarChar).Value = txtNamaDepan.Text;
            command.Parameters.Add("@NamaBelakang", MySqlDbType.VarChar).Value = txtNamaBelakang.Text;
            command.Parameters.Add("@DaftarSebagai", MySqlDbType.VarChar).Value = Sebagai;
            db.OpenConnection();
            if (CekUsername())
            {
                MessageBox.Show("Username sudah ada yang memakai, silahkan masukan username lainnya!");
                new DaftarAkun().Show();
                this.Hide();
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Akun berhasil dibuat!");
                }
                else
                {
                    MessageBox.Show("Error");
                    new DaftarAkun().Show();
                    this.Hide();
                }

            }
            db.CloseConnection();
        }

        public Boolean CekUsername()
        {
            string username = txtUsername.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Pengguna` WHERE `Username` = @Username", db.GetConnection());

            command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
