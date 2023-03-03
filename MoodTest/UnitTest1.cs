using MoodAnalyzerProblem;
namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMessage_WhenAnalyze_ShouldReturnMood()
        {
            //Arrang
            string message = "I am in Sad Mood";
            //Act
            MoodAnalyser analyzer = new MoodAnalyser(message);
            string actual = analyzer.AnalyzerMood();
            //Assert
            Assert.AreEqual(actual, "Sad");
        }
        [TestMethod]
        public void GivenMessage_WhenAnalyze_ShouldReturnHappyMood()
        {
            //Arrang
            string message = null;
            //Act
            MoodAnalyser analyzer = new MoodAnalyser(message);
            string actual = analyzer.AnalyzerMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
    }
}