using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer.NewFolder
{
  public  class MoodTest2
    {
       string msg1;
        public string Mood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                this.msg1 = "sad";
            }
            else if (message.ToLower().Contains("happy"))
            {
                this.msg1 = "happy";
            }
            else  if(message.Length==0)
            {
                throw new MoodAnalyseException("Empty string");
            }
            return this.msg1;
        }
        public string  Mood()
        {
            if (msg1 == null)
                throw new MoodAnalyseException("null value Exception");
            return msg1;
        }
       

    }
}
