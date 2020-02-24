using System;
using MoodAnalyzer;

namespace ModeAnalyzerConsoleTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string st = Console.ReadLine();
            MoodTest  tc = new MoodTest(st);
            try
            {
              Console.WriteLine(  tc.Mood ());
            }
            catch (MoodAnalyseException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
