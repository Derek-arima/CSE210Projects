using System;

namespace Develop05;

public class EternalGoals: Goals
{
        public override void recordEvent(string name)
    {
        Console.WriteLine(_fullGoal.Count());
        for (int i = 0; i < _fullGoal.Count(); i++)
        {
            Console.WriteLine(_fullGoal[i]);
            if (_fullGoal[i].Contains(name))
            {
                string match = _fullGoal[i];

                string[] status = match.Split(',');

                int points = int.Parse(status[4]);

                _points += points;

                Console.WriteLine($"You have earned {points} points!");
                Console.WriteLine($"You have {_points} points total!");
            }
                
        }

    }
}