using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class Practice2
    {
        public void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintPyramid()
        {
            int totalLevels = 5; // The total number of levels in the pyramid

            for (int level = 1; level <= totalLevels; level++)
            {
                // Print spaces
                for (int space = 1; space <= totalLevels - level; space++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int star = 1; star <= 2 * level - 1; star++)
                {
                    Console.Write("*");
                }

                // Move to the next line
                Console.WriteLine();
            }
        }

        public void GuessNumber()
        {
            Random r = new Random();
            int randomNum = r.Next(3) + 1;
            Console.WriteLine("Guess the random number between 1 and 3");
            Console.WriteLine("Enter your guess: ");
            int guessedNum = Convert.ToInt32(Console.ReadLine());

            while (randomNum != guessedNum)
            {
                if (guessedNum > 3 || guessedNum < 1)
                {
                    Console.WriteLine("The guess range is from 1 to 3.");
                }
                else if (randomNum < guessedNum)
                {
                    Console.WriteLine("You guessed high.");
                }
                else
                {
                    Console.WriteLine("You guessed low");
                }
                Console.WriteLine("Guess again: ");
                guessedNum = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You guess is right!");
        }

        public void NextAnniversary()
        {
            // Define a birth date
            DateTime birthDate = new DateTime(1995, 12, 15); // Set this to the actual birth date

            // Calculate age in days
            DateTime today = DateTime.Today;
            int daysOld = (today - birthDate).Days;

            // Calculate the next 10,000 day anniversary
            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);

            // Output results
            Console.WriteLine($"You are {daysOld} days old.");
            Console.WriteLine($"Your next 10,000 day anniversary will be on {nextAnniversary.ToShortDateString()}.");
        }

        public void TimeBasedGreeting()
        {
            // Uncomment the following line to use the current time
            // DateTime currentTime = DateTime.Now;

            // For testing, you can use a fixed time
            DateTime currentTime = new DateTime(2022, 10, 1, 23, 0, 0); // Change this to test different times

            int hour = currentTime.Hour;

            // Determine and print the appropriate greeting
            if (hour >= 5 && hour < 12)
            {
                Console.WriteLine("Good Morning!");
            }

            if (hour >= 12 && hour < 17)
            {
                Console.WriteLine("Good Afternoon!");
            }

            if (hour >= 17 && hour < 21)
            {
                Console.WriteLine("Good Evening!");
            }

            if (hour >= 21 || hour < 5)
            {
                Console.WriteLine("Good Night!");
            }
        }

        public void CountingIncrements()
        {
            // Outer loop to set the increment from 1 to 4
            for (int increment = 1; increment <= 4; increment++)
            {
                // Start the inner loop from 0, counting up to 24
                for (int number = 0; number <= 24; number += increment)
                {
                    // Check if it's the last number to print for the current increment to avoid trailing comma
                    if (number + increment > 24)
                        Console.Write(number);
                    else
                        Console.Write(number + ",");
                }
                // Move to the next line for the next increment
                Console.WriteLine();
            }
        }
    }
}
