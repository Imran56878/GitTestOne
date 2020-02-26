using NUnit.Framework;
using System;
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
            MoodAnalyser moodtest = new MoodAnalyser();
            var val = Assert.Throws<MoodAnalyzerException>(() => moodtest.Mood());
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.Null_Reference_Exception, val.va);

        }

        [Test]
        public void Test4()
        {

            MoodAnalyser moodtest = new MoodAnalyser("");
            var val2 = Assert.Throws<MoodAnalyzerException>(() => moodtest.Mood());
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.Empty_Exception, val2.va);
        }
        [Test]
        public void CheckObject()
        {
            MoodAnalyser testmood = new MoodAnalyser();
            var test = testmood.Equals(testmood);
            Assert.IsTrue(test);
            Console.WriteLine(test);

        }
        [Test]
        public void CheckConstructorParameter()
        {
            var val3 = Assert.Throws<MoodAnalyzerException>(() => d.WrongConstructorInfo(6867));
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.No_Such_Constructor_Error, val3.va);
        }
        [Test]
        public void CheckMoodMethod()
        {
            t3.MethodCheck();
        }
        [Test]
        public void MethodNotFound()
        {
            var val4 = Assert.Throws<MoodAnalyzerException>(() => t1.NOMethod());
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.No_Such_Method_Error, val4.va);
        }

    }
}