using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer_Reflection;

namespace MS_Test_MoodAnalyzerReflection
{
    [TestClass]
    public class UnitTest1
    {

            /* TC 1.1:- Given “I am in Sad Mood” message Should Return SAD
                    - analyseMood method can just return SAD to pass this Test Case (TC) */

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


        /* TC 1.2:- Given “I am in Any Mood” message Should Return HAPPY.
              - To make the Test case pass analyseMood method need to check for Sad else return HAPPY */
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
        }
    }
