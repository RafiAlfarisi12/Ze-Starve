using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class AktivitasFoodshelter : Form
    {
        // API koneksi database.
        KoneksiDatabase db = new KoneksiDatabase();
        public AktivitasFoodshelter()
        {
            InitializeComponent();
        }

        // Method untuk load tabel aktivitas foodshelter.
        private void AktivitasFoodshelter_Load(object sender, EventArgs e)
        {
            // Mengambil method fillData;
            fillData();
        }

        // Method TampilDataAktivitasFS();
        public DataTable TampilDataAktivitasFS()
        {
            // Membuat objek datatable.
            DataTable table = new DataTable();
            // Reset tabel.
            table.Reset();
            // Membuat objek table.
            table = new DataTable();
            // API mengambil data dari tabel tambahaktivitasfoodshelter.
            MySqlCommand command = new MySqlCommand("SELECT * FROM tambahaktivitasfoodshelter", db.GetConnection());
            {
                // API open koneksi.
                db.OpenConnection();
                // Membuat objek reader.
                MySqlDataReader reader = command.ExecuteReader();
                // Load reader.
                table.Load(reader);
            }
            // Mengeluarkan output table.
            return table;
        }

        // Method filldata.
        public void fillData()
        {
            // Membuat objek dataktivitas
            DataAktivitas.DataSource = TampilDataAktivitasFS();
        }

        // Method klik value pada tabel data aktivitas.
        private void DataAktivitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Set output tabel untuk di klik.
                DataGridViewRow row = this.DataAktivitas.Rows[e.RowIndex];
                LblIsiNamaFS.Text = row.Cells["NamaFS"].Value.ToString();
                LblIsiDescKegiatan.Text = row.Cells["DeskripsiKegiatan"].Value.ToString();
                LblIsiMenuMakanan.Text = row.Cells["MenuMakanan"].Value.ToString();
                LblIsiLokasiFS.Text = row.Cells["LokasiFS"].Value.ToString();
                LblIsiTgl.Text = row.Cells["Tanggal"].Value.ToString();
                LblIsiJmlPorsi.Text = row.Cells["JumlahPorsi"].Value.ToString();
                LblIsiJamMulai.Text = row.Cells["JamMulai"].Value.ToString();
                LblIsiJamSelesai.Text = row.Cells["JamSelesai"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            new HalamanUtamaFoodshelter().Show();
            this.Hide();
        }
    }
}
