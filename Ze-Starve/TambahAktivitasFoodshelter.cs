using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class TambahAktivitasFoodshelter : Form
    {
        KoneksiDatabase db = new KoneksiDatabase();

        public TambahAktivitasFoodshelter()
        {
            InitializeComponent();
        }

        public void Insert()
        {
            MemoryStream ms = new MemoryStream();
            byte[] ImgLogoFoodshelter = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO tambahaktivitasfoodshelter (NamaFS, DeskripsiKegiatan, MenuMakanan, AlamatFS, Tanggal, JamMulai, JamSelesai, JumlahPorsi, LogoFS) VALUES (@NamaFS, @DeskripsiKegiatan, @MenuMakanan, @AlamatFS, @Tanggal, @JamMulai, @JamSelesai, @JumlahPorsi, @LogoFS)", db.GetConnection());

            command.Parameters.Add("@NamaFS", MySqlDbType.VarChar).Value = TxtNamaFoodshelter.Text;
            command.Parameters.Add("@DeskripsiKegiatan", MySqlDbType.VarChar).Value = TxtDeskripsiKegiatan.Text;
            command.Parameters.Add("@MenuMakanan", MySqlDbType.VarChar).Value = TxtMenuMakanan.Text;
            command.Parameters.Add("@AlamatFS", MySqlDbType.VarChar).Value = TxtAlamatFoodshelter.Text;
            command.Parameters.Add("@Tanggal", MySqlDbType.DateTime).Value = DateTanggal.Value.ToString("yyyy/MM/dd");
            command.Parameters.Add("@JamMulai", MySqlDbType.VarChar).Value = BoxJamMulai.Text;
            command.Parameters.Add("@JamSelesai", MySqlDbType.VarChar).Value = BoxJamSelesai.Text;
            command.Parameters.Add("@JumlahPorsi", MySqlDbType.Int32).Value = UpDownJumlahPorsi.Value;
            command.Parameters.Add("@LogoFS", MySqlDbType.LongBlob).Value = ImgLogoFoodshelter;
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Aktivitas foodshelter berhasil dibuat!");
                new HalamanUtamaFoodshelter().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error");
            }
            db.CloseConnection();
        }

        private void TambahAktivitasFoodshelter_Load(object sender, EventArgs e)
        {
            
        }

        private void LinkLogoFoodshelter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureLogoFoodshelter.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BtnMulai_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void PictureLogoFoodshelter_Click(object sender, EventArgs e)
        {

        }

        private void UpDownJumlahPorsi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
