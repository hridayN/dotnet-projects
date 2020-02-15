using EmployeesAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAPI.Contract
{
    public interface IEmployee
    {
        List<Employee> GetEmployees(long id);

        EmployeeResponse SaveEmployee(EmployeeRequest employeeRequest);
    }
}
