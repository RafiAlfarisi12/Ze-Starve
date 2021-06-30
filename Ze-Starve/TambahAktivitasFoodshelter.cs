using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class TambahAktivitasFoodshelter : Form
    {
        // Koneksi database.
        KoneksiDatabase db = new KoneksiDatabase();

        public TambahAktivitasFoodshelter()
        {
            InitializeComponent();
        }
        // Method unggah foto.
        private void LinkLogoFoodshelter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuat objek OpenFileDialog.
            OpenFileDialog opf = new OpenFileDialog();
            // Menentukan format image yang bisa digunakan.
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            // Kondisi 1 : jika image berhasil di unggah.
            if (opf.ShowDialog() == DialogResult.OK)
            {
                // Menampilkan image pada picture box.
                PictureLogoFoodshelter.Image = Image.FromFile(opf.FileName);
            }
            // Kondisi 2 : Jika image gagal di ungggah.
            else
            {
                MessageBox.Show("Foto logo foodshelter gagal di unggah!");
            }
        }
        //Method insert data.
        public void Insert()
        {
            // Mengconvert image agar bisa dimasukan ke database.
            MemoryStream ms = new MemoryStream();
            byte[] ImgLogoFoodshelter = ms.ToArray();

            // Menambahkan data baru ke tabel penggunafoodshelter pada database.
            MySqlCommand command = new MySqlCommand("INSERT INTO tambahaktivitasfoodshelter (NamaFS, DeskripsiKegiatan, MenuMakanan, AlamatFS, Tanggal, JamMulai, " +
                "JamSelesai, JumlahPorsi, LogoFS) VALUES (@NamaFS, @DeskripsiKegiatan, @MenuMakanan, @AlamatFS, @Tanggal, @JamMulai, @JamSelesai, @JumlahPorsi, " +
                "@LogoFS)", db.GetConnection());
            // Menentukan nama parameter dan nilainya.
            command.Parameters.Add("@NamaFS", MySqlDbType.VarChar).Value = TxtNamaFoodshelter.Text;
            command.Parameters.Add("@DeskripsiKegiatan", MySqlDbType.VarChar).Value = TxtDeskripsiKegiatan.Text;
            command.Parameters.Add("@MenuMakanan", MySqlDbType.VarChar).Value = TxtMenuMakanan.Text;
            command.Parameters.Add("@AlamatFS", MySqlDbType.VarChar).Value = TxtAlamatFoodshelter.Text;
            command.Parameters.Add("@Tanggal", MySqlDbType.DateTime).Value = DateTanggal.Value.ToString("yyyy/MM/dd");
            command.Parameters.Add("@JamMulai", MySqlDbType.VarChar).Value = BoxJamMulai.Text;
            command.Parameters.Add("@JamSelesai", MySqlDbType.VarChar).Value = BoxJamSelesai.Text;
            command.Parameters.Add("@JumlahPorsi", MySqlDbType.Int32).Value = UpDownJumlahPorsi.Value;
            command.Parameters.Add("@LogoFS", MySqlDbType.LongBlob).Value = ImgLogoFoodshelter;
            // Buka koneksi.
            db.OpenConnection();
            // Kondisi 1 : jika data berhasil di input.
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Aktivitas foodshelter berhasil dibuat!");
                // Menuju HalamanUtamaFoodshelter().
                new HalamanUtamaFoodshelter().Show();
                this.Hide();

            }
            // Kondisi 1 : jika data tidak berhasil di input.
            else
            {
                MessageBox.Show("Error");
            }
            // Close koneksi
            db.CloseConnection();
        }
        // Mengatur button mulai untuk menyelesaikan tambah aktivitas foodshelter.
        private void BtnMulai_Click(object sender, EventArgs e)
        {
            // Mengambil value dari method insert.
            Insert();
        }
        // Mengatur button batal untuk membatalkan tambah aktivitas foodshelter.
        private void BtnBatal_Click(object sender, EventArgs e)
        {
            // Menuju form HalamanUtamaFoodshelter().
            new HalamanUtamaFoodshelter().Show();
            this.Hide();
        }
        private void TambahAktivitasFoodshelter_Load(object sender, EventArgs e)
        {

        }

        private void PictureLogoFoodshelter_Click(object sender, EventArgs e)
        {

        }

        private void UpDownJumlahPorsi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
