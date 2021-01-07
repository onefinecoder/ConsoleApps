using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hello this is Brandon i=" + i);
                if (i == 9)
                    break; // break from the loop
            }
        }
    }
}
