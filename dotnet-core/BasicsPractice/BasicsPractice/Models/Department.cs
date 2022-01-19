using System.Collections.Generic;

namespace BasicsPractice.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<int> EmployeeIds { get; set; }
    }
}
