using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass instance = SingletonClass.GetInstance;
            instance.PrintMessage("Hello");

            SingletonClass instance2 = SingletonClass.GetInstance;
            instance2.PrintMessage("Hello again");
        }
    }
}
