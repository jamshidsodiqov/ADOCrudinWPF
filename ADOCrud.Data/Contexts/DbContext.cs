using ADOCrud.Domain.Custom;
using Npgsql;
using System.Data;

namespace ADOCrud.Data.Contexts
{
    public class DbContext
    {
        private NpgsqlConnection connection;

        public DbContext()
        {
            connection = new NpgsqlConnection(Consta.cnn);
        }

        public async Task<NpgsqlDataReader> ConnectionAsync(string query)
        {
            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            if (connection.State == ConnectionState.Open)
               await connection.CloseAsync();

            if (connection.State == ConnectionState.Closed)
            {
                await connection.OpenAsync();
                if (query.Contains("SELECT"))
                {
                    return await command.ExecuteReaderAsync();
                }
                else
                {
                    await command.ExecuteNonQueryAsync();
                }
                connection.Close();
            }

            return null;
        }
    }
}
