using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class HalamanUtamaDonatur : Form
    {
        KoneksiDatabase db = new KoneksiDatabase();
        public HalamanUtamaDonatur()
        {
            InitializeComponent();
            disabledEdit();
        }
        //Connector ke databases
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //Menonaktifkan edit text pada edit akun.
        void disabledEdit()
        {
            ndepanShow.Enabled = false;
            nbelakangShow.Enabled = false;
            userShow.Enabled = false;
            passShow.Enabled = false;
            pekerjaanShow.Enabled = false;
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
        //Mengaktifkan edit text pada edit akun.
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
        //Kondisi untuk mengedit akun
        private void submitButton_Click(object sender, EventArgs e)
        {
            if(ndepanShow.Text.Equals("") || nbelakangShow.Text.Equals("") || userShow.Text.Equals("") || passShow.Text.Equals("") 
                || pekerjaanShow.Text.Equals(""))
            {
                MessageBox.Show("Data Anda masih kosong");
            }
            else if(passShow.Text.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter");
            }
            else if(!ndepanShow.Text.Equals("") && !nbelakangShow.Text.Equals("") && !userShow.Text.Equals("") && !passShow.Text.Equals("")
                && !pekerjaanShow.Text.Equals("") && passShow.Text.Length >= 6)
            {
                MessageBox.Show("Edit akun berhasil");
            }
        }
        //Tombol ganti akun untuk keluar dari akun donatur.
        private void gantiButton_Click(object sender, EventArgs e)
        {
            new DaftarAkun().Show();
            this.Hide();
        }
        //Mengatur kondisi radio button pengaturan nama.
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
        //Kondisi untuk mengonfirmasi donasi
        private void bayarButton_Click(object sender, EventArgs e)
        {
            if(metodeCombox.Text.Equals("") || jumlahEntry.Text.Equals("") || (anonRadio.Checked && namaRadio.Checked))
            {
                MessageBox.Show("Data Anda masih kosong");
            }
            if (!metodeCombox.Text.Equals("") && !jumlahEntry.Text.Equals("") && (anonRadio.Checked || namaRadio.Checked))
            {
                
            }
        }
    }
}
