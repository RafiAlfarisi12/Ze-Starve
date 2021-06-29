using MySql.Data.MySqlClient;
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
    public partial class AktivitasFoodshelter : Form
    {
        KoneksiDatabase db = new KoneksiDatabase();
        public AktivitasFoodshelter()
        {
            InitializeComponent();
        }

        private void ListAktivitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AktivitasFoodshelter_Load(object sender, EventArgs e)
        {

        }

        private void DataAktivitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand Penerima = new MySqlCommand("SELECT * FROM tambahaktivitasfoodshelter", db.GetConnection());
            adapter.SelectCommand = Penerima;
            adapter.Fill(table, "data");
            DataAktivitas.DataSource = table;
        }
    }
}
