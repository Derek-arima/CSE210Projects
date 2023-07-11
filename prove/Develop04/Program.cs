using System;

namespace Develop04;

public class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ListingActivity listing = new ListingActivity();
        ReflectionActivity reflection = new ReflectionActivity();

        Console.WriteLine("Please choose an activity from the list below by entering the number of the activity.");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflection Activity");
        string input = Console.ReadLine();
        Console.WriteLine("How many seconds would you like to do this activity for?");
        string num = Console.ReadLine();

        int seconds = int.Parse(num);
        switch (input)
        {
            case "1":
                breathing.breathingActivity(seconds);
                break;
            case "2":
                listing.listingActivity(seconds);
                break;
            case "3":
                reflection.reflectionActivity(seconds);
                break;
            default:
                Console.WriteLine("Please enter a valid number.");
                break;
        }
    }
}