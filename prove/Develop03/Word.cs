using System;

namespace Develop03
{
    public class Word
        {
            string _text = "";
            bool _hidden= false;


            public Word(string text)
            {
                _text = text;
                _hidden = false;

            }
         
            public string getConditionalWord()
            {
                if (_hidden == false)
                {
                    return _text;
                }   

                else
                {
                    string hiddenWord ="";
                    do
                    {
                        hiddenWord += '_';
                    }while(_text.Length() != hiddenWord.Length()); 
                    return hiddenWord;
                }
            }
        }
}