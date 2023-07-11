using System;

namespace Develop04
{
    public class BreathingActivity : Activity
    {

        public BreathingActivity() : base("Breathing", "relax through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }
        Timer _timer = new Timer();

        public void breathingActivity(int time)
        {  
            int roundedtime = roundToNearestTen(time);
            beginMessage(time);
            while (roundedtime > 0)
            {
                Console.WriteLine("Breathe in");
                _timer.displayTimer(5);
                roundedtime -= 5;
                Console.WriteLine("Breath Out");
                roundedtime -= 5;
                _timer.displayTimer(5);
            }
            endMessage(time);

        }
        private int roundToNearestTen(int time)
        {
            if (time % 10 == 0)
            {
                return time;
            }
            else if (time % 10 >= 5)
            {
                int remainder = time % 10;
                return time + (10 - remainder);
            }
            else
            {
                int remainder = time % 10;
                return time - remainder;
            }
        }   
    }
}