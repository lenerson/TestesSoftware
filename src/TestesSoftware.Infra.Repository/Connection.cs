using System.Data.SqlClient;

namespace TestesSoftware.Infra.Repository
{
    public static class Connection
    {
        private static string ConnectionString =
            @"Data Source=LENERSON-NOTE\SQLEXPRESS;Initial Catalog=#1Meetup_TestesSoftware;User id=sa;Password=sa123;";

        public static SqlConnection Open()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
