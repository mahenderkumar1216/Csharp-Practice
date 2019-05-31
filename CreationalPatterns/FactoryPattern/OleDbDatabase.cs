using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace CreationalPatterns.FactoryPattern
{
    class OleDbDatabase : IDataBase
    {
        private OleDbConnection _Connection;

        private OleDbCommand _Command;
        public IDbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["OLEDBServerConnectionString"].ConnectionString;
                    _Connection = new OleDbConnection(connectionString);
                }
                return _Connection;
            }
        }

        public IDbCommand Command
        {
            get
            {
                if (_Command == null)
                {
                    _Command = new OleDbCommand();
                    _Command.Connection = (OleDbConnection)Connection;
                }
                return _Command;
            }
        }
    }
}
