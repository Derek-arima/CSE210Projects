using System;

namespace FinalProject;

class Program
{

    static void Main(string[] args)
    {
        Organizer organizer = new Organizer();


        organizer.createAssignment("Chapter 5 Quiz", "100", "Quiz", "09/01/2021", "REL 225");
        organizer.createAssignment("Develop 04", "100", "Project", "09/08/2021", "CSE 210");
        organizer.createAssignment("Attendance", "10", "Quiz", "09/15/2021", "WDD 130");
        organizer.createAssignment("Writting Assignment", "50", "Assignment", "09/22/2021", "REL 225");
        organizer.createAssignment("Peer Review", "15", "Assignment", "09/29/2021", "CSE 372");
        organizer.createAssignment("Personal Site", "100", "Project", "10/06/2021", "WDD 130");

        organizer.loadAssignments();

        organizer.displayAssignments();
    }
}