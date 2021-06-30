using MySql.Data.MySqlClient;

namespace Ze_Starve
{
    class KoneksiDatabase
    {
        private MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; database = Ze-starve");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
