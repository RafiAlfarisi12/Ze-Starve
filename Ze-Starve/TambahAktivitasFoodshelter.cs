using MySql.Data.MySqlClient;
using System;
using System.Data;
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

        //Method insert data.
        public void Insert()
        {
            // API menambahkan data baru ke tabel penggunafoodshelter pada database.
            MySqlCommand command = new MySqlCommand("INSERT INTO tambahaktivitasfoodshelter (NamaFS, DeskripsiKegiatan, MenuMakanan, LokasiFS, Tanggal, JamMulai, " +
                "JamSelesai, JumlahPorsi) VALUES (@NamaFS, @DeskripsiKegiatan, @MenuMakanan, @LokasiFS, @Tanggal, @JamMulai, @JamSelesai, @JumlahPorsi)", db.GetConnection());
            // API menentukan nama parameter dan nilainya.
            command.Parameters.Add("@NamaFS", MySqlDbType.VarChar).Value = TxtNamaFS.Text;
            command.Parameters.Add("@DeskripsiKegiatan", MySqlDbType.VarChar).Value = TxtDescKegiatan.Text;
            command.Parameters.Add("@MenuMakanan", MySqlDbType.VarChar).Value = TxtMenuMakanan.Text;
            command.Parameters.Add("@LokasiFS", MySqlDbType.VarChar).Value = TxtLokFS.Text;
            command.Parameters.Add("@Tanggal", MySqlDbType.DateTime).Value = DateTanggal.Value.ToString("yyyy/MM/dd");
            command.Parameters.Add("@JamMulai", MySqlDbType.VarChar).Value = BoxJamMulai.Text;
            command.Parameters.Add("@JamSelesai", MySqlDbType.VarChar).Value = BoxJamSelesai.Text;
            command.Parameters.Add("@JumlahPorsi", MySqlDbType.Int32).Value = TxtJmlPorsi.Text;
            // API buka koneksi.
            db.OpenConnection();
            // Kondisi 1 : teknik defensive programming untuk cek data masih ada yang tidak sesuai atau tidak.
            if (CekNamaFS() || CekDescKegiatan() || CekMenuMakanan() || CekLokFS())
            {
                // Teknik defensive programming error message.
                MessageBox.Show("Pastikan data terisi dengan benar!");
            }
            // Kondisi 2 : teknik defensive programming untuk cek data sudah terisi atau belum.
            else if (TxtNamaFS.Text.Equals("") || TxtDescKegiatan.Text.Equals("") || TxtMenuMakanan.Text.Equals("") || TxtLokFS.Text.Equals("") || DateTanggal.Value.ToString().Equals("") || 
                BoxJamMulai.Text.Equals("") || BoxJamSelesai.Text.Equals("") || TxtJmlPorsi.Text.Equals(""))
            {
                // Teknik defensive programming error message.
                MessageBox.Show("Data masih ada yang kosong, silahkan periksa kembali!");
            }
            // Kondisi 3 : jika data berhasil di input.
            else if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Aktivitas foodshelter berhasil dibuat!");
                // Menuju HalamanUtamaFoodshelter().
                new HalamanUtamaFoodshelter().Show();
                this.Hide();

            }
            // Kondisi 4 : jika data tidak berhasil di input.
            else
            {
                // Teknik defensive programming error message.
                MessageBox.Show("Error");
            }
            // Api close koneksi
            db.CloseConnection();
        }

        public void update()
        {
            // API menambahkan data baru ke tabel penggunafoodshelter pada database.
            MySqlCommand command = new MySqlCommand("UPDATE INTO tambahaktivitasfoodshelter (NamaFS, DeskripsiKegiatan, MenuMakanan, LokasiFS, Tanggal, JamMulai, " +
                "JamSelesai, JumlahPorsi) VALUES (@NamaFS, @DeskripsiKegiatan, @MenuMakanan, @LokasiFS, @Tanggal, @JamMulai, @JamSelesai, @JumlahPorsi)", db.GetConnection());
            // API menentukan nama parameter dan nilainya.
            command.Parameters.Add("@NamaFS", MySqlDbType.VarChar).Value = TxtNamaFS.Text;
            command.Parameters.Add("@DeskripsiKegiatan", MySqlDbType.VarChar).Value = TxtDescKegiatan.Text;
            command.Parameters.Add("@MenuMakanan", MySqlDbType.VarChar).Value = TxtMenuMakanan.Text;
            command.Parameters.Add("@LokasiFS", MySqlDbType.VarChar).Value = TxtLokFS.Text;
            command.Parameters.Add("@Tanggal", MySqlDbType.DateTime).Value = DateTanggal.Value.ToString("yyyy/MM/dd");
            command.Parameters.Add("@JamMulai", MySqlDbType.VarChar).Value = BoxJamMulai.Text;
            command.Parameters.Add("@JamSelesai", MySqlDbType.VarChar).Value = BoxJamSelesai.Text;
            command.Parameters.Add("@JumlahPorsi", MySqlDbType.Int32).Value = TxtJmlPorsi.Text;
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
            // Menuju form HalamanUtamaFoodshelter.
            new HalamanUtamaFoodshelter().Show();
            this.Hide();
        }

        // Method teknik defensive programming untuk mengecek nama foodshelter memiliki karakter lebih dari 30 atau tidak.
        public Boolean CekNamaFS()
        {
            // Kondisi 1 : jika nama foodshelter lebih dari 30 karakter.
            if (TxtNamaFS.Text.Length > 30)
            {
                return true;
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                return false;
            }
        }

        // Method teknik defensive programming untuk mengecek deskripsi kegiatan memiliki karakter lebih dari 200 atau tidak.
        public Boolean CekDescKegiatan()
        {
            // Kondisi 1 : jika deskripsi kegiatan lebih dari 200 karakter
            if (TxtDescKegiatan.Text.Length > 200)
            {
                return true;
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                return false;
            }
        }

        // Method teknik defensive programming untuk mengecek menu makanan memiliki karakter lebih dari 30 atau tidak.
        public Boolean CekMenuMakanan()
        {
            // Kondisi 1 : jika menu makanan lebih dari 30 karakter.
            if (TxtMenuMakanan.Text.Length > 30)
            {
                return true;
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                return false;
            }
        }

        // Method teknik defensive programming untuk mengecek lokasi foodshelter memiliki karakter lebih dari 50 atau tidak.
        public Boolean CekLokFS()
        {
            // Kondisi 1 : jika lokasi foodshelter memiliki lebih dari 50 karakter.
            if (TxtLokFS.Text.Length > 50)
            {
                return true;
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                return false;
            }
        }


        private void TxtNamaFS_TextChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : ambil method ceknamafs.
            if (CekNamaFS())
            {
                ErrNamaFS.SetError(TxtNamaFS, "Nama foodshelter tidak boleh melebihi dari 30 karakter!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                ErrNamaFS.SetError(TxtNamaFS, null);
            }
        }

        private void TxtDescKegiatan_TextChanged(object sender, EventArgs e)
        {
            // // Kondisi 1 : ambil method cekdesckegiatan.
            if (CekDescKegiatan())
            {
                ErrDescKegiatan.SetError(TxtDescKegiatan, "Deskripsi foodshelter tidak boleh melebihi 200 karakter!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                ErrDescKegiatan.SetError(TxtDescKegiatan, null);
            }
        }

        private void TxtMenuMakanan_TextChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : ambil method cekmenumakanan.
            if (CekMenuMakanan())
            {
                ErrDescKegiatan.SetError(TxtMenuMakanan, "Menu makanan tidak boleh melebihi 200 karakter!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                ErrDescKegiatan.SetError(TxtMenuMakanan, null);
            }
        }

        private void TxtLokFS_TextChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : ambil method ceklokasi.
            if (CekLokFS())
            {
                ErrDescKegiatan.SetError(TxtLokFS, "Lokasi foodshelter tidak boleh melebihi 50 karakter!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                ErrDescKegiatan.SetError(TxtLokFS, null);
            }
        }

        private void TambahAktivitasFoodshelter_Load(object sender, EventArgs e)
        {

        }
    }
}
