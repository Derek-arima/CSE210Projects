namespace Develop02
{
    public class Entry
    {
        public string prompt;
        public string date;
        public string response;

        public string GetAsString()
        {
            return $"{prompt}, {response}, {date}";
        }

        public void Store(string prompt, string response, string date)
        { 
        this.prompt = prompt;
        this.response = response;
        this.date = date;
        }
    }
}

