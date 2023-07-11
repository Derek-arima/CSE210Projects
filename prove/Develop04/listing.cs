using System;

namespace Develop04;

public class ListingActivity : Activity
{   
    public ListingActivity() : base("Listing", "reflect on the good things in your life by listing as many things as you can in a certain area.")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    Timer _timer = new Timer();

    List<string> _prompts = new List<string>();
    public void listingActivity(int time)
    {
        beginMessage(time);

        Random rand = new Random();

        int index = rand.Next(_prompts.Count());

        Console.WriteLine(_prompts[index]);

        _timer.displayTimer(5);

        Console.WriteLine("List as many things as you can in the area of " + _prompts[index] + " in the next " + time + " seconds.");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        List<string> responses = new List<string>();

        while (endTime > DateTime.Now)
            {
                string response = Console.ReadLine();
                Console.WriteLine("Nice job! Keep going!");
                responses.Add(response);
            }
        Console.WriteLine("You listed " + responses.Count() + " responses");
        endMessage(time);
    } 
}