using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            GreetWhite();
            Greetblack();
        }

        static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }

        static void Greetblack()
        {
            Console.WriteLine("hello black");
        }
    }
}

