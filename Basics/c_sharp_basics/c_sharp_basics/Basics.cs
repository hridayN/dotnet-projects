using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics
{
    public class Basics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method");

            // ConstructorConcepts();

            // Add(1, 5);
            // Add(1, 5, 6);

            // StructsImplementation();

            // ValueVsReference();

            //GuidBasics guidBasics = new GuidBasics();
            //guidBasics.PrintGuid();

            // MultipleTypesInArray();

            BasicFundamentals basic = new BasicFundamentals();
            basic.Name = "Hriday";
            Console.WriteLine("Name is: " + basic.Name);
            Console.ReadLine();
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
        // 1. We can use get()/set() method for getting/setting the properties
        // 2. We can use auto implemented get/set for getting/setting the properties
        #endregion

        #region Structs
        static void StructsImplementation()
        {
            CustomerDetails _cd = new CustomerDetails(1, "hriday");
            _cd.PrintCustomerDetails();

            CustomerDetails _cd1 = new CustomerDetails();
            _cd1.PrintCustomerDetails();

            CustomerDetails _cd2 = new CustomerDetails();
            _cd2.Id = 3;
            _cd2.Name = "hn";
            _cd2.PrintCustomerDetails();

            _cd.PrintCustomerDetails();
        }
        #endregion

        #region Value type vs Reference type
        public static void ValueVsReference()
        {
            // Value type change
            // int i = 0;
            // int j = 0;
            // i = 10;
            // j = i;
            // Console.WriteLine("i: {0}, j: {1}", i, j);
            // j = j + 1;
            // Console.WriteLine("i: {0}, j: {1}", i, j);

            // Value type changes in struct
            // CustomerDetails _cd1 = new CustomerDetails();
            // _cd1.Id = 1;
            // _cd1.Name = "hriday";
            // Console.WriteLine("_cd1 details: Id: {0}, Name: {1}", _cd1.Id, _cd1.Name);
            // 
            // CustomerDetails _cd2 = _cd1;
            // Console.WriteLine("_cd2 details: Id: {0}, Name: {1}", _cd2.Id, _cd2.Name);
            // _cd2.Id = 5;
            // _cd2.Name = "h";
            // 
            // Console.WriteLine("_cd2 details: Id: {0}, Name: {1}", _cd2.Id, _cd2.Name);
            // 
            // Console.WriteLine("_cd1 details: Id: {0}, Name: {1}", _cd1.Id, _cd1.Name);

            // Reference type changes in class
            Customer _c1 = new Customer("first", "last");
            Customer _c2 = _c1;
            _c2.FirstName = "last";
            _c1.PrintNames();
        }
        #endregion

        #region Multiple types in an object array
        public static void MultipleTypesInArray()
        {
            Customer c = new Customer();
            c.FirstName = "hriday";
            c.LastName = "nagaria";

            object[] arr = new object[3];
            arr[0] = 1;
            arr[1] = "name";
            arr[2] = c;

            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
            }
        }
        #endregion
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

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

        public override string ToString()
        {
            return this.FirstName + ", " + this.LastName;
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
            }
            else
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
            }
            else
            {
                throw new Exception("Name can't be negative");
            }
        }

        public string GetName()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                return this.Name;
            }
            else
            {
                return "No Name!";
            }
        }
    }

    public struct CustomerDetails
    {
        private int _id;
        private string _name;
        public string Name { get { return this._name; } set { this._name = value; } }
        public int Id { get { return this._id; } set { this._id = value; } }

        public CustomerDetails(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintCustomerDetails()
        {
            Console.WriteLine("Id: {0}, Name: {1}", this._id, this._name);
        }
    }

    public class GuidBasics
    {
        private Guid guid;

        public void PrintGuid()
        {
            // guid = Guid.NewGuid();
            Console.WriteLine("guid: ", Guid.NewGuid());

            // guid = new Guid();
            Console.WriteLine("guid: ", new Guid());
        }
    }

    public class BasicFundamentals
    {
        private string name = nameof(Name);

        public string SetName()
        {
            name = Name;
            return name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
