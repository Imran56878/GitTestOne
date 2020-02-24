using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    /// <summary>  This class is for to checking for mood </summary>
    public class MoodAnalyser
    {
        private readonly string msg;
     /*  public enum Value_Exception{
            Null_Reference_Exception,
            Empty_Exception
            }*/

        /// <summary>  This is parametrize constructor </summary>
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message)
        {
            this.msg = message;
            if (message.ToLower().Contains("sad"))
                this.msg = "sad";
            else if (message.ToLower().Contains("happy"))
                this.msg = "happy";
            else if(message.Length !=0)
                this.msg= "happy";
        
        }

        /// <summary>  This is empty mood checking method </summary>
        public string Mood()
        {
            if (this.msg == null)
            {
                throw new MoodAnalyzerException("nullException");
            }
            else if (msg.Length == 0)
            {
                throw new MoodAnalyzerException("EmptyString");
            }
              return this.msg;     
        }

        /// <summary>parametrize mood asnalyse method </summary>
       
    }

    /// <summary>  custom Exception class </summary>
    public class MoodAnalyzerException : Exception
    {
        /// <summary>  custom Exception constructor </summary>
        public MoodAnalyzerException(string message) : base(message)
        {

        }
    }
}
                                