using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EmployeeCrud
{
    public class EmployeeDataBase
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["EmployeeDB"];
            }
        }
    }
}
