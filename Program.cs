using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            if (start>=end)
            {
                Console.WriteLine("\"start\" should be smaller than \"end\"");
                Console.ReadKey();
                return;
            }

            for (int i = start; i <= end; i++)
            {
                
                if (i % 3 == 0 && i % 5 == 0) //Divideds of 3 and 5
                {
                    Console.WriteLine("FizzBuzz");
                }                
                else if (i % 3 == 0) //Divideds of 3
                {
                    Console.WriteLine("Fizz");
                }                
                else if (i % 5 == 0)//Divideds of 5
                {
                    Console.WriteLine("Buzz");
                }
                else // Rest
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
