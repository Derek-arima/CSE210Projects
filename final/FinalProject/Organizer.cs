using System;

namespace FinalProject;
public class Organizer: Assignments
{
    
    private List<DateTime> _dueDate = new List<DateTime>();

    List<AssignmentInfo> tasks = new List<AssignmentInfo>();

    

    public override void displayAssignments()
    {
        for (int i = 0; i < _assignments.Count(); i++)
        {   
            string[] assignmentAttributes = _assignments[i].Split(',');
            string dueDate = assignmentAttributes[0];
            string name = assignmentAttributes[1];
            string type = assignmentAttributes[2];
            string points = assignmentAttributes[3];
            string classType = assignmentAttributes[4];

            
            DateTime date = DateTime.ParseExact(dueDate, "MM/dd/yyyy", null);

            tasks.Add(new AssignmentInfo(_assignments[i], date, type));
        }


        // Sorting the tasks based on the dates in ascending order
        tasks.Sort((a, b) => a.Date.CompareTo(b.Date));
        tasks.Sort((a, b) => b.Type.CompareTo(a.Type));

        foreach (AssignmentInfo task in tasks)
        {
            Console.WriteLine(task.Name);
        }

    }
}