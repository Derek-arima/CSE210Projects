using System;

namespace FinalProject;

class AssignmentInfo
{
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public string Type { get; set; }

    public AssignmentInfo(string name, DateTime date, string type)
    {
        Name = name;
        Date = date;
        Type = type;
    }
}