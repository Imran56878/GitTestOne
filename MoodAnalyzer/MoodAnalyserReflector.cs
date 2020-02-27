
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
namespace MoodAnalyzer
{
    public class MoodAnalyserReflector
    {
        string str;
        int b;
        public MoodAnalyserReflector()
        {

        }
        public MoodAnalyserReflector(string str2)
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
        public void ShowMessage(string meesage1)
        {
            if (meesage1.Length != 0)
            {
                Type tm = Type.GetType("MoodAnalyzer.MoodAnalyser");
                object testInstance = Activator.CreateInstance(tm, meesage1);
                MethodInfo? methods = tm.GetMethod("Mood");
                var a = methods.Invoke(testInstance, null);
                Console.WriteLine(a);
            }
            else if (meesage1 == null)
            {
                Console.WriteLine("jkhuig");
                throw new MoodAnalyzerException("nullException", MoodAnalyzerException.Value_Exception.Null_Reference_Exception);
            }
            else if (meesage1.Length == 0)
            {
                Console.WriteLine("Imran");
                throw new MoodAnalyzerException("EmptyString", MoodAnalyzerException.Value_Exception.Empty_Exception);
            }

        }

    }
}
