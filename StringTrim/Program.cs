using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTrim
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "       Hello World        ";
            Console.WriteLine($"[{greeting}]");

            string trimmedgreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedgreeting}]");

             trimmedgreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedgreeting}]");

            trimmedgreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedgreeting}]");



            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());




        }
    }
}
