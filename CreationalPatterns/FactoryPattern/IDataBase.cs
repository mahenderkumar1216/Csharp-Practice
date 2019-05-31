using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;

namespace CreationalPatterns.FactoryPattern
{
    interface IDataBase
    {
        IDbConnection Connection { get; }

        IDbCommand Command { get; }
    }
}
