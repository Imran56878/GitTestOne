using MoodAnalyzer.NewFolder;
using NUnit.Framework;
using System;

namespace MoodAnalyzer
{
    public class TestCases
    {
        readonly MoodTest t = new MoodTest();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("sad", t.Mood("I am in Sad mood"));
            Console.WriteLine("sad");
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("sad", t.Mood("I am in any mood"));
            Console.WriteLine("sad");
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual("sad", t.Mood("any mode "));
            Console.WriteLine("sad");
        }
        [Test]
        public void TestConstructor1()
        {
            MoodTest t2 = new MoodTest("I am in happy mode");
            Assert.AreEqual("happy", t2.Mood());
            Console.WriteLine("happy");
        }
        [Test]
        public void TestConstructor2()
        {
            MoodTest t2 = new MoodTest("I am in sad mode");
            Assert.AreEqual("sad", t2.Mood());
            Console.WriteLine("sad");
        }
        [Test]
        public void TestConstructor3()
        {
            MoodTest t2 = new MoodTest();
            try
            {
                Assert.AreEqual("happy", t2.Mood());
                Console.WriteLine("happy");
            }
            catch (MoodAnalyseException e)
            {
                Console.WriteLine(e.Message);
            }


        }
        MoodTest2 d = new MoodTest2();
        [Test]
        public void TestA1()
        { 
            try
            {
                Assert.AreEqual("sad", d.Mood(""));
            }
            catch (MoodAnalyseException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void TestA2()
        {
            try
            {
                Assert.AreEqual("happy", d.Mood());
            }
            catch (MoodAnalyseException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}