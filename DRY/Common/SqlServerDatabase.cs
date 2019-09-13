using DRY.Interface;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DRY.Common
{
    class SqlServerDatabase : IDatabase
    {
        private SqlConnection _Connection;

        private SqlCommand _Command;

        private SqlDataReader _DataReader;

        private SqlDataAdapter _DataAdapter;

        private DataSet _dataSet;

        private SqlParameter _SqlParameter;
        public IDbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    String connection = ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString;
                    return _Connection = new SqlConnection(connection);
                }
                else
                {
                    return _Connection;
                }
            }
        }

        public IDbCommand Command
        {
            get
            {
                if (_Command == null)
                {
                    _Command = new SqlCommand();
                    _Command.Connection = (SqlConnection)Connection;
                }
                return _Command;
            }
        }

        public IDbDataAdapter DbDataAdapter
        {
            get
            {
                if (_DataAdapter == null)
                {

                    _DataAdapter = new SqlDataAdapter();
                    _DataAdapter.SelectCommand = _Command;
                }
                return _DataAdapter;
            }
        }



        public DataSet DbDataSet
        {
            get
            {

                if (_Connection.State == ConnectionState.Closed)
                    _Connection.Open();

                _DataAdapter.SelectCommand.CommandText = _Command.CommandText;
                _DataAdapter.Fill(_dataSet);
                return _dataSet;
            }
        }

        public IDataParameter DbDataParameter
        {
            get
            {
                return _SqlParameter;
            }
            set
            {
                _Command.Parameters.Add(_SqlParameter);

            }

            //public IDataReader DataReader
            //{
            //    get
            //    {
            //        if (_DataReader == null)
            //        {
            //            _DataReader = 
            //        }
            //        return _DataReader;
            //    }
            //}
        }

        public IDataParameter CreateParameter
        {
            get
            {
                return _Command.CreateParameter();
            }

            set
            {
                _Command.CreateParameter();
            }
        }
    }
}
