using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // FullTimeEmployee_DerivedClass fte = new FullTimeEmployee_DerivedClass();
            // fte.FirstName = "full";
            // fte.LastName = "name";
            // fte.FullTimeSalary = 1000.6f;
            // fte.PrintFullName();

            // Typecasting the object of child/derived class into the object of parent/derived class
            // ((EmployeeDetails_BaseClass)fte).PrintFullName();

            // Objective: To call parent/base class method.
            // Way 1: Create a reference of parent type to Child type.
            EmployeeDetails_BaseClass empBase = new FullTimeEmployee_DerivedClass();
            empBase.PrintFullName();

            // PartTimeEmployee_DerivedClass pte = new PartTimeEmployee_DerivedClass();
            // pte.FirstName = "part";
            // pte.LastName = "time";
            // pte.PartTimeRate = 10.6f;
            // pte.PrintFullName();


            Console.ReadLine();
        }
    }

    public class EmployeeDetails_BaseClass
    {
        public string FirstName;
        public string LastName;
        public string Email;

        //public EmployeeDetails_BaseClass()
        //{
        //    Console.WriteLine("EmployeeDetails_BaseClass constructor();");
        //}

        //public EmployeeDetails_BaseClass(string Message)
        //{
        //    Console.WriteLine("Message: {0}", Message);
        //}

        public void PrintFullName()
        {
            Console.WriteLine("EmployeeDetails_BaseClass PrintFullName()");
        }
    }

    public class FullTimeEmployee_DerivedClass : EmployeeDetails_BaseClass
    {
        public float FullTimeSalary;
        // with base(), we can control which constructor of the parent/derived class to be executed
        //public FullTimeEmployee_DerivedClass():base()
        //{
        //    Console.WriteLine("FullTimeEmployee_DerivedClass constructor();");
        //}

        // Creating the same method as of the parent/derived class
        // Way 1: Declare the method as 'new'. Using new keyword hides the same method of the parent/base class
        //public new void PrintFullName()
        //{
        //    Console.WriteLine("FullTimeEmployee_DerivedClass PrintFullName()");
        //}

        // Way 2: calling the method of parent/derived class with base
        //public new void PrintFullName()
        //{
        //    base.PrintFullName();
        //    // Console.WriteLine("FullTimeEmployee_DerivedClass PrintFullName()");
        //}

        // Way 3: Typecasting the method of derived/child class into the object of Base/parent class
        // see in Main()


        public new void PrintFullName()
        {
            Console.WriteLine("FullTimeEmployee_DerivedClass PrintFullName()");
        }
    }

    public class PartTimeEmployee_DerivedClass : EmployeeDetails_BaseClass
    {
        public float PartTimeRate;
        public PartTimeEmployee_DerivedClass()
        {
            Console.WriteLine("PartTimeEmployee_DerivedClass constructor();");
        }
    }

}
