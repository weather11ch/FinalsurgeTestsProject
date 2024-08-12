using FinalsurgeTestsProject.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsurgeTestsProject.Pages
{
    internal class Workouts : BasePage
    {
        public static void AddWorkOutRun()
        {
            workoutArrowDown = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"mobile-nav\"]/li[1]/a")));
            workoutArrowDown.Click();
            workoutAdd = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"mobile-nav\"]/li[1]/ul/li[1]/a")));
            workoutAdd.Click();
            //*[@id="mobile-nav"]/li[1]/ul/li[1]/a
        }
        //*[@id="mobile-nav"]/li[1]/a
    }
}
