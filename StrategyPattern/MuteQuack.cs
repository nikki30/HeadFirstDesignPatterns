namespace DuckCode
{
    using System;

    public class MuteQuack : QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
