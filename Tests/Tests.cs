using FinalsurgeTestsProject.Factories;
using FinalsurgeTestsProject.Pages;
using FinalsurgeTestsProject.Pages.TrainingCalendar;
using FinalsurgeTestsProject.Pages.Vitals;
using FinalsurgeTestsProject.Pages.Workouts;
using NUnit.Allure.Core;
using OpenQA.Selenium;

namespace FinalsurgeTestsProject.Tests
{
    [AllureNUnit]
    public class Tests : BaseTest
    {
        
        [Test]
        public void AauthorizationCheckTest()
        {
            string message = Authorization.GetWelcomeNickname();            
            Assert.AreEqual(message, "rut");
        }
       

        [Test]
        public void OpenAddWorksPageTest()
        {
            BasePage.OpenPage("https://log.finalsurge.com/WorkoutAdd.cshtml");
            string result = Workouts.GetTextAddWorkoutPageElement();
            Assert.AreEqual(result, "Add Workout");

        }
        [Test]
        public void OpenTrainingCalendarPageTest()
        {
            TrainingCalendarPage.OpenTrainingCalendarPage();
        }
        [Test]
        public void OpenCalendarByButtonTest() 
        {
            ButtonMenu.CalendarOpenByButton();
        }
       
    }
}
