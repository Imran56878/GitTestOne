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
            if (msg==null)
            {
              //  msg = "happy";
               throw new MoodAnalyseException ("no mood");

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
