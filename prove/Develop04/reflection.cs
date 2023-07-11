using System;


namespace Develop04;

public class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _reflection.Add("Why was this experience meaningful to you?");
        _reflection.Add("Have you ever done anything like this before?");
        _reflection.Add("How did you get started?");
        _reflection.Add("How did you feel when it was complete?");
        _reflection.Add("What made this time different than other times when you were not as successful?");
        _reflection.Add("What is your favorite thing about this experience?");
        _reflection.Add("What could you learn from this experience that applies to other situations?");
        _reflection.Add("What did you learn about yourself through this experience?");
        _reflection.Add("How can you keep this experience in mind in the future?");
    }

    Timer _timer = new Timer();

    // list of prompts
    new List<string> _prompts = new List<string>();

    new List<string> _reflection = new List<string>();
    public void reflectionActivity(int time)
    {
        beginMessage(time);

        //randomly choose a prompt from _promts and display it to the user
        Random rand = new Random();

        int index = rand.Next(_prompts.Count());

        Console.WriteLine(_prompts[index]);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        // iterate through the _reflection array and display each string to the user, pausing for a couple seconds after each one
        int i = 0;
        
        while (endTime > DateTime.Now && i < _reflection.Count())
        {
            Console.WriteLine(_reflection[i]);
            i += 1;
            base.ShowSpinner(16);
        }
        
        endMessage(time);
    }
}