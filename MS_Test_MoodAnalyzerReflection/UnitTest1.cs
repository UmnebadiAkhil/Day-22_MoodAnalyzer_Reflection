using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer_Reflection;

namespace MS_Test_MoodAnalyzerReflection
{
    [TestClass]
    public class UnitTest1
    {

        /* UC2:- Handle Exception if User Provides Invalid Mood
         */
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

        /* TC 2.1:- Given Null Mood Should Return Happy.
                   - To make this Test Case pass Handle NULL Scenario using try catch and return Happy.
        */
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
        /* TC 3.1:- NULL Given NULL Mood Should Throw MoodAnalysisException
                    To pass this Test Case in try catch block throw MoodAnalysisException
         */
        [TestMethod]
        public void GivenInvalidInput_ShouldReturn_HappyMood()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser();
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("Happy", mood);
        }
    }
    }
