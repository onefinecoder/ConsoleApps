using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
        }
    }
}
