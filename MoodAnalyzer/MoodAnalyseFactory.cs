
using System;
using System.Collections.Generic;
using System.Text;
namespace MoodAnalyzer
{
    public class MoodAnalyseFactory
    {
        string str;
        int b;
        public MoodAnalyseFactory()
        {

        }
        public MoodAnalyseFactory(int a)
        {
            b=a;
        }
        public MoodAnalyseFactory(string str2)
        {

            this.str = str2;
        }
        public Object AnalyseFactory(params string[] para)
        {
            try
            {
                Type t = Type.GetType("MoodAnalyzer." + str);
                var obj = Activator.CreateInstance(t, para);
                return obj;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                throw new MoodAnalyzerException("Input parameter sould not be null", MoodAnalyzerException.Value_Exception.Null_Reference_Exception);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new MoodAnalyzerException("No such class found ", MoodAnalyzerException.Value_Exception.No_Such_Class_Error);
            }


        }
    }

}
