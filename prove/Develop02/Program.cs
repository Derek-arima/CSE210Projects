using System;
namespace Develop02;
class Program
{
    static void Main(string[] args)
    {
        Prompt promptList = new Prompt();
        promptList.populatePrompts();
        Journal journal = new Journal();

        

        int cont = 0;

        do
        {  
            if (cont == 0)
            {
                //display the menu
                Console.WriteLine("1. Add Journal Entry");
                Console.WriteLine("2. View Journal Entries");
                Console.WriteLine("3. Load Journal Entries");
                Console.WriteLine("4. Save Journal Entries");
                Console.WriteLine("5. Quit");
                Console.WriteLine("Enter the number of the option you would like to select: ");

                //get the user's choice
                string choice = Console.ReadLine();
                cont = Int32.Parse(choice);
            }

            else if (cont == 1)
            {
                //Prompt user for date
                Console.WriteLine("Enter the date: ");
                string date = Console.ReadLine();
                
                //chooses a random prompt to display to the user and then gets the user's response
                string givenPrompt = promptList.chooseRandom();

                Console.WriteLine(givenPrompt);
                string response = Console.ReadLine();


                //create a new entry
                Entry entry = new Entry(date, givenPrompt, response);

                //add the entry to the journal

                journal.Add(entry);

                cont = 0;
            }

            else if(cont == 2)
            {
                //display the entries in the journal

                foreach(Entry entry in journal.GetEntries())
                {
                    Console.WriteLine(entry.GetFormattedString());
                }
            
                cont = 0;
            }

            else if(cont == 3)
            {
                Console.WriteLine("Enter the file path to load the journal entries from: ");
                string filePath = Console.ReadLine();

                //load the entries from a text file
                // Journal journal = new Journal();
                journal.loadEntries(filePath);
                cont = 0;
            }

            else if(cont == 4)
            {
                //save the entries to a text file
                Console.WriteLine("Enter the file path to save the journal entries to: ");
                string filePath = Console.ReadLine();

                // Journal journal = new Journal();
                journal.saveEntries(filePath);
                cont = 0;
            }

            else if(cont == 5)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                cont = 0;
            }



        }while(cont != 5);

    }
}