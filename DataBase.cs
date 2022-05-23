using MySql.Data.MySqlClient;

namespace SQLdatabase
{
    public class Database
    {
        MySqlConnection connection = new MySqlConnection("server=192.168.1.7;" +
                                                         "port=3306;username=root;" +
                                                         "password=Jcjpyfybt;" +
                                                         "database=factories;");
        public void Connect()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Disconnect()
        {
            if(connection.State == System.Data.ConnectionState.Open)
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