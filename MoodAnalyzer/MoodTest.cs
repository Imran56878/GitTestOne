using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    class MoodTest
    {
        string msg;
      
        public string Mood(string message )
        {
            if (message.ToLower().Contains("sad"))
            {
                msg = "sad";
            }
          
            else
            {
                msg = "happy";
            }
            return msg;
        }
    }
   
}
