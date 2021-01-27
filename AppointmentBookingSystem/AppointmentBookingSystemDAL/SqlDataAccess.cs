namespace AppointmentBookingSystemDAL
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using Dapper;
    using Microsoft.Extensions.Configuration;

    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;

        public string ConnectionStringName { get; set; } = "connString";

        // configuration is injected from front end
        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // using dapper for handiness
        // Load data generic - takes T, U (string sql and u parameters (generic type))
        // Returns generic List
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = _configuration.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                IEnumerable<T> data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            string connectionString = _configuration.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // Execute, runs an insert/update/delete etc where don't need data coming back
                // returns just a task saying it's complete
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
