using FinalsurgeTestsProject.Factories;
using FinalsurgeTestsProject.Pages;
using FinalsurgeTestsProject.Pages.Workouts;

namespace FinalsurgeTestsProject.Tests
{
    public class Tests : BaseTest
    {
        [Test]
        public void AauthorizationCheckTest()
        {
            string message = Authorization.GetWelcomeNickname();
            
            Assert.AreEqual(message, "rut");
        }
        [Test]
        public void AddWorkOutRunTest() 
        {
            BasePage.OpenPage("https://log.finalsurge.com/WorkoutAdd.cshtml");
            Workouts.AddNewWorkOutRun();
        }

        [Test]
        public void OpenAddWorksPageTest()
        {
            BasePage.OpenPage("https://log.finalsurge.com/WorkoutAdd.cshtml");
            string result = Workouts.GetTextAddWorkoutPageElement();
            Assert.AreEqual(result, "Add Workout");

        }
    }
}
