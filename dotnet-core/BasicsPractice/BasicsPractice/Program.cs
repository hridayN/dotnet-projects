using BasicsPractice.Linq;
using BasicsPractice.Models;
using BasicsPractice.Polymorphism;
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
            // ArrayAndSqrtOfEachNumber(20);
            // DisplayNumberAndItsFrequency();
            // DisplayCharAndItsFrequency();
            // DisplayNumberMultiplicationAndItsFrequency();
            // DisplayStringStartAndEndMatch();
            // DisplayTopNthRecordsInDesc(3);
            // DisplayUpperCaseOnly();
            // GetNthGradeStudent(5);
            // DerivedClass1 derivedClass1 = new DerivedClass1();
            // Console.WriteLine(string.Format("Reverse of {0} is {1}", "8*(7-9)/2", GetReverse("8*(7-9)/2")));
            // GetInfixToPrefix();

            /*Shape shape = new Shape()
            {
                Name = "NoShape"
            };
            Console.WriteLine("shape: " + shape.Name);
            ChangeShape(shape);
            Console.WriteLine("shape: " + shape.Name);*/

            /*string shpe = "NoShape";
            Console.WriteLine("shape: " + shpe);
            Change(shpe);
            Console.WriteLine("shape: " + shpe);*/

            ParentClass parentClassObject = new ParentClass();
            // parentClassObject.PrintHello();

            // If we don't override the ParentClass's method, it'll execute ParentClass's PrintHello() only
            parentClassObject = new ChildClass();
            // parentClassObject.PrintHello();
            // parentClassObject.PrintHelloOverridden();
            parentClassObject.PrintHelloNew();
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

        /*static IEnumerable<Student> GetAllStudentsUsingLambdaExpression()
        {
            IEnumerable<Student> students = StudentData.GetAllStudents().Where(s => s.Gender == "Male");
            return students;
        }*/

        /*static IEnumerable<Student> GetAllStudentsUsingSqlQuery()
        {
            IEnumerable<Student> students = from student in StudentData.GetAllStudents()
                                            where student.Gender == "Male"
                                            select student;
            return students;
        }*/

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

        static void DisplayNumberAndItsFrequency()
        {
            int[] dataSource = new int[18] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var results =
                from num in dataSource
                group num by num into frequency
                select frequency;
            foreach (var result in results)
            {
                Console.WriteLine("Number: {0}, Frequency: {1}", result.Key, result.Count());
            }
        }

        static void DisplayCharAndItsFrequency()
        {
            string str = "hridaya nagaria";
            var results =
                from c in str
                group c by c into frequency
                select frequency;
            foreach (var result in results)
            {
                Console.WriteLine("Character: {0}, Frequency: {1}", result.Key, result.Count());
            }
        }

        static void DisplayNumberMultiplicationAndItsFrequency()
        {
            int[] dataSource = new int[18] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var results =
                from num in dataSource
                group num by num into frequency
                select frequency;
            foreach (var result in results)
            {
                Console.WriteLine("Number: {0}, Frequency: {1}, Number*Frequency: {2}", result.Key, result.Count(), (result.Key * result.Count()));
            }
        }

        static void DisplayStringStartAndEndMatch()
        {
            string[] dataSource = new string[9] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var results =
                from value in dataSource
                where value.StartsWith('A') && value.EndsWith('M')
                select value;
            foreach (var result in results)
            {
                Console.WriteLine("Matching value: {0}", result);
            }
        }

        static void DisplayTopNthRecordsInDesc(int topN)
        {
            List<int> dataSource = new List<int>() { 5, 7, 13, 24, 6, 9, 8, 7 };
            dataSource.Sort();
            dataSource.Reverse();
            foreach (int value in dataSource.Take(topN))
            {
                Console.Write(value + ", ");
            }
        }

        static void DisplayUpperCaseOnly()
        {
            string value = "this IS a STRING";
            var results = from c in value
                          let intEq = (int)c
                          // 32 for ascii of space
                          where (intEq == 32 || (intEq >= 65 && intEq <= 90))
                          select c;
            foreach (var result in results)
            {
                Console.Write(string.Format("{0}", result));
            }
        }

        static void GetNthGradeStudent(int grade)
        {
            List<Student> dataSource = StudentData.GetStudentsMarksData();
            var results = (from student in dataSource
                           group student by student.GradePoints into g
                           orderby g.Key descending
                           select new { record = g.ToList() }).ToList();
            results[grade - 1].record.ForEach(s => Console.WriteLine(string.Format("Id : {0},  Name : {1},  achieved Grade Point : {2}", s.Id, s.Name, s.GradePoints)));
        }

        // Continue from Problem 16

        static void GetInfixToPrefix()
        {
            string infix = "8*(7-9)/2";
            infix = GetReverse(infix);
            string prefix = "", operations = "";
            List<char> stack = new List<char>();
            foreach (char c in infix)
            {
                if (operations.Contains('(') && c == ')')
                {
                    stack.Add(operations[operations.Length - 1]);
                    char[] chars = operations.ToCharArray();
                    chars[chars.Length - 1] = '\0';
                    operations = new string(chars);
                    operations = operations.Replace("(", "");

                    chars = operations.ToCharArray();
                    for (int i = 0; i < chars.Length; i++)
                    {
                        stack.Add(chars[i]);
                        chars[i] = '\0';
                    }
                    operations = new string(chars);
                } else
                {
                    try
                    {
                        int i = int.Parse(c.ToString());
                        stack.Add(c);
                    } catch (Exception ex)
                    {
                        operations += c;
                    }
                }
            }
            
            foreach(char ch in stack)
            {
                prefix += ch;
            }

            prefix = GetReverse(prefix);
            Console.WriteLine("Prefix: {0}", prefix);
            Console.WriteLine("operations: {0}", operations);
        }

        static string GetReverse(string input)
        {
            // infix = "8*(7-9)/2", 
            string reverseInfix = "";
            int length = input.Length - 1;
            while (length >= 0)
            {
                char ch = input[length];
                if (ch == '(')
                {
                    ch = ')';
                }
                else
                {
                    if (ch == ')')
                    {
                        ch = '(';
                    }
                }
                reverseInfix += ch;
                length--;
            }
            Console.WriteLine("reversed : {0}", input);
            return reverseInfix;
        }
    
        static void ChangeShape(ref Shape shape)
        {
            shape.Name = "Changed";
            Console.WriteLine("shape: " + shape.Name);
        }

        static void ChangeShape(Shape shape)
        {
            shape.Name = "Changed";
            Console.WriteLine("shape: " + shape.Name);
        }

        static void Change(ref string shape)
        {
            shape = "Changed";
            Console.WriteLine("shape: " + shape);
        }

        static void Change(string shape)
        {
            shape = "Changed";
            Console.WriteLine("shape: " + shape);
        }
    }

    class Shape
    {
        public string Name { get; set; }
    }
}
