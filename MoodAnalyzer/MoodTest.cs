using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    /// <summary>  This class is for to checking for mood </summary>
    public class MoodTest
    {
        string msg;

        /// <summary>  This is parametrize constructor </summary>
        public MoodTest()
        {

        }
        public MoodTest(string message)
        {
            if (message.ToLower().Contains("sad"))
                this.msg = "sad";
            else if (message.ToLower().Contains("happy"))
                this.msg = "happy";
        }

        /// <summary>  This is empty mood checking method </summary>
        public string Mood()
        {
            if (this.msg == null)
            {
                this.msg = "happy";
            }
            try
            {
                if (msg.Length == 0)
                    throw new MoodAnalyseException("Invalid input");
            }
            catch (MoodAnalyseException e)
            {
                Console.WriteLine(e.Message);
            }

            return this.msg;
        }

        /// <summary>parametrize mood asnalyse method </summary>
        public string Mood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                this.msg = "sad";
            }
            else if (message.ToLower().Contains("happy"))
            {
                this.msg = "happy";
            }
            else
            {
                this.msg = "sad";
            }
            return this.msg;
        }
    }

    /// <summary>  custom Exception class </summary>
    public class MoodAnalyseException : Exception
    {
        /// <summary>  custom Exception constructor </summary>
        public MoodAnalyseException(string message) : base(message)
        {

        }
    }
}
