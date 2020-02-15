using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataBaseLibrary
{
    public interface IDataBase
    {
        string DBConnectionString { get; set; }

        void OpenConnection();

        void CloseConnection();

        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();

        DataSet LoadDataSet(string sqlQuery, QueryCommandType queryCommandType);
    }
}
