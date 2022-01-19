using BasicsPractice.Models;
using System.Collections.Generic;

namespace BasicsPractice.Linq
{
    public class StudentData
    {
        public static List<Student> GetAllStudents()
        {
            List<Student> Students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Student 1",
                    Gender = "Male"
                },
                new Student()
                {
                    Id = 2,
                    Name = "Student 2",
                    Gender = "Male"
                },
                new Student()
                {
                    Id = 3,
                    Name = "Student 3",
                    Gender = "Female"
                },
                new Student()
                {
                    Id = 4,
                    Name = "Student 4",
                    Gender = "Female"
                }
            };
            return Students;
        }
    }
}
