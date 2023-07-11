using System;

namespace Develop04;

public class Activity
{
    public Activity(string name, string desc)
    {
        _name = name;
        _desc = desc;
    }

    private Timer _timer = new Timer();
    protected string _name = "Generic";
    protected string _desc = "Generic activity description.";

    protected void beginMessage(int time)
    {
        Console.WriteLine($"Hello you have chosen the {_name} activity for {time} seconds. In this activity you will {_desc}. Prepare to begin.");

        ShowSpinner(24);
    }

    protected void endMessage(int time)
    {
        Console.WriteLine($"You have completed the {_name} activity for {time} seconds. Good job!");

        ShowSpinner(24);
    }

    protected void ShowSpinner(int timespecified)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        int index = 0;

        int time = 0;

        while (time != timespecified) 
        {
            Console.Write(spinner[index]);
            Console.CursorLeft = Console.CursorLeft - 1;
            index = (index + 1) % spinner.Length;

            Thread.Sleep(250); // Pause for 0.25 seconds
            time += 1;
        }
    }
}