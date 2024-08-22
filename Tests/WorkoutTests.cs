using FinalsurgeTestsProject.Pages;
using FinalsurgeTestsProject.Pages.Workouts;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsurgeTestsProject.Tests
{
    internal class WorkoutTests : BaseTest
    {
        //элементы для выбора пункта меню Activity Type 
        public static WebElements run = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[1]/div[1]/a"));
        private static WebElements bike = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[2]/div[1]/a"));
                
        [Test]
        public void AddNewWorkoutBikeTest()
        {
            BasePage.OpenPage("https://log.finalsurge.com/WorkoutAdd.cshtml");
            Workouts.AddNewWorkout(bike,"first run", "running description");
            bool result = Workouts.CheckNewdWorkoutDetails("first run", "running description");
            Assert.That(result, Is.True);
        }

        [Test]
        public void AddNewWorkoutRun1Test()
        {
            BasePage.OpenPage("https://log.finalsurge.com/WorkoutAdd.cshtml");
            Workouts.AddNewWorkout(run, "first run", "running description");
            bool result = Workouts.CheckNewdWorkoutDetails("first run", "running description");
            Assert.That(result, Is.True);
        }
    }
}
