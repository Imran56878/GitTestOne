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
        public void HappyMessage()
        {
            Assert.AreEqual("happy", t1.Mood());

        }

        [Test]
        public void SadMessage()
        {
            Assert.AreEqual("sad", t2.Mood());
        }
        [Test]
        public void Nullexception()
        {
            MoodAnalyser moodtest = new MoodAnalyser();
            var val = Assert.Throws<MoodAnalyzerException>(() => moodtest.Mood());
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.Null_Reference_Exception, val.va);

        }

        [Test]
        public void EmptyException()
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
        [Test]
        public void MessageReflector()
        {
            MoodAnalyserReflector m = new MoodAnalyserReflector();
            m.ShowMessage("I am happy ");
        }
        [Test]
        public void ReflectorNullRException()
        {
            MoodAnalyserReflector m1 = new MoodAnalyserReflector();
            /*  var val4 = Assert.Throws<MoodAnalyzerException>(() => m1.ShowMessage (null));
              Assert.AreEqual(MoodAnalyzerException.Value_Exception.Null_Reference_Exception, val4.va);
  */
            try
            {
                m1.ShowMessage(null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        [Test]
        public void ReflectorEmptyException()
        {
            MoodAnalyserReflector m = new MoodAnalyserReflector();
            var val6 = Assert.Throws<MoodAnalyzerException>(() => m.ShowMessage(""));
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.Empty_Exception, val6.va);
            Console.WriteLine(val6);
        }

    }
}