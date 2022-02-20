using System;

namespace BasicsPractice.Polymorphism
{
    public class ChildClass : ParentClass
    {
        public void PrintHello()
        {
            Console.WriteLine("ChildClass's PrintHello() invoked");
        }

        public override void PrintHelloOverridden()
        {
            Console.WriteLine("ChildClass's PrintHelloOverridden() invoked");
        }

        public new void PrintHelloNew()
        {
            Console.WriteLine("ChildClass's PrintHelloNew() invoked");
        }
    }
}
