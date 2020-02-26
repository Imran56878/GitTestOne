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
            MoodAnalyser tc = new MoodAnalyser(st);
            MoodAnalyser tc1 = new MoodAnalyser();
            try
            {
                Console.WriteLine(tc.Mood());
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
            TestCases t = new TestCases();
            t.CheckObject();
            MoodAnalyserReflector mf = new MoodAnalyserReflector();
            try
            {
                mf.AnalyseFactory();
            }
            catch (MoodAnalyzerException e)
            {
                Console.WriteLine(e.Message);
            }
            /*  int a = 123;
             Console.WriteLine( a.GetType().FullName);*/
            try
            {
                var a = tc1.NOMethod();
            }

            catch (MoodAnalyzerException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                mf.ShowMessage(null);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
