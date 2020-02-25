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
            MoodAnalyser  tc = new MoodAnalyser(st);
            MoodAnalyser tc1 = new MoodAnalyser();
            try
            {
              Console.WriteLine(  tc.Mood ());
            }
            catch (MoodAnalyzerException e)
            {
                Console.WriteLine(e.Message);
            }
          
            try
            {
                Console.WriteLine(tc1.Mood());
            }
            catch (MoodAnalyzerException e)
            {
                Console.WriteLine(e.Message);
            }
           

        }
    }
}
