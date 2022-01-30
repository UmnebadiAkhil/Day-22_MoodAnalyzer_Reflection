using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer_Reflection;

namespace MS_Test_MoodAnalyzerReflection
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void GivenSadMessage_ShouldReturn_SadMood()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser("I am in a Sad mood");
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("Sad", mood);
        }

       
        [TestMethod]
        public void GivenHappyMessage_ShouldReturn_HappyMood()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser("I am in a Happy mood");
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("Happy", mood);
        }

        [TestMethod]
        public void GivenEmptyMood_WhenAnalysed_ShouldThrow_MoodAnalysisExceptionIndicatingEmptyMood()
        {
            try
            {
                string message = string.Empty;
                MoodAnalyser mood = new MoodAnalyser(message);
                string moodStr = mood.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }

        [TestMethod]
        public void GivenNULLMood_WhenAnalysed_ShouldThrow_MoodAnalysisExceptionIndicatingNULLMood()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
    }
}
