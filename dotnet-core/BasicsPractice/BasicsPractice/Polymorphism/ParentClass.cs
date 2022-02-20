using System;

namespace BasicsPractice.Polymorphism
{
    public class ParentClass
    {
        public virtual void PrintHello()
        {
            Console.WriteLine("ParentClass's PrintHello() invoked");
        }

        public virtual void PrintHelloOverridden()
        {
            Console.WriteLine("ParentClass's PrintHelloOverridden() invoked");
        }

        public virtual void PrintHelloNew()
        {
            // Console.WriteLine("ParentClass's PrintHelloNew() invoked");
        }
    }
}
