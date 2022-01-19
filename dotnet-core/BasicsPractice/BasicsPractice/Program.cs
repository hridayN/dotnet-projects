using BasicsPractice.Linq;
using BasicsPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EmployeeDepartmentQueries q1 = new EmployeeDepartmentQueries();
            PrintAllEmployeeDepttNames(q1.Employees, q1.Departments);*/
            // GetAllStudentsUsingLambdaExpression();
            // GetAllStudentsUsingSqlQuery();
            // PrintDivisbleBy2();
            // PositiveNosWithinSpecifiedRange(11);
            ArrayAndSqrtOfEachNumber(20);
        }
        static void PrintAllEmployeeNames(IEnumerable<Employee> Employees)
        {
        }
        static void PrintAllDepttNames(List<Department> Departments)
        {
        }
        static void PrintAllEmployeeDepttNames(IEnumerable<Employee> Employees, List<Department> Departments)
        {
        }
    
        static IEnumerable<Student> GetAllStudentsUsingLambdaExpression()
        {
            IEnumerable<Student> students = StudentData.GetAllStudents().Where(s => s.Gender == "Male");
            return students;
        }

        static IEnumerable<Student> GetAllStudentsUsingSqlQuery()
        {
            IEnumerable<Student> students = from student in StudentData.GetAllStudents()
                                            where student.Gender == "Male"
                                            select student;
            return students;
        }

        static void PrintDivisbleBy2()
        {
            int[] nums = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = 
                from num in nums
                where num % 2 == 0
                select num;
            foreach (var num in result)
            {
                Console.WriteLine("{0} is divisible by 2", num);
            }
        }

        static void PositiveNosWithinSpecifiedRange(int range)
        {
            int[] dataSource = new int[13] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var result = 
                from num in dataSource
                where (num >= 0 && num <= range) 
                select num;
            Console.Write("No.s: ");
            foreach (var num in result)
            {
                Console.Write("{0}, ", num);
            }
            Console.Write("are +ve and less than {0}", range);
        }

        static void ArrayAndSqrtOfEachNumber(int range)
        {
            int[] dataSource = new int[6] { 3, 9, 2, 8, 6, 5 };
            var results =
                from num in dataSource
                let square = num * num
                where square > range
                select new { num, square };
            foreach (var result in results)
            {
                Console.WriteLine("Number: {0}, Sqrt: {1}", result.num, result.square);
            }
        }
    }

}
