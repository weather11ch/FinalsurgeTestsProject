using FinalsurgeTestsProject.Pages;
using FinalsurgeTestsProject.Pages.Workouts;
using NUnit.Allure.Core;
using OpenQA.Selenium;


namespace FinalsurgeTestsProject.Tests
{
    [AllureNUnit]
    internal class WorkoutTests : BaseTest
    {
        const string url = "https://log.finalsurge.com/WorkoutAdd.cshtml";

        //элементы для выбора пункта меню Activity Type 
        public static WebElements run = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[1]/div[1]/a"));
        public static WebElements bike = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[2]/div[1]/a"));
        public static WebElements swim = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[3]/div[1]/a"));

        [TestCase("bike", "bike workout", "riding description")]
        [TestCase("run", "run workout", "running description")]
        [TestCase("swim", "swim workout", "swimming description")]
        [TestCase("crossTraining", "crossTraining workout", "crossTraining description")]
        [TestCase("walk", "walk workout", "walking description")]
        [TestCase("restDay", "restDay", "restDay description")]
        [TestCase("strenghTraining", "strenghTraining", "strenghTraining description")]
        [TestCase("recoveryRehub", "recoveryRehub", "recoveryRehub description")]
        [TestCase("other", "other", "other description")]
        [TestCase("transition", "transition", "transition description")]
        public void AddNewWorkoutTest(string element, string name, string description)
        {
            BasePage.OpenPage(url);
            Workouts.AddNewWorkout(element, name, description);
            bool result = Workouts.CheckNewdWorkoutDetails(name, description);
            Assert.That(result, Is.True);
        }
        [TestCase("bike", "bike workout", "riding description",2)]
        [TestCase("run", "run workout", "running description",2)]
        [TestCase("swim", "swim workout", "swimming description",2)]
        [TestCase("crossTraining", "crossTraining workout", "crossTraining description",2)]
        public void AddNewBasicWorkoutTest(string element, string name, string description, int mi)
        {
            BasePage.OpenPage(url);
            Workouts.AddNewBasicWorkout(element,name, description,mi);
            bool result = Workouts.CheckNewBasicdWorkoutDetails(element, name, description, mi);
            Assert.That(result, Is.True);
        }

        [Test]
        public void AddNewWorkoutRunTest()
        {
            BasePage.OpenPage(url);
            Workouts.AddNewWorkout("run", "first run", "running description");
            bool result = Workouts.CheckNewdWorkoutDetails("first run", "running description");
            Assert.That(result, Is.True);
        }
        [Test]
        public void AddNewWorkoutSwimTest()
        {
            BasePage.OpenPage(url);
            Workouts.AddNewWorkout("swim", "first run", "running description");
            bool result = Workouts.CheckNewdWorkoutDetails("first run", "running description");
            Assert.That(result, Is.True);
        }
    }
}
