using FinalsurgeTestsProject.Factories;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace FinalsurgeTestsProject.Pages
{
    public class WebElements
    {
   
        public static IWebElement classicWebPlatformClick;
        public static IWebElement wecomeNickname;
        public static IWebElement workoutArrowDown;
        public static IWebElement workoutAdd;
        
        private readonly By? _locator;

        private Actions actions = new Actions(Driver.GetDriver());
        public WebElements(By locator) => _locator = locator;
        public IWebElement WebElement
        {
            get
            {
                WaitWebElementPresent();
                return Driver.GetDriver().FindElement(_locator);
            }
        }
        public void WaitWebElementPresent() => Driver.WaitDriver(Driver.GetDriver(),30).Until(drv => drv.FindElements(_locator).Count() > 0);
        public void WaitWebElement() => Driver.WaitDriver(Driver.GetDriver(), 30).Until(drv => drv.FindElement(_locator));

        public void SendKeys(string value)
        {
            //ScrollToElement();
            WebElement.SendKeys(value);
        }

        public void Click()
        {
            ScrollToElement();
            WebElement.Click();
        }
        //public void SelectMenuElement() => 
        //SelectElement select = new SelectElement(element);
        public  SelectElement SelectElement() 
        {
            SelectElement select = new SelectElement(WebElement);
            return select;
        }
        
        //SelectElement select = new SelectElement(By.Id("selectnav1"));
        public string GetAttribute(string atr) => WebElement.GetAttribute(atr);

        public void ScrollToElement() => actions.MoveToElement(WebElement);

        public void ScrollToElementByJS() => ((IJavaScriptExecutor)Driver.GetDriver()).ExecuteScript("argumnet[0].scrollIntoView(true)", WebElement);

        public static void AcceptAlert()
        {
            var alert = Driver.GetDriver().SwitchTo().Alert();
            alert.Accept();
        }

        public static bool IsAlertShown()
        {
            try
            {
                Driver.GetDriver().SwitchTo().Alert();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public void SwitchToFrame()
        {
            Driver.GetDriver().SwitchTo().Frame(WebElement);
        }

        public static void FrmaeExit() => Driver.GetDriver().SwitchTo().DefaultContent();

        public string GetText() => WebElement.Text;

        //получение текстового значения элемента
        public static string GetTextWebElement(WebElements element)
        {
            string text = element.GetText();
            return text;
        }
    }
}

