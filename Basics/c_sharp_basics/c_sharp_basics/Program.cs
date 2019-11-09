using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics
{
    class Program
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
}
