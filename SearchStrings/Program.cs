using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string songLyrics = "You say goodbye, and I say hello";

            var result = songLyrics.StartsWith("You");
            Console.WriteLine(result);


            var resultContains = songLyrics.Contains("say");
            Console.WriteLine(resultContains);

            var resultEndsWith = songLyrics.EndsWith("hello");
            Console.WriteLine(resultEndsWith);

            //Console.WriteLine(songLyrics.Contains("greetings"));

        }
    }
}
