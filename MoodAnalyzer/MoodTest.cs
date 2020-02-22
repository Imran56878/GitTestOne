using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    class MoodTest
    {
        string msg;
       public  MoodTest()
        {

        }
        public MoodTest(string message)
        {
            if (message.ToLower().Contains("sad"))
                msg = "sad";
            else if (message.ToLower().Contains("happy"))
                msg = "happy";
        }
        public string  Mood ( )
         {
            try
            {
                if (msg == null)
                {
                    msg = "happy";
                    throw new MoodAnalyseException("Invalid mood null");
                }
               
             }
                  catch (MoodAnalyseException e)
                    {
                        Console.WriteLine(e.Message);
                    }

            return msg;
        }
        public string Mood(string message )
        {
            if (message.ToLower().Contains("sad"))
            {
                msg = "sad";
            }
            else if (message.ToLower().Contains("happy") )
                {
                msg = "happy";
            }
            else
            {
                msg = "sad";
            }
            return msg;
        }
    }
    class MoodAnalyseException : Exception
    {
        public MoodAnalyseException(string message) : base(message )
        {

        }
    }
}
