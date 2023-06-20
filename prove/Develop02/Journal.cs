using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    public class Journal
    {

        private List<Entry> entries = new List<Entry>();
        //add entry to the journal
        public void Add(Entry entry)
        {
           if (entries.Contains(entry))
            {
                throw new ArgumentException("Can't add duplicate entries.");
            }
            entries.Add(entry);
            Console.WriteLine("Entry added to the journal successfully.");
        }

        public List<Entry> GetEntries()
        {
            return entries;
        }




        //save the list of entries to a text file
        public void saveEntries(string filePath)
        {

            // Open a StreamWriter to append to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Iterate over the list and append each element to the file
                foreach (Entry element in entries)
                {
                    writer.WriteLine(element.GetFormattedString());
                }
            }

            Console.WriteLine("Jounal added to the file successfully.");
        }

        //load the entries from a text file
        public void loadEntries(string filePath)
        {
            //load the entries from a text file



                //read all lines in the text file

                string[] textFromFile = File.ReadAllLines(filePath);
                foreach(string line in textFromFile)
                {
                    if (line.Trim() == "")
                    {
                        continue;
                    }
                    // Split the line into the date, prompt, and response
                    string[] parts = line.Split(':');

                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry entry = new Entry(date, prompt, response);
                    entries.Add(entry);

                }

            Console.WriteLine("Jounal loaded from the file successfully.");
        }
    }
}