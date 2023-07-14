using System;

namespace Develop05;

class Program
{
    
    static void Main(string[] args)
    {
        Goals goals = new Goals();

        CheckListGoals checkGoals = new CheckListGoals();

        EternalGoals eternalGoals = new EternalGoals();

        string noProgress = "0";


        string completed = "[ ]";




        int choice = 0;

        while(choice != 6)
        {
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.WriteLine("What would you like to do?");
            
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("What is the name of the goal?");
                string name = Console.ReadLine();

                Console.WriteLine("What is the description of the goal?");
                string desc = Console.ReadLine();

                Console.WriteLine("What is the type of the goal?(simple, checklist, or eternal)");
                string type = Console.ReadLine();

                Console.WriteLine("What is the point value of the goal?");
                string points = Console.ReadLine();

                if(type == "simple")
                {
                    string testProgress = "1";
                    goals.createGoals(completed, type, name, desc, points, noProgress, testProgress);
                }

                else if(type == "checklist")
                {

                    Console.WriteLine("How many times do you want to do the goal?");
                    string testProgress = Console.ReadLine();

                    checkGoals.createGoals(completed, type, name, desc, points, noProgress, testProgress);
                }

                else if(type == "eternal")
                {
                    string testProgress = "0";
                    eternalGoals.createGoals(completed, type, name, desc, points, noProgress, testProgress);
                }

                else
                {
                    Console.WriteLine("That is not a valid type.");
                }
            }

            else if (choice == 2)
            {
                Console.WriteLine("Which goal would you like to record?");
                string name = Console.ReadLine();

                Console.WriteLine("What type of goal is it?(simple, checklist, or eternal)");
                string type = Console.ReadLine();

                    if (type == "simple")
                    {
                        goals.recordEvent(name);
                    }

                    else if (type == "checklist")
                    {
                        checkGoals.recordEvent(name);
                    }

                    else if (type == "eternal")
                    {
                        eternalGoals.recordEvent(name);
                    }

                    else
                    {
                        Console.WriteLine("That is not a valid goal.");
                    }
            }

            else if (choice == 3)
            {
                goals.displayGoals();
                checkGoals.displayGoals();
                eternalGoals.displayGoals();
            }

            else if (choice == 4)
            {
                Console.WriteLine("What is the file path you want to save the goals to?");
                string filepath = Console.ReadLine();

                goals.saveGoals(filepath);
                checkGoals.saveGoals(filepath);
                eternalGoals.saveGoals(filepath);
            }

            else if (choice == 5)
            {
                Console.WriteLine("What is the file path you want to load the goals from?");
                string filepath = Console.ReadLine();

                goals.loadGoals(filepath);
                checkGoals.loadGoals(filepath);
                eternalGoals.loadGoals(filepath);
            }

            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("That is not a valid choice.");
            }
        }
    }
}