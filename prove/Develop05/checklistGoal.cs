using System;

namespace Develop05;

public class CheckListGoals: Goals
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


                string[] progress = status[5].Split('/');

                int numProgress = int.Parse(progress[1]);

                string numNew = (numProgress - 1).ToString();

                if (progress[0] == numNew)
                {
                    
                    if (status[0] == "[ ]")
                    {
                    status[0] = "[X]";
                    _fullGoal[i] = status[0] + ", " + status[1] + ", " + status[2] + ", " + status[3] + ", " + status[4] + ", " + status[5];

                    _goals[i] = status[0] + ", " + status[1] + ", " + status[2];
                    }
                }   

                else
                {
                    int change = int.Parse(progress[0]);
                    change++;
                    progress[0] = change.ToString();

                    status[5] = progress[0] + "/" + progress[1];

                    _fullGoal[i] = status[0] + ", " + status[1] + ", " + status[2] + ", " + status[3] + ", " + status[4] + ", " + status[5];

                    _goals[i] = status[0] + ", " + status[1] + ", " + status[2] + ", " + status[5];
                }
                    
                
            }
        }

    }
}