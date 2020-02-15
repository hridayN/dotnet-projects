using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public class DataBase: IDataBase
    {
        // private Guid currentSession;
        private IDbConnection connection;
        private string dbName = nameof(DBName);

        public string DBName
        {
            get { return dbName; }
            set { dbName = value; }
        }

        public DataBase()
        {
            // this.currentSession = Guid.NewGuid();
        }

        public string DBConnectionString { get; set; }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public DataSet LoadDataSet(string sqlQuery, QueryCommandType queryCommandType)
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            try
            {
                if (this.connection == null)
                {
                    if (string.IsNullOrEmpty(this.DBConnectionString))
                    {
                        this.GetConnectionString(this.DBName, "");
                    }
                }
            }
            catch
            {

            }
        }

        public void GetConnectionString(string dbAppSettingName, string defaultValue = "")
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(this.DBConnectionString)) { return; }
                if (string.IsNullOrWhiteSpace(dbAppSettingName) && string.IsNullOrWhiteSpace(defaultValue))
                {
                    throw new ArgumentNullException("Please provide detail for Database that store application data");
                }
            } catch
            {

            }
            
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
