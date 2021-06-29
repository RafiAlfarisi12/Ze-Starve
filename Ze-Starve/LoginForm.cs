using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        KoneksiDatabase db = new KoneksiDatabase();

        public LoginForm()
        {
            InitializeComponent();
        }

        public void Login()
        {
            if (RButtonPenerima.Checked)
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand Penerima = new MySqlCommand("SELECT username, password FROM penggunapenerima WHERE username = '" + TxtUsername.Text + "' AND password = '" + TxtPassword.Text + "'", db.GetConnection());
                adapter.SelectCommand = Penerima;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    new HalamanUtamaDonatur().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                }
            }
            else if (RButtonDonatur.Checked)
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand Donatur = new MySqlCommand("SELECT username, password FROM penggunadonatur WHERE username = '" + TxtUsername.Text + "' AND password = '" + TxtPassword.Text + "'", db.GetConnection());
                adapter.SelectCommand = Donatur;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    new HalamanUtamaDonatur().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                }
                
            }
            else if (RButtonFoodshelter.Checked)
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand Foodshelter = new MySqlCommand("SELECT username, password FROM penggunafoodshelter WHERE username = '" + TxtUsername.Text + "' AND password = '" + TxtPassword.Text + "'", db.GetConnection());
                adapter.SelectCommand = Foodshelter;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    new HalamanUtamaFoodshelter().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                }
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void BtnDaftarAkun_Click(object sender, EventArgs e)
        {
            new DaftarAkun().Show();
            this.Hide();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
