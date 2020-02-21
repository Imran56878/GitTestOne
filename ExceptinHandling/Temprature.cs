using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptinHandling
{
    class Temprature
    {
        int temprature = 0;
        public void ShowTemp()
        {
            if (temprature==0)
            {
                throw new TempIsZeroException("Zero Temprature found");
            }

        }
    }
     public class TempIsZeroException : Exception
     {
        public TempIsZeroException(string message) : base(message) { 
        }
    }
}
