using MySql.Data.MySqlClient;

namespace Ze_Starve
{
    class KoneksiDatabase
    {
        // Koneksi ke server database.
        private MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; database = Ze-starve");

        // Method open koneksi.
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Method close koneksi.
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Method get koneksi.
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
