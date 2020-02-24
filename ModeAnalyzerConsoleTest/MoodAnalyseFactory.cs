using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Text;
namespace ModeAnalyzerConsoleTest
{
   public class MoodAnalyseFactory
    {
    public static object AnalyseFactory()
        {
            MoodAnalyser obj = new MoodAnalyser();
           
            return obj;
        }
    }
}
