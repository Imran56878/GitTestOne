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
            MoodAnalyser tcons = new MoodAnalyser();
            /// <summary>
            /// it will check mood at run time 
            /// and handle excption if 
            /// any exception occur
            /// </summary>>
            try
            {
                Console.WriteLine(tc.Mood());
            }
            catch (MoodAnalyzerException e)
            {
                Console.WriteLine(e.Message);
            }
            /// <summary>
            /// it will handle null refernce exception
            /// </summary>>
            try
            {
                Console.WriteLine(tcons.Mood());
            }
            catch (MoodAnalyzerException e)
            {
                Console.WriteLine(e.Message);
            }
            TestCases t = new TestCases();
            t.CheckObject();
            /// <summary>
            /// it will check mood using reflector
            /// and handle exception
            /// </summary>>
            MoodAnalyserReflector mf = new MoodAnalyserReflector();
            try
            {
                mf.AnalyseFactory();
            }
            catch (MoodAnalyzerException e)
            {
                Console.WriteLine(e.Message);
            }
            ///<summary>
            /// it check the method is not found
            /// </summary>>
            try
            {
                var a = tcons.NOMethod();
            }

            catch (MoodAnalyzerException e)
            {
                Console.WriteLine(e.Message);
            }
            /// <summary>
            /// it handle null reference exception using 
            /// reflection
            /// </summary>>
            try
            {
                mf.ShowMessage(null);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
