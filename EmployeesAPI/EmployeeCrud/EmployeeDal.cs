using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeCrud
{
    public class EmployeeDal
    {
        public static DataSet GetEmployees()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["EmployeeDB"]);
            SqlDataAdapter da = new SqlDataAdapter("[dbo].[GetEmployeeDetails]", connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "[dbo].[Employee]");
            return ds;
        }
    }
}
