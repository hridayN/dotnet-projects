using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesAPI.Domain
{
    public class Employee
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public long Salary { get; set; }
    }
}