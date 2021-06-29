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
            MySqlCommand command = new MySqlCommand("SELECT * FROM tambahaktivitasfoodshelter WHERE NamaFS = '" + ListAktivitas.Items+"')", db.GetConnection());
        }

        private void AktivitasFoodshelter_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM tambahaktivitasfoodshelter)", db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.OpenConnection();
            foreach (DataRow dr in table.Rows)
            {
                ListAktivitas.Items.Add(dr["NamaFS"].ToString());
            }
            db.CloseConnection();
        }
    }
}
