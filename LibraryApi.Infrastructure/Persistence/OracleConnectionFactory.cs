using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApi.Infrastructure.Persistence
{
    public interface IOracleConnectionFactory
    {
        public OracleConnection OracleCreateConnection();
    }
    public class OracleConnectionFactory : IOracleConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public OracleConnectionFactory(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public OracleConnection OracleCreateConnection()
        {
            string connectionString = _configuration.GetConnectionString("OracleDB")!;
            return new OracleConnection(connectionString);
        }
    }
}
