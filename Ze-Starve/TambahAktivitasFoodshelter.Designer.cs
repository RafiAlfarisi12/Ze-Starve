
namespace Ze_Starve
{
    partial class TambahAktivitasFoodshelter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblNamaFoodshelter = new System.Windows.Forms.Label();
            this.TxtNamaFS = new System.Windows.Forms.TextBox();
            this.LblDeskripsiKegiatan = new System.Windows.Forms.Label();
            this.TxtDescKegiatan = new System.Windows.Forms.TextBox();
            this.LblMenuMakanan = new System.Windows.Forms.Label();
            this.TxtMenuMakanan = new System.Windows.Forms.TextBox();
            this.LblLokFS = new System.Windows.Forms.Label();
            this.TxtLokFS = new System.Windows.Forms.TextBox();
            this.LblTanggal = new System.Windows.Forms.Label();
            this.DateTanggal = new System.Windows.Forms.DateTimePicker();
            this.LblJumlahPorsi = new System.Windows.Forms.Label();
            this.BtnMulai = new System.Windows.Forms.Button();
            this.BtnBatal = new System.Windows.Forms.Button();
            this.BoxJamMulai = new System.Windows.Forms.ComboBox();
            this.BoxJamSelesai = new System.Windows.Forms.ComboBox();
            this.LblJamMulai = new System.Windows.Forms.Label();
            this.LblJamSelesai = new System.Windows.Forms.Label();
            this.ErrNamaFS = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrDescKegiatan = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrMenuMakanan = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrLokFS = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtJmlPorsi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNamaFS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrDescKegiatan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMenuMakanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrLokFS)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNamaFoodshelter
            // 
            this.LblNamaFoodshelter.AutoSize = true;
            this.LblNamaFoodshelter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNamaFoodshelter.Location = new System.Drawing.Point(29, 13);
            this.LblNamaFoodshelter.Name = "LblNamaFoodshelter";
            this.LblNamaFoodshelter.Size = new System.Drawing.Size(146, 20);
            this.LblNamaFoodshelter.TabIndex = 20;
            this.LblNamaFoodshelter.Text = "Nama Foodshelter";
            // 
            // TxtNamaFS
            // 
            this.TxtNamaFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamaFS.Location = new System.Drawing.Point(32, 36);
            this.TxtNamaFS.Name = "TxtNamaFS";
            this.TxtNamaFS.Size = new System.Drawing.Size(425, 30);
            this.TxtNamaFS.TabIndex = 19;
            this.TxtNamaFS.TextChanged += new System.EventHandler(this.TxtNamaFS_TextChanged);
            // 
            // LblDeskripsiKegiatan
            // 
            this.LblDeskripsiKegiatan.AutoSize = true;
            this.LblDeskripsiKegiatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeskripsiKegiatan.Location = new System.Drawing.Point(28, 70);
            this.LblDeskripsiKegiatan.Name = "LblDeskripsiKegiatan";
            this.LblDeskripsiKegiatan.Size = new System.Drawing.Size(145, 20);
            this.LblDeskripsiKegiatan.TabIndex = 23;
            this.LblDeskripsiKegiatan.Text = "DeskripsiKegiatan";
            // 
            // TxtDescKegiatan
            // 
            this.TxtDescKegiatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescKegiatan.Location = new System.Drawing.Point(32, 93);
            this.TxtDescKegiatan.Multiline = true;
            this.TxtDescKegiatan.Name = "TxtDescKegiatan";
            this.TxtDescKegiatan.Size = new System.Drawing.Size(425, 87);
            this.TxtDescKegiatan.TabIndex = 22;
            this.TxtDescKegiatan.TextChanged += new System.EventHandler(this.TxtDescKegiatan_TextChanged);
            // 
            // LblMenuMakanan
            // 
            this.LblMenuMakanan.AutoSize = true;
            this.LblMenuMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenuMakanan.Location = new System.Drawing.Point(29, 185);
            this.LblMenuMakanan.Name = "LblMenuMakanan";
            this.LblMenuMakanan.Size = new System.Drawing.Size(122, 20);
            this.LblMenuMakanan.TabIndex = 25;
            this.LblMenuMakanan.Text = "Menu Makanan";
            // 
            // TxtMenuMakanan
            // 
            this.TxtMenuMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMenuMakanan.Location = new System.Drawing.Point(32, 208);
            this.TxtMenuMakanan.Name = "TxtMenuMakanan";
            this.TxtMenuMakanan.Size = new System.Drawing.Size(425, 30);
            this.TxtMenuMakanan.TabIndex = 24;
            this.TxtMenuMakanan.TextChanged += new System.EventHandler(this.TxtMenuMakanan_TextChanged);
            // 
            // LblLokFS
            // 
            this.LblLokFS.AutoSize = true;
            this.LblLokFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLokFS.Location = new System.Drawing.Point(29, 243);
            this.LblLokFS.Name = "LblLokFS";
            this.LblLokFS.Size = new System.Drawing.Size(151, 20);
            this.LblLokFS.TabIndex = 27;
            this.LblLokFS.Text = "Lokasi Foodshelter";
            // 
            // TxtLokFS
            // 
            this.TxtLokFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLokFS.Location = new System.Drawing.Point(32, 268);
            this.TxtLokFS.Name = "TxtLokFS";
            this.TxtLokFS.Size = new System.Drawing.Size(425, 30);
            this.TxtLokFS.TabIndex = 26;
            this.TxtLokFS.TextChanged += new System.EventHandler(this.TxtLokFS_TextChanged);
            // 
            // LblTanggal
            // 
            this.LblTanggal.AutoSize = true;
            this.LblTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTanggal.Location = new System.Drawing.Point(29, 301);
            this.LblTanggal.Name = "LblTanggal";
            this.LblTanggal.Size = new System.Drawing.Size(68, 20);
            this.LblTanggal.TabIndex = 29;
            this.LblTanggal.Text = "Tanggal";
            // 
            // DateTanggal
            // 
            this.DateTanggal.CustomFormat = "yyyy/MM/dd";
            this.DateTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTanggal.Location = new System.Drawing.Point(33, 324);
            this.DateTanggal.MaxDate = new System.DateTime(2095, 12, 31, 0, 0, 0, 0);
            this.DateTanggal.MinDate = new System.DateTime(1907, 1, 1, 0, 0, 0, 0);
            this.DateTanggal.Name = "DateTanggal";
            this.DateTanggal.Size = new System.Drawing.Size(121, 22);
            this.DateTanggal.TabIndex = 30;
            this.DateTanggal.Value = new System.DateTime(2021, 6, 28, 0, 0, 0, 0);
            // 
            // LblJumlahPorsi
            // 
            this.LblJumlahPorsi.AutoSize = true;
            this.LblJumlahPorsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJumlahPorsi.Location = new System.Drawing.Point(198, 301);
            this.LblJumlahPorsi.Name = "LblJumlahPorsi";
            this.LblJumlahPorsi.Size = new System.Drawing.Size(107, 20);
            this.LblJumlahPorsi.TabIndex = 32;
            this.LblJumlahPorsi.Text = "Jumlah Porsi";
            // 
            // BtnMulai
            // 
            this.BtnMulai.Location = new System.Drawing.Point(503, 150);
            this.BtnMulai.Name = "BtnMulai";
            this.BtnMulai.Size = new System.Drawing.Size(95, 30);
            this.BtnMulai.TabIndex = 33;
            this.BtnMulai.Text = "Mulai";
            this.BtnMulai.UseVisualStyleBackColor = true;
            this.BtnMulai.Click += new System.EventHandler(this.BtnMulai_Click);
            // 
            // BtnBatal
            // 
            this.BtnBatal.Location = new System.Drawing.Point(503, 212);
            this.BtnBatal.Name = "BtnBatal";
            this.BtnBatal.Size = new System.Drawing.Size(95, 30);
            this.BtnBatal.TabIndex = 34;
            this.BtnBatal.Text = "Batal";
            this.BtnBatal.UseVisualStyleBackColor = true;
            this.BtnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            // 
            // BoxJamMulai
            // 
            this.BoxJamMulai.FormattingEnabled = true;
            this.BoxJamMulai.Items.AddRange(new object[] {
            "08.00",
            "08.30",
            "09.00",
            "09.30",
            "10.00",
            "10.30",
            "11.00",
            "11.30",
            "12.00",
            "12.30",
            "13.00",
            "13.30",
            "14.00",
            "14.30",
            "15.00",
            "15.30",
            "16.00",
            "16.30",
            "17.00"});
            this.BoxJamMulai.Location = new System.Drawing.Point(33, 376);
            this.BoxJamMulai.Name = "BoxJamMulai";
            this.BoxJamMulai.Size = new System.Drawing.Size(121, 24);
            this.BoxJamMulai.TabIndex = 37;
            // 
            // BoxJamSelesai
            // 
            this.BoxJamSelesai.FormattingEnabled = true;
            this.BoxJamSelesai.Items.AddRange(new object[] {
            "08.00",
            "08.30",
            "09.00",
            "09.30",
            "10.00",
            "10.30",
            "11.00",
            "11.30",
            "12.00",
            "12.30",
            "13.00",
            "13.30",
            "14.00",
            "14.30",
            "15.00",
            "15.30",
            "16.00",
            "16.30",
            "17.00"});
            this.BoxJamSelesai.Location = new System.Drawing.Point(202, 376);
            this.BoxJamSelesai.Name = "BoxJamSelesai";
            this.BoxJamSelesai.Size = new System.Drawing.Size(121, 24);
            this.BoxJamSelesai.TabIndex = 38;
            // 
            // LblJamMulai
            // 
            this.LblJamMulai.AutoSize = true;
            this.LblJamMulai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJamMulai.Location = new System.Drawing.Point(29, 353);
            this.LblJamMulai.Name = "LblJamMulai";
            this.LblJamMulai.Size = new System.Drawing.Size(86, 20);
            this.LblJamMulai.TabIndex = 39;
            this.LblJamMulai.Text = "Jam Mulai";
            // 
            // LblJamSelesai
            // 
            this.LblJamSelesai.AutoSize = true;
            this.LblJamSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJamSelesai.Location = new System.Drawing.Point(198, 353);
            this.LblJamSelesai.Name = "LblJamSelesai";
            this.LblJamSelesai.Size = new System.Drawing.Size(101, 20);
            this.LblJamSelesai.TabIndex = 40;
            this.LblJamSelesai.Text = "Jam Selesai";
            // 
            // ErrNamaFS
            // 
            this.ErrNamaFS.ContainerControl = this;
            // 
            // ErrDescKegiatan
            // 
            this.ErrDescKegiatan.ContainerControl = this;
            // 
            // ErrMenuMakanan
            // 
            this.ErrMenuMakanan.ContainerControl = this;
            // 
            // ErrLokFS
            // 
            this.ErrLokFS.ContainerControl = this;
            // 
            // TxtJmlPorsi
            // 
            this.TxtJmlPorsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJmlPorsi.Location = new System.Drawing.Point(202, 320);
            this.TxtJmlPorsi.Name = "TxtJmlPorsi";
            this.TxtJmlPorsi.Size = new System.Drawing.Size(121, 30);
            this.TxtJmlPorsi.TabIndex = 42;
            // 
            // TambahAktivitasFoodshelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 417);
            this.Controls.Add(this.TxtJmlPorsi);
            this.Controls.Add(this.LblJamSelesai);
            this.Controls.Add(this.LblJamMulai);
            this.Controls.Add(this.BoxJamSelesai);
            this.Controls.Add(this.BoxJamMulai);
            this.Controls.Add(this.BtnBatal);
            this.Controls.Add(this.BtnMulai);
            this.Controls.Add(this.LblJumlahPorsi);
            this.Controls.Add(this.DateTanggal);
            this.Controls.Add(this.LblTanggal);
            this.Controls.Add(this.LblLokFS);
            this.Controls.Add(this.TxtLokFS);
            this.Controls.Add(this.LblMenuMakanan);
            this.Controls.Add(this.TxtMenuMakanan);
            this.Controls.Add(this.LblDeskripsiKegiatan);
            this.Controls.Add(this.TxtDescKegiatan);
            this.Controls.Add(this.LblNamaFoodshelter);
            this.Controls.Add(this.TxtNamaFS);
            this.Name = "TambahAktivitasFoodshelter";
            this.Text = "TambahAktivitasFoodshelter";
            ((System.ComponentModel.ISupportInitialize)(this.ErrNamaFS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrDescKegiatan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMenuMakanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrLokFS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNamaFoodshelter;
        private System.Windows.Forms.TextBox TxtNamaFS;
        private System.Windows.Forms.Label LblDeskripsiKegiatan;
        private System.Windows.Forms.TextBox TxtDescKegiatan;
        private System.Windows.Forms.Label LblMenuMakanan;
        private System.Windows.Forms.TextBox TxtMenuMakanan;
        private System.Windows.Forms.Label LblLokFS;
        private System.Windows.Forms.TextBox TxtLokFS;
        private System.Windows.Forms.Label LblTanggal;
        private System.Windows.Forms.DateTimePicker DateTanggal;
        private System.Windows.Forms.Label LblJumlahPorsi;
        private System.Windows.Forms.Button BtnMulai;
        private System.Windows.Forms.Button BtnBatal;
        private System.Windows.Forms.ComboBox BoxJamMulai;
        private System.Windows.Forms.ComboBox BoxJamSelesai;
        private System.Windows.Forms.Label LblJamMulai;
        private System.Windows.Forms.Label LblJamSelesai;
        private System.Windows.Forms.ErrorProvider ErrNamaFS;
        private System.Windows.Forms.ErrorProvider ErrDescKegiatan;
        private System.Windows.Forms.ErrorProvider ErrMenuMakanan;
        private System.Windows.Forms.ErrorProvider ErrLokFS;
        private System.Windows.Forms.TextBox TxtJmlPorsi;
    }
}