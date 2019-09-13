using System.Data;
namespace DRY.Interface
{
    public interface IDatabase
    {
        IDbConnection Connection { get; }
        IDbCommand Command { get; }
        IDbDataAdapter DbDataAdapter { get; }
        DataSet DbDataSet { get; }

        IDataParameter DbDataParameter {get;set;}

        IDataParameter CreateParameter { get; set; }


    }
}
