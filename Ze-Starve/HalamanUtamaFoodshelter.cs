﻿using System;
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
    public partial class HalamanUtamaFoodshelter : Form
    {
        public HalamanUtamaFoodshelter()
        {
            InitializeComponent();
        }

        private void LblUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LblNamaFoodshelter_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnFoodshelter_Click(object sender, EventArgs e)
        {
            LblSelectedFoodshelter.Visible = true;
            LblSelectedNotifikasi.Visible = false;
            LblSelectedAkun.Visible = false;
        }

        private void BtnNotifikasi_Click(object sender, EventArgs e)
        {
            LblSelectedFoodshelter.Visible = false;
            LblSelectedNotifikasi.Visible = true;
            LblSelectedAkun.Visible = false;
        }

        private void BtnAkun_Click(object sender, EventArgs e)
        {
            LblSelectedFoodshelter.Visible = false;
            LblSelectedNotifikasi.Visible = false;
            LblSelectedAkun.Visible = true;
        }

        private void HalamanUtamaFoodshelter_Load(object sender, EventArgs e)
        {

        }
    }
}
