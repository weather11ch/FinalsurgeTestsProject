using FinalsurgeTestsProject.Factories;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace FinalsurgeTestsProject.Pages
{
    public class BasePage : WebElements
    {
        protected static IWebDriver driver = Driver.GetDriver();
        protected static WebDriverWait wait = Driver.WaitDriver(driver, 30);

        public static void OpenPage(string url)
        {
            Driver.GetDriver().Navigate().GoToUrl($"{url}");
            Driver.GetDriver().Manage().Window.Maximize();
        }
        public static void CloseMainPage()
        {
            driver.Close();
        }

        public static void Authorization()
        {
            emailField = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.Id("login_name")));
            emailField.Click();
            emailField.SendKeys("petijom149@alientex.com");
            passwordField = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            passwordField.Click();
            passwordField.SendKeys("12345Tt12345!");

            signIn = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"login-validate\"]/div[2]/button")));
            signIn.Click();
            Thread.Sleep(1000);
            //*[@id="__layout"]/div/div[2]/section/div/div/div/div[3]/div/div[2]/a/span
            //classicWebPlatformClick = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__layout\"]/div/div[2]/section/div/div/div/div[3]/div/div[2]/a/span")));
            //classicWebPlatformClick.Click();

        }
        public static string GetWelcomeNickname()
        {
            wecomeNickname =  Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/div/div/div[3]/div/div/div/strong")));
            string message = wecomeNickname.Text;

            return message;
        }

        //html/body/div[1]/header/div/div/div[3]/div/div/div/strong
        //html/body/div[1]/header/div/div/div[3]/div/div/div/strong
    }
}
