using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CreationalPatterns.BuilderPattern
{
    class OledbDatabaseBuilder : IDatabaseBuilder
    {

        private AbstactDatabase _Database;

        public OledbDatabaseBuilder()
        {
            _Database = new OledbClass();
        }
        public AbstactDatabase Database
        {
            get
            {
                return _Database;
            }
        }

        public void BuildCommand()
        {
            _Database.Command = new OleDbCommand();
            _Database.Command.Connection = _Database.Connection;
        }

        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OleDbConnectionString"].ConnectionString;
            _Database.Connection = new OleDbConnection(connectionString);
        }

        public void SetSettings()
        {
            _Database.Command.CommandTimeout = 360;
        }
    }
}
