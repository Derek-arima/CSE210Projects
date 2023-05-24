using System;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();
            DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int num = 0;
            num = int.Parse(Console.ReadLine());
            return num;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string username, int square)
        {
            Console.WriteLine($"{username}, The square of your number is: {square}");
        }
    }
}