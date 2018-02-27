using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            String numFizz = "";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    numFizz = "FizzBuzz";
                    Console.WriteLine(numFizz);
                }
                else if (i % 3 == 0)
                {
                    numFizz = "Fizz";
                    Console.WriteLine(numFizz);
                }
                else if (i % 5 == 0)
                {
                    numFizz = "Buzz";
                    Console.WriteLine(numFizz);
                }
                else
                {
                    numFizz = i.ToString();
                    Console.WriteLine(i);
                }
            }

        }
    }
}
