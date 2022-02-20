using System;

namespace BasicsPractice
{
    public abstract class AbstractBaseClass
    {
        public AbstractBaseClass()
        {
            // as soon as the constructor of the class inheriting this class is called, the Print method overridden in the derived class will be executed
            Print();
            Console.WriteLine("".GetHashCode());
        }

        public abstract void Print();

        public virtual void PrintHello()
        {
            Console.WriteLine("AbstractBaseClass PrintHello() invoked");
        }
    }
}
