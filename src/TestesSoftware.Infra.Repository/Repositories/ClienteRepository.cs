using System.Collections.Generic;
using System.Data.SqlClient;
using TestesSoftware.Domain.Models;

namespace TestesSoftware.Infra.Repository.Repositories
{
    public sealed class ClienteRepository
    {
        public static List<Cliente> All()
        {
            var result = new List<Cliente>();

            using (var connection = Connection.Open())
            {
                using (var command = new SqlCommand("SELECT Id, Nome, Sobrenome, Emails FROM dbo.Clientes", connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add(Cliente.Factory.Criar(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3)
                        ));
                    }
                }
            }
            return result;
        }
    }
}
