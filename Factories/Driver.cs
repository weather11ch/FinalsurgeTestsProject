using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace FinalsurgeTestsProject.Factories
{
    internal class Driver
    {
        public static IWebDriver? _driver;
        public static WebDriverWait? _wait;
        private static IWebDriver SetupDriver() => _driver ??= new ChromeDriver();
        public static IWebDriver GetDriver() => _driver ??= SetupDriver();
        public static WebDriverWait WaitDriver(IWebDriver driver, double waitTime) => _wait ??= new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
        //Actions action = new Actions(_driver);
        //обнуление драйвера
        public static void QuitDriver()
        {
            _driver.Close();
            _driver.Quit();
            _driver = null;
            _wait = null;
        }
        public static void CloseDriver()
        {
            _driver.Close();

        }
    }
}
