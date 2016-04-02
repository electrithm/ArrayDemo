using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //sets background color to red
            Console.BackgroundColor = ConsoleColor.DarkRed;

            //sets text color to white
            Console.ForegroundColor = ConsoleColor.White;

            //clears the console so changes will appear
            Console.Clear();

            //creates array
            List<String> stuff = new List<String>();

            //outputs to console
            Console.WriteLine("What do you want to add to the array?");
            
            //gets input
            string thing = Console.ReadLine();

            //adds to array
            stuff.Add("bla");
            stuff.Add("bloop");
            stuff.Add("a");
            stuff.Add(thing);

            //loops through array and gets value at each point
            for (int i = 0; i<stuff.Count; i++)
            {
                Console.WriteLine(stuff[i]);
            }

            //keeps application from exiting right after running
            Process.GetCurrentProcess().WaitForExit();
        }
    }
}
