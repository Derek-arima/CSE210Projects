using System;

namespace Prep4
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int num = -1;
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            do
            {
                Console.Write("Enter a number: ");
                string enteredNum = Console.ReadLine();
                num = int.Parse(enteredNum);

                if (num != 0)
                {
                    numbers.Add(num);
                }

            }while (num != 0);

            int sum =0;
            int high = 0;

            for(int i=0;i<numbers.Count;i++)
            {
                sum += numbers[i];
                if (numbers[i] > high)
                {
                    high = numbers[i];
                }
            }

            double average = numbers.Count > 0 ? numbers.Average() : 0.0;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {high}");


        }
    }
}