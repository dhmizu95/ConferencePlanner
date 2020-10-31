using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace Graphql.DataAccess
{
    public class ConnectDatabase
    {
        public IDbConnection GetConnection()
        {
            // ReSharper disable once PossibleNullReferenceException
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(projectPath)
                .AddJsonFile("appsettings.json")
                .Build();
            string connectionString = configuration.GetConnectionString("OracleConnectionString");

            var connection = new OracleConnection(connectionString);
            return connection;
        }
    }
}
