using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using static ExpenseManagerAPI.Database.DbHelper;

namespace ExpenseManagerAPI.Settings
{
    public sealed class DBConfigurations
    {
        private IConfiguration _configuration;
        private readonly string _connectionString;

        public DBConfigurations(IConfiguration configuration)
        {
            this._configuration = configuration;
            this._connectionString = configuration.GetValue<string>("Database:ConnectionString");
        }

        public SqlConnection GetSqlConnection()
        {
            return (!string.IsNullOrEmpty(this._connectionString)) ? new SqlConnection(this._connectionString) : null;
        }

        public DataSet LoadDataSet(string sqlQuery, QueryCommandType queryCommandType, List<IDataParameter> parameters)
        {
            return LoadDataSet(sqlQuery, "", queryCommandType, parameters);
        }

        public DataSet LoadDataSet(string sqlQuery, string tableName, QueryCommandType queryCommandType, List<IDataParameter> parameters)
        {
            if (string.IsNullOrEmpty(tableName) || string.IsNullOrWhiteSpace(tableName))
            {
                tableName = "DataTable1";
            }

            List<string> list = new List<string>();
            list.Add(tableName);
            return LoadDataSet(sqlQuery, list, queryCommandType, parameters);
        }

        public DataSet LaodDataSet(string sqlQuery, List<string> tableNames, QueryCommandType queryCommandType, List<IDbDataParameter> sqlParams)
        {
            DataSet dataSet = new DataSet();
            DbCommand dbCommand = null;
            try
            {
                SqlConnection sqlConnection = GetSqlConnection();
                DbDataAdapter dataAdapter = GetDataAdapter(dbCommand);
                dataAdapter.Fill(dataSet);

            }
        }

        private DbDataAdapter GetDataAdapter(DbCommand command)
        {
            return new SqlDataAdapter((SqlCommand)command);
        }

        private void GetParametersOutputValues(DbCommand cmd, List<IDbDataParameter> sqlParams)
        {
            if (!isOutputParameterExist)
            {
                return;
            }

            int num = 0;
            foreach (IDbDataParameter parameter in cmd.Parameters)
            {
                if (parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Output || parameter.Direction == ParameterDirection.ReturnValue)
                {
                    if (parameter.DbType == DbType.String)
                    {
                        sqlParams[num].Value = Convert.ToString(parameter.Value);
                    }
                    else
                    {
                        sqlParams[num].Value = parameter.Value;
                    }
                }

                num++;
            }
        }
    }
}
