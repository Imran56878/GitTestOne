using NUnit.Framework;
using System;

namespace MoodAnalyzer
{
    public class TestCases
    {
      readonly   MoodTest t = new MoodTest();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1 ()
        {
            Assert.AreEqual("sad",t.Mood ("I am in Sad mood"));
            Console.WriteLine("sad");
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("happy", t.Mood("I am in any mood"));
            Console.WriteLine("happy");
        }
      
      
    }
}