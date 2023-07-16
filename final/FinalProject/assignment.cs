using System;

namespace FinalProject;

public class Assignments
{
    protected List<string> _assignments = new List<string>();

    public List<string> getAssignments()
    {
        return _assignments;
    }
    public void setAssignments(string createNewAssignment)
    {
        _assignments.Add(createNewAssignment);
    }
    public void createAssignment(string name, string points, string type, string dueDate, string classType)
    {
        string assignment = dueDate + ", " + name + ", " + type + ", " + points + ", " + classType;
        _assignments.Add(assignment);
    }

    public virtual void displayAssignments()
    {
        for (int i = 0; i < _assignments.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_assignments[i]}");
        }
    }

    public void saveAssignments()
    {
        using (StreamWriter writer = new StreamWriter("assignments.txt", true))
            {
                // Iterate over the list and append each element to the file
                foreach (string assignment in _assignments)
                {
                    writer.WriteLine(assignment);
                }
            }
    }

    public void loadAssignments()
    {
        string[] textFromFile = File.ReadAllLines("assignments.txt");

        foreach(string line in textFromFile)
        {
            if (line.Trim() == "")
            {
                continue;
            }
            // Split the line into the date, prompt, and response
            string[] parts = line.Split(',');
            
            string dueDate = parts[0];
            string name = parts[1];
            string type = parts[2];
            string points = parts[3];
            string classType = parts[4];
            string assignment = dueDate + ", " + name + ", " + type + ", " + points + ", " + classType;
            _assignments.Add(assignment);
        }
                
    }
}