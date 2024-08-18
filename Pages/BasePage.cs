using FinalsurgeTestsProject.Factories;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace FinalsurgeTestsProject.Pages
{
    public class BasePage 
    {       
        public static void OpenPage(string url)
        {
            Driver.GetDriver().Navigate().GoToUrl($"{url}");
            Driver.GetDriver().Manage().Window.Maximize();
        }
        public static void CloseMainPage()
        {
            Driver.CloseDriver();
        }   
    }
}
