using System;

namespace BasicsPractice.Abstract
{
    public class DerivedClass1 : AbstractBaseClass
    {
        public override void Print()
        {
            Console.WriteLine("DerivedClass1 Print() invoked");
        }

        public new void PrintHello()
        {
            Console.WriteLine("DerivedClass1 PrintHello() invoked");
        }
    }
}
