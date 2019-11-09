using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics
{
    class Basics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method");

            // ConstructorConcepts();

            Add(1, 5);
            Add(1, 5, 6);
        }

        #region Constructor Concepts
        static void ConstructorConcepts()
        {
            // If we have parameterized constructor, default constructor will not be called automatically
            Customer customer = new Customer();
            Console.Write("Names by default constructor: ");
            customer.PrintNames();

            Customer paramCustomer = new Customer("Hridaya", "Nagaria");
            Console.Write("Names by parameterized constructor: ");
            paramCustomer.PrintNames();

            Circle circle = new Circle(1);
            Console.WriteLine("Circle area: " + circle.GetArea());
            Console.ReadLine();
        }
        #endregion

        #region MethodOverloading based on number of arguments
        static void Add(int n1, int n2)
        {
            Console.WriteLine("Sum: {0}", (n1 + n2));
        }
        static void Add(int n1, int n2, int n3)
        {
            Console.WriteLine("Sum: {0}", (n1 + n2 + n3));
        }
        #endregion

        #region MethodOverloading based on type of arguments
        static void Add(float n1, float n2)
        {
            Console.WriteLine("Sum: {0}", (n1 + n2));
        }
        static void Add(float n1, int n2)
        {
            Console.WriteLine("Sum: {0}", (n1 + n2));
        }

        static void Add(int n1, float n2)
        {
            Console.WriteLine("Sum: {0}", (n1 + n2));
        }
        #endregion

        #region Role of Properties

        #endregion
    }

    class Customer
    {
        string FirstName;
        string LastName;

        // Default parameter-less constructor
        public Customer() : this("NA", "NA")
        {
        }

        // Parameterized constructor
        public Customer(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void PrintNames()
        {
            // Console.WriteLine("typeof FirstName: " + typeof(FirstName));
            if (this.FirstName != "NA" && this.LastName != "NA")
            {
                Console.WriteLine("FullName: " + this.FirstName + " " + this.LastName);
            }
            else
            {
                Console.WriteLine("FullName: " + "NA");
            }

        }
    }

    class Circle
    {
        public static float Pi;
        public int Radius;

        static Circle()
        {
            Console.WriteLine("Static constructor invoked");
            Pi = 3.141f;
        }

        public Circle(int Radius)
        {
            Console.WriteLine("Instance constructor invoked");
            this.Radius = Radius;
        }

        public float GetArea()
        {
            return (Pi);
        }
    }

    public class Student
    {
        private int Id;
        private string Name;
        private int PassingMarks;

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("StudentId can't be negative");
            }else
            {
                this.Id = Id;
            }
        }

        public int GetId()
        {
            return this.Id;
        }

        public void SetName(string Name)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                this.Name = Name;
            }else
            {
                throw new Exception("Name can't be negative");
            }
        }

        public string GetName()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                return this.Name;
            } else
            {
                return "No Name!";
            }
        }
    }
}
