using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer.NewFolder
{
    class MoodTest2
    {
      readonly string msg1;
        public MoodTest2()
        {

        }
        public MoodTest2 (string message)
        {
            if (message.ToLower().Contains("sad"))
               this.msg1 = "sad";
            else if (message.ToLower().Contains("happy"))
                this.msg1 = "happy";
        }

    }
}
