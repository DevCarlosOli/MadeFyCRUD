using System.Data.SqlClient;

namespace MadeFyCRUD.Infrastructure
{
    public class ConnectionFactory
    {
        //Incluir sua conexão com a base de dados
        private const string ConnectionString = "Server=SeuServidor;Database=MadeFyCRUD;Trusted_Connection=True;";

        public static SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
