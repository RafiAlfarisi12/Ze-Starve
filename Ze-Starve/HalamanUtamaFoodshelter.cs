using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class HalamanUtamaFoodshelter : Form
    {
        // API koneksi database.
        KoneksiDatabase db = new KoneksiDatabase();

        public HalamanUtamaFoodshelter()
        {
            InitializeComponent();
        }

        // Mengatur button tambah aktivitas
        private void BtnTambahAktivitas_Click(object sender, EventArgs e)
        {
            // Menuju form TambahAktivitasFoodshelter.
            new TambahAktivitasFoodshelter().Show();
            this.Hide();
        }

        // Mengatur button aktivitas foodshelter
        private void BtnAktivitasFoodshelter_Click(object sender, EventArgs e)
        {
            // Menuju form AktivitasFoodshelter.
            new AktivitasFoodshelter().Show();
            this.Hide();
        }

        // Mengatur button logout
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Menuju form LoginForm.
            new LoginForm().Show();
            this.Hide();
        }

        private void PageFoodshelter_Click(object sender, EventArgs e)
        {

        }
    }
}
