using FinalsurgeTestsProject.Pages;
using FinalsurgeTestsProject.Pages.Workouts;
using OpenQA.Selenium;


namespace FinalsurgeTestsProject.Tests
{
    internal class WorkoutTests : BaseTest
    {
        const string url = "https://log.finalsurge.com/WorkoutAdd.cshtml";
        //элементы для выбора пункта меню Activity Type 
        public static WebElements run = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[1]/div[1]/a"));
        private static WebElements bike = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[2]/div[1]/a"));
        private static WebElements swim = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[3]/div[1]/a"));

        [Test]
        public void AddNewWorkoutBikeTest()
        {
            BasePage.OpenPage(url);
            Workouts.AddNewWorkout(bike,"first run", "running description");
            bool result = Workouts.CheckNewdWorkoutDetails("first run", "running description");
            Assert.That(result, Is.True);
        }

        [Test]
        public void AddNewWorkoutRunTest()
        {
            BasePage.OpenPage(url);
            Workouts.AddNewWorkout(run, "first run", "running description");
            bool result = Workouts.CheckNewdWorkoutDetails("first run", "running description");
            Assert.That(result, Is.True);
        }
        [Test]
        public void AddNewWorkoutSwimTest()
        {
            BasePage.OpenPage(url);
            Workouts.AddNewWorkout(swim, "first run", "running description");
            bool result = Workouts.CheckNewdWorkoutDetails("first run", "running description");
            Assert.That(result, Is.True);
        }
    }
}
