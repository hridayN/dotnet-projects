using EmployeesAPI.Contract;
using EmployeesAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeCrud;
using System.Data;
using Employee = EmployeesAPI.Domain.Employee;

namespace EmployeesAPI.Core
{
    public class EmployeeService : IEmployee
    {
        public List<Employee> GetEmployees(long id = 0)
        {
            List<Employee> employees = new List<Employee>();
            #region Database activity
            DataSet ds = EmployeeDal.GetEmployees();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    Employee employee = new Employee()
                    {
                        Id = dr.Field<long>("Id"),
                        Name = dr.Field<string>("Name"),
                        Gender = dr.Field<string>("Gender"),
                        Salary = dr.Field<long>("Salary")
                    };
                    employees.Add(employee);
                }
            }
            #endregion
            return employees;
        }

        public EmployeeResponse SaveEmployee(EmployeeRequest employeeRequest)
        {
            EmployeeResponse employeeResponse = new EmployeeResponse();
            #region Database activity
            #endregion
            return employeeResponse;
        }
    }
}