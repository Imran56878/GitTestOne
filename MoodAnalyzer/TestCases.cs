using NUnit.Framework;
using System;
//using ModeAnalyzerConsoleTest;
namespace MoodAnalyzer
{
    public class TestCases
    {
        MoodAnalyser t1 = new MoodAnalyser("I am in happy mood");
        MoodAnalyser t2 = new MoodAnalyser("I am in sad mood");
        MoodAnalyser t3 = new MoodAnalyser();
        MoodAnalyser d = new MoodAnalyser("");

      //  public object MoodAnalyseFactory { get; private set; }

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
             /*try
             {
                 Assert.AreEqual("nullException", t3.Mood());
             }
             catch (MoodAnalyzerException e)
             {
                 Console.WriteLine(e.Message);
             }*/
            MoodAnalyser moodtest = new MoodAnalyser( );
            var val = Assert.Throws<MoodAnalyzerException>(() => moodtest.Mood());
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.Null_Reference_Exception,val.va);
           
        }
    
        [Test]
        public void Test4()
        {
           /* try
            {
                Assert.AreEqual("EmptyString",d.Mood());
            }
            catch (MoodAnalyzerException e)
            {
                //Console.WriteLine(nullException.Empty_Exception);
                Console.WriteLine(e.Message);
            }*/
            MoodAnalyser moodtest = new MoodAnalyser("");
            var val2 = Assert.Throws<MoodAnalyzerException>(() => moodtest.Mood());
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.Empty_Exception, val2.va);
        }
        [Test]
        public void  CheckObject()
        {
            /* MoodAnalyser ma = new MoodAnalyser();                                                                                
             try {
                 Type t = typeof(MoodAnalyser).GetType();
                 var obj = Activator.CreateInstance(t);
                 Assert.AreEqual(ma.GetType(), obj.GetType());
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }*/
            MoodAnalyser testmood = new MoodAnalyser();
            var test = testmood.Equals(testmood);
            Assert.IsTrue(test);
          
        }
      
    }
}