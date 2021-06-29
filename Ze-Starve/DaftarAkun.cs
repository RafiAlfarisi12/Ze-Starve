using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class DaftarAkun : Form
    {
        public class Login
        {
            int IdPengguna { set; get; }
            string Username { set; get; }
            string Password { set; get; }
            string NamaDepan { set; get; }
            string NamaBelakang { set; get; }
            string DaftarSebagai { set; get; }
        };

        KoneksiDatabase db = new KoneksiDatabase();

        public DaftarAkun()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Btn_Selanjutnya_In_Daftar_Akun_Click(object sender, EventArgs e)
        {
            if (RbuttonInputPenerima.Checked)
            {
                new DaftarAkunPenerima().Show();
                this.Hide();
            }
            else if (RbuttonInputDonatur.Checked)
            {
                new DaftarAkunDonatur().Show();
                this.Hide();
            }
            else if (RbuttonInputFoodshelter.Checked)
            {
                new DaftarAkunFoodshelter().Show();
                this.Hide();
            }
        }

        private void DaftarAkun_Load(object sender, EventArgs e)
        {

        }
    }
}
