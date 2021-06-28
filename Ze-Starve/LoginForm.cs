﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class LoginForm : Form
    {
        KoneksiDatabase db = new KoneksiDatabase();

        public LoginForm()
        {
            InitializeComponent();
        }

        public void Login()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT username, password, DaftarSebagai FROM pengguna WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'", db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    if (dr["DaftarSebagai"].ToString() == "Foodshelter")
                    {
                        new HalamanUtamaFoodshelter().Show();
                        this.Hide();
                    }
                    else if (dr["DaftarSebagai"].ToString() == "Donatur")
                    {
                        new HalamanUtamaDonatur().Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void BtnDaftarAkun_Click(object sender, EventArgs e)
        {
            new DaftarAkun().Show();
            this.Hide();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}