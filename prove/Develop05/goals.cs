using System;
using System.IO;
using System.Collections.Generic;

namespace Develop05;

public class Goals
{
    public int _points = 0;

    public List<string> _goals = new List<string>();
    public List<string> _fullGoal = new List<string>();
    public List<string> _completed = new List<string>();

    public void createGoals(string completed, string type, string name, string desc, string points, string progress, string totalProgress)
    {
        string goal = completed + ", " + name + ", " + desc + "," + progress + "/" + totalProgress;
        _goals.Add(goal);

        string fullGoal = completed + ", " + name + ", " + desc + ", " + type + ", " + points + "," + progress + "/" + totalProgress;
        _fullGoal.Add(fullGoal);

        Console.WriteLine("Goal created!");
    }

    public void displayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]}");
        }
    }

    public void saveGoals(string filepath)
    {
        using (StreamWriter writer = new StreamWriter(filepath, true))
            {
                // Iterate over the list and append each element to the file
                foreach (string fullGoal in _fullGoal)
                {
                    writer.WriteLine(fullGoal);
                }
            }
    }

    public void loadGoals(string filepath)
    {
        string[] textFromFile = File.ReadAllLines(filepath);
                foreach(string line in textFromFile)
                {
                    if (line.Trim() == "")
                    {
                        continue;
                    }
                    // Split the line into the date, prompt, and response
                    string[] parts = line.Split(',');
                    
                    string completed = parts[0];
                    string type = parts[1];
                    string name = parts[2];
                    string desc = parts[3];
                    string points = parts[4];
                    string progress = parts[5];

                    string goal = completed + ", " + name + ", " + desc + ", " + progress;
                    _goals.Add(goal);

                    string fullGoal = completed + ", " + name + ", " + desc + ", " + type + ", " + points + ", " + progress;

                    _fullGoal.Add(fullGoal);

                }
    }
    

    public virtual void recordEvent(string name)
    {

        for (int i = 0; i < _fullGoal.Count(); i++)
        {
            if (_fullGoal[i].Contains(name))
            {
                string match = _fullGoal[i];

                string[] status = match.Split(',');

                int points = int.Parse(status[4]);

                _points += points;

                Console.WriteLine($"You have earned {points} points!");
                Console.WriteLine($"You have {_points} points total!");

                if (status[0] == "[ ]")
                {
                    status[0] = "[X]";

                    _fullGoal[i] = status[0] + ", " + status[1] + ", " + status[2] + ", " + status[3] + ", " + status[4] + ", " + status[5];

                    _goals[i] = status[0] + ", " + status[1] + ", " + status[2];

                }
            }
        }

    }
}