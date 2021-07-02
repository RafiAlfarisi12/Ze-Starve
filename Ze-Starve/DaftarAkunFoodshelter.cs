using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class DaftarAkunFoodshelter : Form
    {
        // API koneksi database.
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
                // Teknik defensive programming error message.
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
                // Teknik defensive programming error message.
                MessageBox.Show("Foto ktp berhasil di unggah!");
            }
            // Kondisi 2 : Jika image gagal di ungggah.
            else
            {
                // Teknik defensive programming error message.
                MessageBox.Show("Foto ktp gagal di unggah!");
            }
        }

        // Method insert().
        public void Insert()
        {
            // Mengconvert image agar bisa dimasukan ke database.
            MemoryStream ms = new MemoryStream();
            byte[] ImgLogoFoodShelter = ms.ToArray();
            byte[] ImgBukuTabungan = ms.ToArray();
            byte[] ImgKtp = ms.ToArray();

            // API menambahkan data baru ke tabel penggunafoodshelter pada database.
            MySqlCommand command = new MySqlCommand("INSERT INTO penggunafoodshelter (NamaDepan, NamaBelakang, Username, Password, NamaFS, NoTelpFS, AlamatFS, " +
                "NoRekeningFS, DeskripsiFS, FotoLogoFS, FotoBukuTabungan, FotoKtp) VALUES (NamaDepan, NamaBelakang, @Username, @Password, @NamaFS, @NoTelpFS, " +
                "@AlamatFS, @NoRekeningFS, @DeskripsiFS, @FotoLogoFS, @FotoBukuTabungan, @FotoKtp)", db.GetConnection());
            // API menentukan nama parameter dan nilainya.
            command.Parameters.Add("NamaDepan", MySqlDbType.VarChar).Value = TxtNamaDepan.Text;
            command.Parameters.Add("NamaBelakang", MySqlDbType.VarChar).Value = TxtNamaBelakang.Text;
            command.Parameters.Add("Username", MySqlDbType.VarChar).Value = TxtUsername.Text;
            command.Parameters.Add("Password", MySqlDbType.VarChar).Value = TxtPassword.Text;
            command.Parameters.Add("NamaFS", MySqlDbType.VarChar).Value = TxtNamaFoodshelter.Text;
            command.Parameters.Add("NoTelpFS", MySqlDbType.VarChar).Value = TxtNoTelpFoodshelter.Text;
            command.Parameters.Add("AlamatFS", MySqlDbType.VarChar).Value = TxtAlamatFoodshelter.Text;
            command.Parameters.Add("NoRekeningFS", MySqlDbType.VarChar).Value = TxtNoRekeningFoodshelter.Text;
            command.Parameters.Add("DeskripsiFS", MySqlDbType.VarChar).Value = TxtDeskripsiFoodshelter.Text;
            command.Parameters.Add("FotoLogoFS", MySqlDbType.VarChar).Value = ImgLogoFoodShelter;
            command.Parameters.Add("FotoBukuTabungan", MySqlDbType.VarChar).Value = ImgBukuTabungan;
            command.Parameters.Add("FotoKtp", MySqlDbType.VarChar).Value = ImgKtp;
            // API buka koneksi.
            db.OpenConnection();
            // Kondisi 1 : teknik defensive programming untuk cek data sudah terisi dengan benar atau belum.
            if (CekNamaDepan() || CekNamaBelakang() || CekUsername() || CekPassword() || CekNamaFS() || CekNoTelpFS() || CekAlamatFS() ||
                CekNoRekFS() || CekDesFS())
            {
                // Teknik defensive programming error message.
                MessageBox.Show("Pastikan data telah diisi dengan benar!");
            }
            // Kondisi 2 : teknik defensive programming untuk cek jika data masih ada yang kosong.
            else if (TxtNamaDepan.Text.Equals("") || TxtNamaBelakang.Text.Equals("") || TxtUsername.Text.Equals("") || TxtPassword.Text.Equals("") ||
                TxtConfirmPassword.Text.Equals("") || TxtNamaFoodshelter.Text.Equals("") || TxtNoTelpFoodshelter.Text.Equals("") || TxtAlamatFoodshelter.Text.Equals("") ||
                TxtNoRekeningFoodshelter.Text.Equals("") || TxtDeskripsiFoodshelter.Text.Equals(""))
            {
                // Teknik defensive programming error message.
                MessageBox.Show("Data masih ada yang kosong!");
            }
            // Kondisi 3
            else
            {
                // Jika akun berhasil dibuat.
                if (command.ExecuteNonQuery() == 1)
                {
                    // Teknik defensive programming error message.
                    MessageBox.Show("Akun berhasil dibuat!");
                    // Menuju form HalamanUtamaFoodshelter().
                    new HalamanUtamaFoodshelter().Show();
                    this.Hide();

                }
                // Jika akun gagal dibuat.
                else
                {
                    // Teknik defensive programming error message.
                    MessageBox.Show("Error, akun gagal dibuat!");
                }
            }
            // API close koneksi.
            db.CloseConnection();
        }

        // Mengatur button selesai untuk menyelesaikan daftar akun.
        private void BtnSelesaiDaftarAkun_Click(object sender, EventArgs e)
        {
            // Mengambil nilai dari method Insert().
            Insert();
        }

        // Method teknik defensive programming untuk mengecek nama depan memiliki karakter lebih dari 16 atau tidak.
        public Boolean CekNamaDepan()
        {
            string nama = TxtNamaDepan.Text;
            // Kondisi 1 : jika nama memiliki lebih dari 16 karakter.
            if (nama.Length > 16)
            {
                return true;
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                return true;
            }
        }

        // Method teknik defensive programming untuk mengecek nama belakang.
        public Boolean CekNamaBelakang()
        {
            // Membuat variabel nama;
            string nama = TxtNamaBelakang.Text;
            // Kondisi 1 : jika nama memiliki karakter lebih dari 16.
            if (nama.Length > 16)
            {
                return true;
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                return false;
            }
        }

        // Method teknik defensive programming untuk mengecek username sudah ada atau belum pada database.
        public Boolean CekUsername()
        {
            // Membuat variabel username.
            string Username = TxtUsername.Text;
            // Membuat objek datatable.
            DataTable table = new DataTable();
            // Membuat objek adapter.
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Mengambil data pada tabel penggunafoodshelter pada database.
            MySqlCommand command = new MySqlCommand("SELECT * FROM penggunafoodshelter WHERE Username = @Username", db.GetConnection());
            // Mengambil nilai username.
            command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = Username;
            // Membuat objek adapter.
            adapter.SelectCommand = command;
            // Memgambil objek adapter.
            adapter.Fill(table);
            // Kondisi 1 : Jika berhasil.
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

        // Method teknik defensive programming untuk mengecek password.
        public Boolean CekPassword()
        {
            // Membuat nilai variabel.
            string Password = TxtPassword.Text;
            // Kondisi 1 : jika password kurang dari 7 karakter.
            if (Password.Length < 7)
            {
                return true;
            }
            // Kondisi 2 : jika password kurang dari 16 karakter.
            else if (Password.Length > 16)
            {
                return true;
            }
            // Kondisi 3 : kondisi lainnya.
            else
            {
                return false;
            }
        }

        // Method teknik defensive programming untuk mengecek nama foodshelter.
        public Boolean CekNamaFS()
        {
            // Kondisi 1 : jika nama foodshelter lebih dari 30 karakter.
            if (TxtNamaFoodshelter.Text.Length > 30)
            {
                return true;
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                return false;
            }
        }

        // Method teknik defensive programming untuk mengecek no telpon foodshelter.
        public Boolean CekNoTelpFS()
        {
            // Kondisi 1 : jika no telp lebih dari 14 karakter.
            if (TxtNoTelpFoodshelter.Text.Length > 14)
            {
                return true;
            }
            // Kondisi 2 : jika no telp kurang dari 10 karakter.
            else if (TxtNoTelpFoodshelter.Text.Length < 10)
            {
                return true;
            }
            // Kondisi 3 : kondisi lainnya.
            else
            {
                return false;
            }
        }

        // Method teknik defensive programming untuk mengecek no rek foodshelter.
        public Boolean CekNoRekFS()
        {
            // Kondisi 1 : jika no rek lebih dari 16 karakter.
            if (TxtNoRekeningFoodshelter.Text.Length > 16)
            {
                return true;
            }
            // Kondisi 2 : jika no rek kurang dari 10 karakter.
            else if (TxtNoRekeningFoodshelter.Text.Length < 10)
            {
                return true;
            }
            // Kondisi 3 : kondisi lainnya.
            else
            {
                return false;
            }
        }

        // Method teknik defensive programming untuk mengecek deskripsi foodshelter.
        public Boolean CekDesFS()
        {
            // Kondisi 1 : jika deskripsi foodshelter lebih dari 200 karakter.
            if (TxtDeskripsiFoodshelter.Text.Length > 200)
            {
                return true;
            }
            // Kondisi 2 : kondisi lainnya
            else
            {
                return false;
            }
        }

        // Method teknik defensive programming untuk mengecek alamat foodshelter.
        public Boolean CekAlamatFS()
        {
            // Kondisi 1 : jika alamat foodshelter lebih dari 50 karakter.
            if (TxtAlamatFoodshelter.Text.Length > 50)
            {
                return true;
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                return false;
            }
        }

        // Mengatur text box nama depan.
        private void TxtNamaDepan_TextChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : mengambil method CekNamaDepan.
            if (CekNamaDepan())
            {
                // Teknik defensive programming error message.
                ErrNamaDepan.SetError(TxtNamaDepan, "Nama depan tidak boleh lebih dari 16 karakter!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                // Teknik defensive programming error message.
                ErrNamaDepan.SetError(TxtNamaDepan, null);
            }
        }

        // Mengatur text box nama belakang.
        private void TxtNamaBelakang_TextChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : mengambil method CekNamaBelakang.
            if (CekNamaBelakang())
            {
                // Teknik defensive programming error message.
                ErrNamaBelakang.SetError(TxtNamaBelakang, "Nama belakang tidak boleh lebih dari 16 karakter!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                // Teknik defensive programming error message.
                ErrNamaBelakang.SetError(TxtNamaBelakang, null);
            }
        }

        // Mengatur text box username.
        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : mengambil method CekUsername.
            if (CekUsername())
            {
                // Teknik defensive programming error message.
                ErrUser.SetError(TxtUsername, "Username atau email sudah ada yang menggunakan!");
            }
            // Kondisi 2 : teknik defensive programming mengecek username.
            else if (TxtUsername.Text.Length < 7)
            {
                // Teknik defensive programming error message.
                ErrUser.SetError(TxtUsername, "Username atau email tidak boleh kurang dari 7 karakter");
            }
            // Kondisi 3 : teknik defensive programming mengecek username.
            else if (TxtUsername.Text.Length > 50)
            {
                // Teknik defensive programming error message.
                ErrUser.SetError(TxtUsername, "Username atau email tidak boleh lebih dari 50 karakter");
            }
            // Kondisi 4 : kondisi lainnya.
            else
            {
                // Teknik defensive programming error message.
                ErrUser.SetError(TxtUsername, null);
            }
        }

        // Mengatur text box password.
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : mengambil method CekUsername.
            if (CekPassword())
            {
                // Teknik defensive programming error message.
                ErrPass.SetError(TxtPassword, "Password tidak boleh kurang dari 7 karakter dan tidak boleh boleh dari 16 karakter!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                // Teknik defensive programming error message.
                ErrPass.SetError(TxtPassword, null);
            }
        }

        // Mengatur text box confirm password.
        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : jika confirm password != password.
            if (TxtConfirmPassword.Text != TxtPassword.Text)
            {
                // Teknik defensive programming error message.
                ErrConfPass.SetError(TxtConfirmPassword, "Pastikan password sudah sesuai!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                // Teknik defensive programming error message.
                ErrConfPass.SetError(TxtConfirmPassword, null);
            }
        }

        // Mengatur text box nama foodshelter.
        private void TxtNamaFoodshelter_TextChanged(object sender, EventArgs e)
        {
            // Konsisi 1 : mengambil method CekNamaFS.
            if (CekNamaFS())
            {
                // Teknik defensive programming error message.
                ErrNamaFS.SetError(TxtNamaFoodshelter, "Nama foodshelter tidak boleh melebihi 30 karakter!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                // Teknik defensive programming error message.
                ErrNamaFS.SetError(TxtNamaFoodshelter, null);
            }
        }

        // Mengatur text box no telp foodshelter.
        private void TxtNoTelpFoodshelter_TextChanged(object sender, EventArgs e)
        {
            // Konsisi 1 : mengambil method CekNoTelpFS.
            if (CekNoTelpFS())
            {
                // Teknik defensive programming error message.
                ErrNoTelpFS.SetError(TxtNoTelpFoodshelter, "No telpon tidak valid!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                // Teknik defensive programming error message.
                ErrNoTelpFS.SetError(TxtNoTelpFoodshelter, null);
            }
        }

        // Mengatur text box alamat foodshelter.
        private void TxtAlamatFoodshelter_TextChanged(object sender, EventArgs e)
        {
            // Konsisi 1 : mengambil method CekAlamatFS.
            if (CekAlamatFS())
            {
                // Teknik defensive programming error message.
                ErrAlamatFS.SetError(TxtAlamatFoodshelter, "Alamat foodshelter tidak boleh melebihi 50 karakter!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                // Teknik defensive programming error message.
                ErrAlamatFS.SetError(TxtAlamatFoodshelter, null);
            }
        }
        // Mengatur text box no rekening foodshelter.
        private void TxtNoRekeningFoodshelter_TextChanged(object sender, EventArgs e)
        {
            // Kondisi 1 : mengambil method CekNoRekFS.
            if (CekNoRekFS())
            {
                // Teknik defensive programming error message.
                ErrNoRekFS.SetError(TxtNoRekeningFoodshelter, "No rekening tidak valid!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                // Teknik defensive programming error message.
                ErrNoRekFS.SetError(TxtNoRekeningFoodshelter, null);
            }
        }
        // Mengatur text box deskripsi foodshelter.
        private void TxtDeskripsiFoodshelter_TextChanged(object sender, EventArgs e)
        {
            // Konsisi 1 : mengambil method CekDesFS.
            if (CekDesFS())
            {
                // Teknik defensive programming error message.
                ErrDesFS.SetError(TxtDeskripsiFoodshelter, "Deskripsi Foodshelter tidak boleh melebihi 200 karakter!");
            }
            // Kondisi 2 : kondisi lainnya.
            else
            {
                // Teknik defensive programming error message.
                ErrDesFS.SetError(TxtDeskripsiFoodshelter, null);
            }
        }
        // Mengatur button kembali.
        private void BtnKembali_Click(object sender, EventArgs e)
        {
            // Menuju form DaftarAkun().
            new DaftarAkun().Show();
            this.Hide();
        }

        private void DaftarAkunFoodshelter_Load(object sender, EventArgs e)
        {

        }
    }
}