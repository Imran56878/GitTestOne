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
                throw new MoodAnalyseException("nullException");
            }
            else if (msg ==String.Empty)
            {
                throw new MoodAnalyseException("EmptyString");
            }
            return this.msg;
        }

        /// <summary>parametrize mood asnalyse method </summary>
       
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
