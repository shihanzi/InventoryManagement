using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagement
{
    internal class MyDb
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        public MyDb()
        {
            var config = LoadConfiguration();
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        private static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }

        public SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                    _connection = new SqlConnection(_connectionString);
                return _connection;
            }
        }

        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                try
                {
                    Connection.Open();
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, show a message to the user, etc.)
                }
            }
        }

        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                try
                {
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }
        }
    }
}
