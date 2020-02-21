using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer.NewFolder
{
    class MoodTest2
    {
        string msg1;
        public MoodTest2()
        {

        }
        public MoodTest2 (string message)
        {
            if (message.ToLower().Contains("sad"))
                msg1 = "sad";
            else if (message.ToLower().Contains("happy"))
                msg1 = "happy";
        }

    }
}
