using System;

namespace Develop02
{
    // public class Entry
    // {

    //     public string entry()
    //     {
    //         //create a new entry
    //         //display the prompt
    //         Prompt prompt = new Prompt();
    //         string givenPrompt = prompt.chooseRandom();

    //         Console.WriteLine(givenPrompt);

    //         string userInput = Console.ReadLine();

    //         //get the date as a string and add it to the entry before the user input
    //         string date = DateTime.Now.ToString("MM/dd/yyyy");

    //         string entry = date + ": " + givenPrompt + " " + userInput;


    //         return entry;
    //     }

    // }

    /* An entry in a journal.
     * 
     * The responsibility of an entry is to hold the date, prompt and response information. 
     * It also contains convenience methods for formatting the entry.
     */
    public class Entry
    {
        private string _date;
        private string _prompt;
        private string _response;

        public Entry(string date, string prompt, string response)
        {
            _date = date;
            _prompt = prompt;
            _response = response;
        }

        public string GetDate()
        {
            return _date;
        }

        public string GetPrompt()
        {
            return _prompt;
        }

        public string GetResponse()
        {
            return _response;
        }

        public string GetFormattedString()
        {
            return $"{_date}: {_prompt} :{_response}";
        }
    }
}

