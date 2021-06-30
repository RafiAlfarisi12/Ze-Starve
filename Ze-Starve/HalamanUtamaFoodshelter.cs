using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class HalamanUtamaFoodshelter : Form
    {
        // Koneksi database.
        KoneksiDatabase db = new KoneksiDatabase();

        public HalamanUtamaFoodshelter()
        {
            InitializeComponent();
        }

        private void BtnTambahAktivitas_Click(object sender, EventArgs e)
        {
            // Jika button tambah aktivitas di klik maka akan menuju form TambahAktivitasFoodshelter().
            new TambahAktivitasFoodshelter().Show();
            this.Hide();
        }
        private void BtnAktivitasFoodshelter_Click(object sender, EventArgs e)
        {
            // Jika button aktivitas foodshelter di klik maka akan menuju form AktivitasFoodshelter().
            new AktivitasFoodshelter().Show();
            this.Hide();
        }
    }
}
