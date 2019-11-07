using System;

namespace Polymorphism
{
    class Polymorphism
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Polymorphism");

            // ImplementPolymorphism();

            // OverridingVsHiding();
            Console.ReadLine();
        }

        static void ImplementPolymorphism()
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();

            // Creating Parent/Base class reference to Child/Derived class Object
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }

        static void OverridingVsHiding()
        {
            BaseClass baseClass = new DerivedClass();
            baseClass.Print();
        }
    }

    public class Employee
    {
        public string FirstName = "Full";
        public string LastName = "Name";

        public virtual void PrintFullName()
        {
            Console.WriteLine("Fullname: {0}", FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee: Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Fullname: {0}", FirstName + " " + LastName + " - Fulltime");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Fullname: {0}", FirstName + " " + LastName + " - Parttime");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Fullname: {0}", FirstName + " " + LastName + " - Temporary");
        }
    }

    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I'm a Base class method");
        }
    }

    public class DerivedClass : BaseClass
    {
        // Method Overriding
        //public override void Print()
        //{
        //    Console.WriteLine("I'm a Derived class method");
        //}

        // Method Hiding
        public new void Print()
        {
            Console.WriteLine("I'm a Derived class method");
        }
    }
}
