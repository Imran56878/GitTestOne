using NUnit.Framework;
using System;

namespace MoodAnalyzer
{
    public class TestCases
    {
        MoodTest t1 = new MoodTest("I am in happy mood");
        MoodTest t2 = new MoodTest("I am in sad mood");
        MoodTest t3 = new MoodTest();
        MoodTest d = new MoodTest("");
        [SetUp]
        public void Setup()
        {
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
            catch (MoodAnalyseException e)
            {
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
            catch (MoodAnalyseException e)
            {
                Console.WriteLine(e.Message);
            }
        }
      
    }
}