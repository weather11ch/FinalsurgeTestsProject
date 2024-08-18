using FinalsurgeTestsProject.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace FinalsurgeTestsProject.Pages
{
    internal class Workouts : BasePage
    {
        private static WebElements workOutsMenu = new(By.Id("selectnav1"));
        private static WebElements addWorkOuts = new(By.XPath("//*[@id=\"selectnav1\"]/option[3]"));
       
        private static WebElements testChuuseElement = new(By.Id("fade-menu"));
        public static void AddWorkOutRun()
        {
            testChuuseElement.SelectElement();

            workOutsMenu.SelectElement();
            //workOutsMenu.ScrollToElementByJS();
            addWorkOuts.SelectElement();
            addWorkOuts.Click();
            
            //workoutArrowDown = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"mobile-nav\"]/li[1]/a")));
            //workoutArrowDown.Click();
            //workoutAdd = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"mobile-nav\"]/li[1]/ul/li[1]/a")));
            //workoutAdd.Click();
            //*[@id="mobile-nav"]/li[1]/ul/li[1]/a
        }
        //*[@id="mobile-nav"]/li[1]/a
    }
}
