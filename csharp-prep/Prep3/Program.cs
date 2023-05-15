using System;


namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1,100);
            int guess = -1;
            do
            {
                Console.Write("What is your guess?");
                string guessString = Console.ReadLine();
                guess = int.Parse(guessString);

                if (guess > number)
                {
                    Console.Write("Lower\n");
                }

                else if (guess < number)
                {
                    Console.Write("Higher\n");
                }

                else
                {
                    Console.Write("You guessed it!");
                }
            }while (guess != number);

        }
    }
}