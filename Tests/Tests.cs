﻿using FinalsurgeTestsProject.Factories;
using FinalsurgeTestsProject.Pages;

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
            //BasePage.OpenPage("https://log.finalsurge.com/WorkoutAdd.cshtml");
            Workouts.AddWorkOutRun();
        }

        [Test]
        public void OpenAddWorksPageTest()
        {
            BasePage.OpenPage("https://log.finalsurge.com/WorkoutAdd.cshtml");

        }
    }
}
