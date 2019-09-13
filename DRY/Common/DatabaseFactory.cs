using DRY.Interface;

namespace DRY.Common
{
    public class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType DataBaseType)
        {
            switch (DataBaseType)
            {
                case DatabaseType.OleDb:
                    return null;
                case DatabaseType.SqlServer:
                default:
                    return new SqlServerDatabase();
            }
        }
    }
}
