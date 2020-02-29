
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
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyserReflector"/> class.
        /// </summary>
        public MoodAnalyserReflector()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyserReflector"/> class.
        /// </summary>
        /// <param name="str2">The STR2.</param>
        public MoodAnalyserReflector(string str2)
        {

            this.str = str2;
        }
        /// <summary>
        /// Analyses the factory.
        /// </summary>
        /// <param name="para">The para.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyzer.MoodAnalyzerException">
        /// Input parameter sould not be null
        /// or
        /// No such class found
        /// </exception>
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
        /// <summary>
        /// Shows the message by using reflection
        ///   or handle exception
        /// </summary>
        /// <param name="meesage1">The meesage1.</param>
        /// <exception cref="MoodAnalyzer.MoodAnalyzerException">
        /// nullException
        /// or
        /// EmptyString
        /// </exception>
        public void ShowMessage(string meesage1)
        {
            if (meesage1.Length != 0)
            {
                Type tm = Type.GetType("MoodAnalyzer.MoodAnalyser");
                object testInstance = Activator.CreateInstance(tm, meesage1);
                MethodInfo methods = tm.GetMethod("Mood");
                var a = methods.Invoke(testInstance, null);
                Console.WriteLine(a);
            }
            else if (meesage1 == null)
            {
                throw new MoodAnalyzerException("nullException", MoodAnalyzerException.Value_Exception.Null_Reference_Exception);
            }
            else if (meesage1.Length == 0)
            {
                throw new MoodAnalyzerException("EmptyString", MoodAnalyzerException.Value_Exception.Empty_Exception);
            }

        }

    }
}
