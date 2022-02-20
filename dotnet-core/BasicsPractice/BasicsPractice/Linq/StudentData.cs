using BasicsPractice.Models;
using System.Collections.Generic;

namespace BasicsPractice.Linq
{
    public class StudentData
    {
        public static List<Student> GetStudentsMarksData()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Joseph", GradePoints = 800 });
            students.Add(new Student() { Id = 2, Name = "Alex", GradePoints = 458 });
            students.Add(new Student() { Id = 3, Name = "Harris", GradePoints = 900 });
            students.Add(new Student() { Id = 4, Name = "Taylor", GradePoints = 900 });
            students.Add(new Student() { Id = 5, Name = "Smith", GradePoints = 458 });
            students.Add(new Student() { Id = 6, Name = "Natasa", GradePoints = 700 });
            students.Add(new Student() { Id = 7, Name = "David", GradePoints = 750 });
            students.Add(new Student() { Id = 8, Name = "Harry", GradePoints = 597 });
            return students;
        }
    }
}
