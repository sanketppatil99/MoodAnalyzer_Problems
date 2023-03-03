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
            string actual = analyzer.AnalyzerMood(message);
            //Assert
            Assert.AreEqual(actual, "Sad");
        }
        [TestMethod]
        public void GivenMessage_WhenAnalyze_ShouldReturnHappyMood()
        {
            //Arrang
            string message = "I am in Any Mood";
            //Act
            MoodAnalyser analyzer = new MoodAnalyser(message);
            string actual = analyzer.AnalyzerMood(message);
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
    }
}