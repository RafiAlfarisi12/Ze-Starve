
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
            this.ListAktivitas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ListAktivitas
            // 
            this.ListAktivitas.HideSelection = false;
            this.ListAktivitas.Location = new System.Drawing.Point(12, 12);
            this.ListAktivitas.Name = "ListAktivitas";
            this.ListAktivitas.Size = new System.Drawing.Size(193, 337);
            this.ListAktivitas.TabIndex = 0;
            this.ListAktivitas.UseCompatibleStateImageBehavior = false;
            this.ListAktivitas.SelectedIndexChanged += new System.EventHandler(this.ListAktivitas_SelectedIndexChanged);
            // 
            // AktivitasFoodshelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListAktivitas);
            this.Name = "AktivitasFoodshelter";
            this.Text = "AktivitasFoodshelter";
            this.Load += new System.EventHandler(this.AktivitasFoodshelter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListAktivitas;
    }
}