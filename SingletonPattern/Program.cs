using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = SingletonClass.GetSingletonObject();
            Console.WriteLine(SingletonClass.GetProperties(obj));
        }
    }
}
