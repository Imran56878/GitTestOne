using NUnit.Framework;
using System;
using static MoodAnalyzer.MoodAnalyser;
namespace MoodAnalyzer
{
    public class TestCases
    {
        MoodAnalyser t1 = new MoodAnalyser("I am in happy mood");
        MoodAnalyser t2 = new MoodAnalyser("I am in sad mood");
        MoodAnalyser t3 = new MoodAnalyser();
        MoodAnalyser d = new MoodAnalyser("");
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("happy", t1.Mood());
      
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("sad", t2.Mood());
        }
        [Test]
        public void Test3()
        {
            try
            {
                Assert.AreEqual("nullException", t3.Mood());
            }
            catch (MoodAnalyzerException e)
            {
               // Console.WriteLine(value_Exception.Null_Reference_Exception);
                Console.WriteLine(e.Message);
            }

        }
    
        [Test]
        public void Test4()
        {
            try
            {
                Assert.AreEqual("EmptyString",d.Mood());
            }
            catch (MoodAnalyzerException e)
            {
                //Console.WriteLine(nullException.Empty_Exception);
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void  CheckObject()
        {
            Type t = typeof(MoodAnalyser ).GetType() ;
            Assert.AreEqual("","");
        }
      
    }
}