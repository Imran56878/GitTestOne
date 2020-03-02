using NUnit.Framework;
using System;
namespace MoodAnalyzer
{
    public class TestCases
    {
        MoodAnalyser testmood = new MoodAnalyser("I am in happy mood");
        MoodAnalyser testsad = new MoodAnalyser("I am in sad mood");
        MoodAnalyser testnull = new MoodAnalyser();
        MoodAnalyser testempty = new MoodAnalyser("");

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("");
        }

        /// <summary>It will 
        /// check happy message
        /// </summary>>
        [Test]
        public void HappyMessage()
        {
            Assert.AreEqual("happy", testmood.Mood());

        }

        /// <summary>
        /// It will check 
        /// sad message
        /// </summary>>
        [Test]
        public void SadMessage()
        {
            Assert.AreEqual("sad", testsad.Mood());
        }

        /// <summary>
        /// this is for 
        /// null value and it
        /// will check null exception
        /// </summary>
        [Test]
        public void Nullexception()
        {
            MoodAnalyser moodtest = new MoodAnalyser();
            var val = Assert.Throws<MoodAnalyzerException>(() => moodtest.Mood());
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.Null_Reference_Exception, val.va);

        }
        /// <summary>
        /// this is for empty message
        /// and handle empty exception
        /// </summary>
        [Test]
        public void EmptyException()
        {

            MoodAnalyser moodtest = new MoodAnalyser("");
            var val = Assert.Throws<MoodAnalyzerException>(() => moodtest.Mood());
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.Empty_Exception, val.va);
        }
        /// <summary>
        /// it will check the 
        /// object of same class 
        /// </summary>
        [Test]
        public void CheckObject()
        {
            MoodAnalyser moodtest = new MoodAnalyser();
            var test = moodtest.Equals(moodtest);
            Assert.IsTrue(test);
            Console.WriteLine(test);

        }
        /// <summary>
        /// This is for checking 
        /// constructor with given
        /// paramter exist or not  
        /// </summary>
        [Test]
        public void CheckConstructorParameter()
        {
            var val = Assert.Throws<MoodAnalyzerException>(() => testempty.WrongConstructorInfo(6867));
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.No_Such_Constructor_Error, val.va);
        }
        /// <summary>
        /// Checks the method with
        /// the given type parameter
        /// is not found .
        /// </summary>
        [Test]
        public void CheckMethodParameter()
        {

            var val = Assert.Throws<MoodAnalyzerException>(() => testempty.WrongMethodInfo(6867));
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.No_Such_Method_Error, val.va);
        }
        /// <summary>
        /// It will check the specific
        /// method of given class
        /// exist 
        /// </summary>
        [Test]
        public void CheckMoodMethod()
        {
            testnull.MethodCheck();
        }
        /// <summary>
        /// It will check the metrhod 
        /// is not exist
        /// and handle exception
        /// </summary>
        [Test]
        public void MethodNotFound()
        {
            var val = Assert.Throws<MoodAnalyzerException>(() => testmood.NOMethod());
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.No_Such_Method_Error, val.va);
        }
        /// <summary>
        /// It check the happy message using
        /// reflector concept
        /// </summary>
        [Test]
        public void MessageHappyReflector()
        {
            MoodAnalyserReflector analyse = new MoodAnalyserReflector();
            analyse.ShowMessage("I am happy ");
        }
        /// <summary>
        /// It check the sad message using
        /// reflector concept
        /// </summary>
        [Test]
        public void MessageSadReflector()
        {
            MoodAnalyserReflector analyse = new MoodAnalyserReflector();
            analyse.ShowMessage("I am sad ");
        }
        /// <summary>
        /// It uses the reflector 
        /// concept to handle 
        /// null exception
        /// </summary>
        [Test]
        public void ReflectorNullRException()
        {
            MoodAnalyserReflector moodrefletor = new MoodAnalyserReflector();
            /*  var val4 = Assert.Throws<MoodAnalyzerException>(() => m1.ShowMessage (null));
              Assert.AreEqual(MoodAnalyzerException.Value_Exception.Null_Reference_Exception, val4.va);
  */
            try
            {
                moodrefletor.ShowMessage(null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        /// <summary>
        /// using reflector 
        /// it handle Empty message exception
        /// </summary>
        [Test]
        public void ReflectorEmptyException()
        {
            MoodAnalyserReflector mreflector = new MoodAnalyserReflector();
            var val = Assert.Throws<MoodAnalyzerException>(() => mreflector.ShowMessage(""));
            Assert.AreEqual(MoodAnalyzerException.Value_Exception.Empty_Exception, val.va);
            Console.WriteLine(val);
        }

    }
}