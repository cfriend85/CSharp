using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 1; i < 101; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                    Console.WriteLine(i);
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    Console.WriteLine(i);
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    Console.WriteLine(i);
                }
            }
        }
    }
}
