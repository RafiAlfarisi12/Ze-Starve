using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ze_Starve
{
    class GetSetDonasi<T>
    {
        // Teknik 1 : Generic untuk menyimpan data donasi.
        // Deklarasi variabel.
        public T _namaDon, _jumlah, _namaFS, _metode;

        // Membuat data baru.
        public GetSetDonasi(T _namaDon, T _jumlah, T _namaFS, T _metode)
        {
            this._namaDon = _namaDon;
            this._jumlah = _jumlah;
            this._namaFS = _namaFS;
            this._metode = _metode;
        }

        // Setter dan Getter untuk mendapatkan dan menyimpan data.
        public T getNamaDonatur()
        {
            return _namaDon;
        }
        public void setUserName(T namaDon)
        {
            this._namaDon = namaDon;
        }
        public T getJumlahDonasi()
        {
            return _jumlah;
        }
        public void setJumlahDonasi(T jumlah)
        {
            this._jumlah = jumlah;
        }
        public T getNamaFoodshelter()
        {
            return _namaFS;
        }
        public void setNamaFoodshelter(T namaFS)
        {
            this._namaFS = namaFS;
        }
        public T getMetodeDonasi()
        {
            return _metode;
        }
        public void setMetodeDonasi(T metode)
        {
            this._metode = metode;
        }
    }
    public partial class HalamanUtamaDonatur : Form
    {
        // Relasi ke database.
        KoneksiDatabase db = new KoneksiDatabase();
        public HalamanUtamaDonatur()
        {
            InitializeComponent();
            disabledEdit();
            listFS();
        }
        // Menonaktifkan edit text pada edit akun.
        void disabledEdit()
        {
            ndepanShow.Enabled = false;
            nbelakangShow.Enabled = false;
            userShow.Enabled = false;
            passShow.Enabled = false;
            pekerjaanShow.Enabled = false;
            totalShow.Enabled = false;
        }

        // Teknik 3 : API beserta desainnya.
        // Menampilkan data foodshelter dari database kedalam list box.
        void listFS()
        {
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tambahaktivitasfoodshelter` WHERE 1", db.GetConnection());
            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                String nama = myReader.GetString("NamaFS");
                listFoodshelter.Items.Add(nama);
            }
            db.CloseConnection();
        }

        // Teknik 2 : Design by contract untuk menghitung total bayar termasuk pajak.
        int taxDonasi(int jumlah)
        {
            // Pre-Condition 
            Debug.Assert(jumlah >= 10000 && jumlah <= 10000000, "Jumlah tidak valid, mohon perhatikan batas donasi");

            // Exception
            int total = checked(jumlah * 5 / 100);

            // Post-Condition
            return total;
        }

        void showAkun()
        {
            // Mengambil data dari database sql untuk menampilkan data donatur.
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `donatur` where username = '" + userGet.Text + "';", db.GetConnection());
            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                String namaD = myReader.GetString("namaD");
                String namaB = myReader.GetString("namaB");
                String user = myReader.GetString("username");
                String password = myReader.GetString("pass");
                String pekerjaan = myReader.GetString("pekerjaan");

                ndepanShow.Text = namaD;
                nbelakangShow.Text = namaB;
                userShow.Text = user;
                passShow.Text = password;
                pekerjaanShow.Text = pekerjaan;
            }
            db.CloseConnection();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metodeCombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        // Mengaktifkan edit text pada edit akun.
        private void namaEdit_Click(object sender, EventArgs e)
        {
            ndepanShow.Enabled = true;
            nbelakangShow.Enabled = true;
        }

        private void userEdit_Click(object sender, EventArgs e)
        {
            userShow.Enabled = true;
        }
        private void passEdit_Click(object sender, EventArgs e)
        {
            passShow.Enabled = true;
        }
        private void nikEdit_Click(object sender, EventArgs e)
        {

        }

        private void pekerjaanEdit_Click(object sender, EventArgs e)
        {
            pekerjaanShow.Enabled = true;
        }

        // Teknik 2 : Defensive Programming untuk menampilkan pesan kesalahan.
        // Kondisi untuk mengedit akun.
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Kondisi 1 : Data masih ada yang kosong.
            if(ndepanShow.Text.Equals("") || nbelakangShow.Text.Equals("") || userShow.Text.Equals("") || passShow.Text.Equals("") 
                || pekerjaanShow.Text.Equals(""))
            {
                MessageBox.Show("Data Anda masih kosong");
            }
            // Kondisi 2 : Panjang password kurang.
            else if(passShow.Text.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter");
            }
            else if(!ndepanShow.Text.Equals("") && !nbelakangShow.Text.Equals("") && !userShow.Text.Equals("") && !passShow.Text.Equals("")
                && !pekerjaanShow.Text.Equals("") && passShow.Text.Length >= 6)
            {
                // Kondisi 3 : Berhasil dengan data yang sudah diisi dan panjang password lebih dari 6.
                // Teknik 3 : API beserta desainnya.
                // Mengirim data ke database sql untuk edit akun.
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `donatur` SET `namaD`='" + ndepanShow.Text + "',`namaB`='" + nbelakangShow.Text + "'" +
                    ",`username`='" + userShow.Text + "',`pass`='" + passShow.Text + "',`pekerjaan`='" + pekerjaanShow.Text + "' WHERE username = '" + userGet.Text + "';", db.GetConnection());
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Selamat, Akun anda berhasil diubah");
                    new HalamanUtamaDonatur().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Edit akun error. Periksa kembali data Anda");
                }
                db.CloseConnection();
            }
        }
        // Tombol ganti akun untuk keluar dari akun donatur.
        private void gantiButton_Click(object sender, EventArgs e)
        {
            new DaftarAkun().Show();
            this.Hide();
        }
        // Mengatur kondisi radio button pengaturan nama.
        private void anonRadio_CheckedChanged(object sender, EventArgs e)
        {
            ndonEntry.Clear();
            ndonEntry.Enabled = false;
            ndonEntry.Text = "Anonim";
        }
        private void namaRadio_CheckedChanged(object sender, EventArgs e)
        {
            ndonEntry.Clear();
            ndonEntry.Enabled = true;
        }

        // Teknik 2 : Defensive Programming untuk menampilkan pesan kesalahan.
        // Kondisi untuk mengonfirmasi donasi.
        private void bayarButton_Click(object sender, EventArgs e)
        {
            // Kondisi 1 : Data masih ada yang kosong.
            if (metodeCombox.Text.Equals("") || jumlahEntry.Text.Equals("") || (anonRadio.Checked && namaRadio.Checked))
            {
                MessageBox.Show("Data Anda masih kosong");
            }
            // Kondisi 2 : Berhasil dengan data yang sudah diisi.
            if (!metodeCombox.Text.Equals("") && !jumlahEntry.Text.Equals("") && (anonRadio.Checked || namaRadio.Checked))
            {
                //Mengirim data ke database sql untuk membuat data donasi.
                // Teknik 3 : API beserta desainnya.
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO `donasi`(`namaDonatur`, `namaFS`, `jumlah`, `metode`, `id_donasi`) " +
                    "VALUES ('" + ndonEntry.Text + "','" + namaShow.Text + "','" + jumlahEntry.Text + "','" + metodeCombox.SelectedItem + "', NULL)", db.GetConnection());
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Terima kasih atas donasi Anda");
                    new HalamanUtamaDonatur().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Maaf donasi gagal. Periksa kembali data Anda");
                }
                db.CloseConnection();
            }
        }

        private void namaShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        // Memanggil method untuk menghitung pajak donasi.
        private void cekButton_Click(object sender, EventArgs e)
        {
            taxDonasi(jumlah);
        }

        private void listFoodshelter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menampilkan data kegiatan berbagi foodshelter pada text box.
            // Teknik 3 : API beserta desainnya.
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tambahaktivitasfoodshelter` WHERE NamaFS = '" + listFoodshelter.SelectedItem + "'", db.GetConnection());
            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                String nama = myReader.GetString("NamaFS");
                String alamat = myReader.GetString("AlamatFS");
                String deskripsi = myReader.GetString("DeskripsiKegiatan");
                String stok = myReader.GetString("JumlahPorsi");

                namaShow.Text = nama;
                alamatShow.Text = alamat;
                deskShow.Text = deskripsi;
                stokShow.Text = stok;
            }
            db.CloseConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Menyegarkan tampilan data akun setelah menginput username di menu utama.
        private void refreshButton_Click(object sender, EventArgs e)
        {
            showAkun();
        }

        private void donasiButton_Click(object sender, EventArgs e)
        {

        }
    }
}
