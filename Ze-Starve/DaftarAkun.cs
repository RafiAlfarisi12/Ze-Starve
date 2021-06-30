using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class DaftarAkun : Form
    {
        public DaftarAkun()
        {
            InitializeComponent();
        }

        private void Btn_Selanjutnya_In_Daftar_Akun_Click(object sender, EventArgs e)
        {
            // Kondisi 1 : jika radio button penerima yang di pilih.
            if (RbuttonInputPenerima.Checked)
            {
                // Menuju form DaftarAkunPenerima().
                new DaftarAkunPenerima().Show();
                this.Hide();
            }
            // Kondisi 2 : jika radio button donatur yang di pilih.
            else if (RbuttonInputDonatur.Checked)
            {
                // Menuju form DaftarAkunDonatur().
                new DaftarAkunDonatur().Show();
                this.Hide();
            }
            // Kondisi 1 : jika radio button foodshelter yang di pilih.
            else if (RbuttonInputFoodshelter.Checked)
            {
                // Menuju form DaftarAkunFoodshelter().
                new DaftarAkunFoodshelter().Show();
                this.Hide();
            }
        }

        private void DaftarAkun_Load(object sender, EventArgs e)
        {

        }
    }
}
