using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace MoodAnalyzer
{
    /// <summary>  This class is for to checking for mood </summary>
    public class MoodAnalyser
    {
        private readonly string msg;
     

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
                throw new MoodAnalyzerException("nullException",MoodAnalyzerException.Value_Exception.Null_Reference_Exception);
            }
            else if (msg.Length == 0)
            {
                throw new MoodAnalyzerException("EmptyString",MoodAnalyzerException.Value_Exception.Empty_Exception);
            }
              return this.msg;     
        }
        public override bool Equals(object  obj)
        {
          MoodAnalyseFactory ma=  new MoodAnalyseFactory("MoodAnalyser"); 
            var refObj = ma.AnalyseFactory("MoodAnalyser");
            return refObj.GetType().Equals(obj.GetType());
        }
        public  bool WrongConstructorInfo( string a)
        {
            Type t = Type.GetType("MoodAnalyzer.MoodAnalyser");
            ConstructorInfo[] constructors = t.GetConstructors();
             foreach(ConstructorInfo constructor in constructors )
             {
               if (constructor.Name.GetType().Equals(a.GetType().FullName))
                {
                    Console.WriteLine(true);
                    return true;
                }
             }
            throw new MoodAnalyzerException("No_Such_Constructor_Found", MoodAnalyzerException.Value_Exception.No_Such_Constructor_Error);
          /*  Console.WriteLine(constructors[0].Equals("System.String"));
            Console.WriteLine(constructors[1].Equals("System.String"));
*/
        }

        /// <summary>parametrize mood asnalyse method </summary>
       
    }

    /// <summary>  custom Exception class </summary>
    public class MoodAnalyzerException : Exception
    {
        /// <summary>  custom Exception constructor </summary>
        /// 
        public enum Value_Exception
        {
            Null_Reference_Exception,
            Empty_Exception,
            No_Such_Class_Error,
            No_Such_Constructor_Error,
            No_Such_Method_Error
        }
        public Value_Exception va;
        private readonly string ex;
    
        public MoodAnalyzerException(string exc, Value_Exception values) : base(exc)
        {
        this.va=values;
            this.ex = exc;
        }
    }
}
                                