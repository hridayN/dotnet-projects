using BasicsPractice.Models;
using System.Collections.Generic;

namespace BasicsPractice.Linq
{
    public class EmployeeDepartmentQueries
    {
        public IEnumerable<Employee> Employees = new List<Employee>() 
        {
            new Employee()
            {
                Id = 1,
                FirstName = "E1F",
                LastName = "E1L",
            },
            new Employee()
            {
                Id = 2,
                FirstName = "E2F",
                LastName = "E2L",
            },
            new Employee()
            {
                Id = 3,
                FirstName = "E3F",
                LastName = "E3L",
            },
            new Employee()
            {
                Id = 4,
                FirstName = "E4F",
                LastName = "E4L",
            },
            new Employee()
            {
                Id = 5,
                FirstName = "E5F",
                LastName = "E5L",
            }
        };

        public List<Department> Departments = new List<Department>() 
        {
            new Department()
            {
                Id = 1,
                Name = "D1",
                EmployeeIds = new List<int>()
                {
                    1, 2
                }
            },
            new Department()
            {
                Id = 2,
                Name = "D2",
                EmployeeIds = new List<int>()
                {
                    3, 4, 5
                }
            }
        };
    }
}
