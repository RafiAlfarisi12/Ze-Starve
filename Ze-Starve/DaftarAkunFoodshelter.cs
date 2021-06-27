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
    public partial class DaftarAkunFoodshelter : Form
    {
        KoneksiDatabase db = new KoneksiDatabase();
        public DaftarAkunFoodshelter()
        {
            InitializeComponent();
        }

        private void DaftarAkunFoodshelter_Load(object sender, EventArgs e)
        {

        }

        private void LinkUnggahFotoLogoFoodshelter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                PictureLogoFoodshelter.Image = Image.FromFile(opf.FileName);
            }
        }

        private void LinkUnggahFotoBukuTabungan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Foto buku tabungan berhasil di unggah!");
            }
        }

        private void LinkUnggahFotoKtp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Foto buku tabungan berhasil di unggah!");
            }
        }

        private void BtnSelesaiDaftarAkun_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            byte[] imgLogoFooodShelter = ms.ToArray();

            byte[] imgBukuTabungan = ms.ToArray();

            byte[] imgKtp = ms.ToArray();

            
            MySqlCommand command = new MySqlCommand("INSERT INTO penggunafoodshelter (NamaFoodshelter, NoTelpFoodshelter, AlamatFoodshelter, NoRekeningFoodshelter, DeskripsiFoodshelter, FotoLogoFoodshelter, FotoBukuTabungan, FotoKtp) VALUES (@NamaFoodshelter, @NoTelpFoodshelter, @AlamatFoodshelter, @NoRekeningFoodshelter, @DeskripsiFoodshelter, @FotoLogoFoodshelter, @FotoBukuTabungan, @FotoKtp)", db.GetConnection());
            
            command.Parameters.Add("@NamaFoodshelter", MySqlDbType.VarChar).Value = TxtNamaFoodshelter.Text;
            command.Parameters.Add("@NoTelpFoodshelter", MySqlDbType.VarChar).Value = TxtNoTelpFoodshelter.Text;
            command.Parameters.Add("@AlamatFoodshelter", MySqlDbType.VarChar).Value = TxtAlamatFoodshelter.Text;
            command.Parameters.Add("@NoRekeningFoodshelter", MySqlDbType.VarChar).Value = TxtNoRekeningFoodshelter.Text;
            command.Parameters.Add("@DeskripsiFoodshelter", MySqlDbType.VarChar).Value = TxtDeskripsiFoodshelter.Text;
            command.Parameters.Add("@FotoLogoFoodShelter", MySqlDbType.VarChar).Value = imgLogoFooodShelter;
            command.Parameters.Add("@FotoBukuTabungan", MySqlDbType.VarChar).Value = imgBukuTabungan;
            command.Parameters.Add("@FotoKtp", MySqlDbType.VarChar).Value = imgKtp;
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Akun berhasil dibuat!");
                new HalamanUtamaFoodshelter().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error");
            }
            db.CloseConnection(); 
        }

        private void PictureLogoFoodshelter_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
