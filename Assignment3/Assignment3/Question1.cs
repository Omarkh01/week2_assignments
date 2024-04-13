using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public static class Question1
    {
        public static void Main()
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        // Method to create an array of integers
        static int[] GenerateNumbers()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1; // Fills the array with numbers 1 to 10
            }
            return numbers;
        }

        // Method to reverse the contents of the array
        static void Reverse(int[] numbers)
        {
            int temp;
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
        }

        // Method to print the numbers in the array
        static void PrintNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine(); // Add a newline for cleaner output
        }
    }
}
