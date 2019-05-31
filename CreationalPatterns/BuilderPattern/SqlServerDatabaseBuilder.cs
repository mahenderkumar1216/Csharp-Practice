using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern
{
    class SqlServerDatabaseBuilder : IDatabaseBuilder
    {
        private AbstactDatabase _Database;

        public SqlServerDatabaseBuilder()
        {
            _Database = new SqlServerClass();
        }

        public void BuildCommand()
        {
            _Database.Command = new SqlCommand();
            _Database.Command.Connection = _Database.Connection;
        }

        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ConnectionString;
            _Database.Connection = new SqlConnection(connectionString);
        }

        public void SetSettings()
        {
            _Database.Command.CommandTimeout = 360;
        }

        public AbstactDatabase Database
        {
            get
            {
                return _Database;
            }
        }
    }
}
