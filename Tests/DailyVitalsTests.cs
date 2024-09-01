using FinalsurgeTestsProject.Pages.Vitals;
using NUnit.Allure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsurgeTestsProject.Tests
{
    [AllureNUnit] 
    internal class DailyVitalsTests : BaseTest
    {
        [Test]
        public void OpenDailyVitalsPageTest()
        {
            DailyVitalsPage.OpenDailyVitalsPage();
            string result = DailyVitalsPage.GetTextDailyVitalsPageElement();
            Assert.AreEqual(result, "View & Add Vitals");
        }
        [Test]
        public void AddAndCancelDailyVitalTest()
        {
            DailyVitalsPage.OpenDailyVitalsPage();
            AddVitals.AddVitalsButton();
            bool result1 = AddVitals.CheckDailyVitalsAddForm();
            Assert.IsTrue(result1);
            AddVitals.CancelVitalsButton();
            bool result2 = AddVitals.CheckDailyVitalsForm();
            Assert.IsTrue(result2);
        }
        [Test]
        public void AddDailyVitalsTest()
        {
            DailyVitalsPage.OpenDailyVitalsPage();
            AddVitals.AddVitalsButton();
            bool result1 = AddVitals.CheckDailyVitalsAddForm();
            Assert.IsTrue(result1);

            AddVitals.FillAddVitalsForm();

        }
    }
}
