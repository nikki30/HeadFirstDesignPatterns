using System;
namespace Singleton
{
    public class SingletonClass
    {
        // Instantiating it statically eagerly (instead of the commented code)
        // ensures no multi-threading cases where two objects are created during parallel null checks being passed (only occurs during first time obj is created).
        private static SingletonClass singletonObj = new SingletonClass();
        private SingletonClass()
        {
        }

        public static SingletonClass GetSingletonObject()
        {
            // singletonObj ??= new SingletonClass();
            return singletonObj;
        }

        public static string GetProperties(SingletonClass obj)
        {
            return "so many properties";
        }
    }
}
