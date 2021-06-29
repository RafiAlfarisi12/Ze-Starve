
namespace Ze_Starve
{
    partial class AktivitasFoodshelter
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
            this.DataAktivitas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataAktivitas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataAktivitas
            // 
            this.DataAktivitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAktivitas.Location = new System.Drawing.Point(73, 150);
            this.DataAktivitas.Name = "DataAktivitas";
            this.DataAktivitas.RowHeadersWidth = 51;
            this.DataAktivitas.RowTemplate.Height = 24;
            this.DataAktivitas.Size = new System.Drawing.Size(570, 266);
            this.DataAktivitas.TabIndex = 0;
            this.DataAktivitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataAktivitas_CellContentClick);
            // 
            // AktivitasFoodshelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataAktivitas);
            this.Name = "AktivitasFoodshelter";
            this.Text = "AktivitasFoodshelter";
            this.Load += new System.EventHandler(this.AktivitasFoodshelter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataAktivitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataAktivitas;
    }
}