using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class DaftarAkunFoodshelter : Form
    {
        // Class login.
        public class Login
        {
            int IdPengguna { set; get; }
            string Username { set; get; }
            string Password { set; get; }
            string NamaDepan { set; get; }
            string NamaBelakang { set; get; }
            string DaftarSebagai { set; get; }
        };
        // Koneksi database.
        KoneksiDatabase db = new KoneksiDatabase();

        public DaftarAkunFoodshelter()
        {
            InitializeComponent();
        }
        
        // Method untuk unggah foto.
        private void LinkUnggahFotoLogoFoodshelter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        // Method untuk unggah foto.
        private void LinkUnggahFotoBukuTabungan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuat objek OpenFileDialog.
            OpenFileDialog opf = new OpenFileDialog();
            // Menentukan format image yang bisa digunakan.
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            // Kondisi : jika image berhasil di unggah.
            if (opf.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Foto buku tabungan berhasil di unggah!");
            }
            // Kondisi 2 : Jika image gagal di ungggah.
            else
            {
                MessageBox.Show("Foto buku tabungan gagal di unggah!");
            }
        }
        // Method untuk unggah foto.
        private void LinkUnggahFotoKtp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuat objek OpenFileDialog.
            OpenFileDialog opf = new OpenFileDialog();
            // Menentukan format image yang bisa digunakan.
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            // Kondisi 1 : jika image berhasil di unggah.
            if (opf.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Foto ktp berhasil di unggah!");
            }
            // Kondisi 2 : Jika image gagal di ungggah.
            else
            {
                MessageBox.Show("Foto ktp gagal di unggah!");
            }
        }
        // Mengatur button selesai untuk menyelesaikan daftar akun.
        private void BtnSelesaiDaftarAkun_Click(object sender, EventArgs e)
        {
            // Mengconvert image agar bisa dimasukan ke database.
            MemoryStream ms = new MemoryStream();
            byte[] ImgLogoFooodShelter = ms.ToArray();
            byte[] ImgBukuTabungan = ms.ToArray();
            byte[] ImgKtp = ms.ToArray();

            // Menambahkan data baru ke tabel penggunafoodshelter pada database.
            MySqlCommand command = new MySqlCommand("INSERT INTO penggunafoodshelter (NamaDepan, NamaBelakang, Username, Password, NamaFS, NoTelpFS, AlamatFS, " +
                "NoRekeningFS, DeskripsiFS, FotoLogoFS, FotoBukuTabungan, FotoKtp) VALUES (NamaDepan, NamaBelakang, @Username, @Password, @NamaFS, @NoTelpFS, " +
                "@AlamatFS, @NoRekeningFS, @DeskripsiFS, @FotoLogoFS, @FotoBukuTabungan, @FotoKtp)", db.GetConnection());
            // Menentukan nama parameter dan nilainya.
            command.Parameters.Add("NamaDepan", MySqlDbType.VarChar).Value = TxtNamaDepan.Text;
            command.Parameters.Add("NamaBelakang", MySqlDbType.VarChar).Value = TxtNamaBelakang.Text;
            command.Parameters.Add("Username", MySqlDbType.VarChar).Value = TxtUsername.Text;
            command.Parameters.Add("Password", MySqlDbType.VarChar).Value = TxtPassword.Text;
            command.Parameters.Add("NamaFS", MySqlDbType.VarChar).Value = TxtNamaFoodshelter.Text;
            command.Parameters.Add("NoTelpFS", MySqlDbType.VarChar).Value = TxtNoTelpFoodshelter.Text;
            command.Parameters.Add("AlamatFS", MySqlDbType.VarChar).Value = TxtAlamatFoodshelter.Text;
            command.Parameters.Add("NoRekeningFS", MySqlDbType.VarChar).Value = TxtNoRekeningFoodshelter.Text;
            command.Parameters.Add("DeskripsiFS", MySqlDbType.VarChar).Value = TxtDeskripsiFoodshelter.Text;
            command.Parameters.Add("FotoLogoFS", MySqlDbType.VarChar).Value = ImgLogoFooodShelter;
            command.Parameters.Add("FotoBukuTabungan", MySqlDbType.VarChar).Value = ImgBukuTabungan;
            command.Parameters.Add("FotoKtp", MySqlDbType.VarChar).Value = ImgKtp;
            // Buka koneksi.
            db.OpenConnection();
            // Kondisi 1 : cek username apakah ada yang sama di database atau tidak.
            if (CekUsername())
            {
                MessageBox.Show("Username sudah ada yang memakai, silahkan masukan username lainnya!");
                // Menuju form DaftarAkun.
                new DaftarAkun().Show();
                this.Hide();
            }
            // Kondisi 2 : jika data masih ada yang kosong.
            else if (TxtNamaDepan.Text.Equals("") || TxtNamaBelakang.Text.Equals("") || TxtUsername.Text.Equals("") || TxtPassword.Text.Equals("") || 
                TxtNamaFoodshelter.Text.Equals("") || TxtNoTelpFoodshelter.Text.Equals("") || TxtAlamatFoodshelter.Text.Equals("") || 
                TxtNoRekeningFoodshelter.Text.Equals("") || TxtDeskripsiFoodshelter.Text.Equals(""))
            {
                MessageBox.Show("Data masih ada yang kosong!");
            }
            // Kondisi 3 : jika password kurang dari 8 karakter.
            else if (TxtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter!");
            }
            // Kondisi 3
            else
            {
                // Jika akun berhasil dibuat.
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Akun berhasil dibuat!");
                    // Menuju form HalamanUtamaFoodshelter().
                    new HalamanUtamaFoodshelter().Show();
                    this.Hide();

                }
                // Jika akun gagal dibuat.
                else
                {
                    MessageBox.Show("Error, akun gagal dibuat!");
                }
            }
            // Close koneksi.
            db.CloseConnection();
        }
        // Method untuk mengecek apakah username sudah ada atau belum pada database.
        public Boolean CekUsername()
        {
            // Membuat nilai username.
            string username = TxtUsername.Text;
            // Membuat objek datatable.
            DataTable table = new DataTable();
            // Membuat objek adapter.
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Mengambil data pada tabel penggunafoodshelter pada database.
            MySqlCommand command = new MySqlCommand("SELECT * FROM penggunafoodshelter WHERE Username = @Username", db.GetConnection());
            // Mengambil nilai username.
            command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username;
            // Membuat objek adapter.
            adapter.SelectCommand = command;
            // Memgambil objek adapter.
            adapter.Fill(table);
            // Kondisi 1 : Jika berhasil.s
            if (table.Rows.Count > 0)
            {
                return true;
            }
            // Kondisi 1 : Jika gagal.
            else
            {
                return false;
            }
        }

        private void PictureLogoFoodshelter_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DaftarAkunFoodshelter_Load(object sender, EventArgs e)
        {

        }
    }
}
