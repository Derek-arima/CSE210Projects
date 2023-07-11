using System;
using System.Threading;

namespace Develop04;

//time class that will be used to keep track of the time
public class Timer
{
    public void keepTime(int seconds)
    {
        int miliseconds = seconds * 1000;

        Thread.Sleep(miliseconds);
    }

    public void displayTimer(int seconds)
        {
            for (int i = seconds; i >= 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000); // Pause for 1 second
                }
        }
}

