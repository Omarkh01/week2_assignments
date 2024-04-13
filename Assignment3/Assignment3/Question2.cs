using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Question2
    {
        public static void Main()
        {
            // Loop through the first 10 Fibonacci numbers and print them
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
            }
        }

        // Recursive method to find the Fibonacci number at the nth position
        static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0; // Not a valid position in Fibonacci terms, but handled for completeness
            }
            else if (n == 1 || n == 2)
            {
                return 1; // The first two Fibonacci numbers are 1
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursion
            }
        }
    }
}
