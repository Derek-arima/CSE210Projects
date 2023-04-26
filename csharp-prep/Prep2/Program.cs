using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);

        string letterGrade = "S";

        if (percentage >= 90)
        {
            letterGrade = "A";
        } 

        else if (percentage >= 80 && percentage <90)
        {
            letterGrade = "B";
        }

        else if (percentage >= 70 && percentage <80)
        {
            letterGrade = "C";
        }

        else if (percentage >= 60 && percentage <70)
        {
            letterGrade = "D";
        }

        if (percentage < 60)
        {
            letterGrade = "F";
        }

        Console.Write($"Your grade is: {letterGrade}");
    }
}