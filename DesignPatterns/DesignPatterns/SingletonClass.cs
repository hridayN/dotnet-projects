using System;

namespace DesignPatterns
{
    /// <summary>
    /// Declaring this class as 'sealed', it can't be inherited
    /// </summary>
    public sealed class SingletonClass
    {
        private static int counter = 0;
        
        /// <summary>
        /// private constructor ensures class can be instantiated within itself only
        /// </summary>
        private SingletonClass()
        {
            counter++;
            Console.WriteLine("Counter: " + counter);
        }
        private static SingletonClass instance = null;
        public static SingletonClass GetInstance
        {
            get
            {
                // Here, we're only initializing new instance, if instance is null. This is called lazy initialization
                return instance ??= new SingletonClass();
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
