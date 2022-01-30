using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer_Reflection;

namespace MS_Test_MoodAnalyzerReflection
{
    [TestClass]
    public class UnitTest1
    {

        // Givens the sad message when analysed should return sad mood.
       
        [TestMethod]
        public void GivenSadMessage_WhenAnalysed_ShouldReturnSadMood()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser("I am in a Sad mood");
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("Sad", mood);
        }

     
        // Givens the happy message when analysed should return happy mood.
        
        [TestMethod]
        public void GivenHappyMessage_WhenAnalysed_ShouldReturnHappyMood()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser("I am in a Happy mood");
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("Happy", mood);
        }


        // Givens the empty mood when analysed should throw mood analysis exception indicating empty mood.
       
        [TestMethod]
        public void GivenEmptyMood_WhenAnalysed_ShouldThrowMoodAnalysisExceptionIndicatingEmptyMood()
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
        public void GivenNULLMood_WhenAnalysed_ShouldThrowMoodAnalysisExceptionIndicatingNULLMood()
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


      
        // Givens the mood analyser class name when analysed should return mood analyser object.
        
        [TestMethod]
        public void GivenMoodAnalyserClassName_WhenAnalysed_ShouldReturn_MoodAnalyserObject()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyserFactory.MoodAnalyseObjectCreation("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser");
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        
        // Givens the improper class name when analyse should throw mood analysis exception.
        
        [TestMethod]
        public void GivenImproperClassName_WhenAnalyse_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyser();
                object actual = MoodAnalyserFactory.MoodAnalyseObjectCreation("abc", "abc");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("No such class found", e.Message);
            }
        }

      
        // Givens the improper constructor name when analyse should throw mood analysis exception.
       
        [TestMethod]
        public void GivenImproperConstructorName_WhenAnalyse_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyser();
                object actual = MoodAnalyserFactory.MoodAnalyseObjectCreation("Mood", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Constructor not found", e.Message);
            }
        }
    }
}
