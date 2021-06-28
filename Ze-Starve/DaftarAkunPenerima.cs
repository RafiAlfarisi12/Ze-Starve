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
    public partial class DaftarAkunPenerima : Form
    {
        KoneksiDatabase db = new KoneksiDatabase();
        public DaftarAkunPenerima()
        {
            InitializeComponent();
        }

        private void DaftarAkunPenerima_Load(object sender, EventArgs e)
        {

        }
    }
}
