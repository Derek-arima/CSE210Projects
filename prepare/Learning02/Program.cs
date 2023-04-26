using System;
using System.Collections.Generic;

namespace Learning02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside the other program class");
            List<int> myList = new List<int>();
            myList.Add(121);
            myList.Add(2021);
            myList.Remove(121);

        }
    }
}