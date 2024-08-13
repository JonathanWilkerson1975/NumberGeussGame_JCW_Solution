using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGeussGame_JCW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correctNumber = random.Next(1, 11); // Generates a random number between 1 and 10
            int guess = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess what it is?");

            while (guess != correctNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    if (guess < 1 || guess > 10)
                    {
                        Console.WriteLine("Please guess a number between 1 and 10.");
                    }
                    else if (guess < correctNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > correctNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You guessed the correct number.");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a valid number. Please enter a number between 1 and 10.");
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
