using FinalsurgeTestsProject.Factories;
using FinalsurgeTestsProject.Pages;

namespace FinalsurgeTestsProject.Tests
{
    public class Tests : BaseTest
    {
        [Test]
        public void AauthorizationCheckTest()
        {
            string message = BasePage.GetWelcomeNickname();
            
            Assert.AreEqual(message, "rut");
        }
        [Test]
        public void AddWorkOutRunTest() 
        {
            Workouts.AddWorkOutRun();
        }
    }
}
