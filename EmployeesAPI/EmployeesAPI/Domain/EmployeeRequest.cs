using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesAPI.Domain
{
    public class EmployeeRequest
    {
        public List<Employee> Employees { get; set; }
    }
}