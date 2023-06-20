using System;

namespace Develop03
{
    public class TargetPhrase
    {
        string[] words = verse.split(' ');
        List<Word> modifiedVerse = new List<Word>();
        
        // loop through words and create a new Word object for each
        public TargetPhrase()
        {
            foreach (string word in words)
            {
                modifiedVerse.Add(new Word(word));
            }
        }

        // choose random word and set bool to true and add that word to a list
        public void hideWord()
        {
            Random random = new Random();
            int index = random.Next(0, words.Length);
            modifiedVerse[index].isHidden = true;
        }

        // loop through modifiedVerse list and print out each word

        public void printVerse()
        {
            foreach (Word word in modifiedVerse)
            {
                console.write(word);
            }
        }
    }
}