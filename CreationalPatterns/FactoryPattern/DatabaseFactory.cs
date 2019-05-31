using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.FactoryPattern
{
    class DatabaseFactory
    {
        public static IDataBase CreateDatabase(DatabaseType DataBaseType)
        {
            switch(DataBaseType)
            {
                case DatabaseType.OleDb:
                    return new OleDbDatabase();
                case DatabaseType.SqlServer:
                default:
                    return new SqlServerDatabase();
            }
        }
    }
}
