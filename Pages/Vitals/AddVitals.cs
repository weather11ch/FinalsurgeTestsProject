using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalsurgeTestsProject.Pages.Vitals
{
    internal class AddVitals : BasePage
    {
        public static WebElements addVitalsButton = new(By.XPath("//*[@id=\"breadcrumbs\"]/div/button"));
        public static WebElements cancelVitalsButton = new(By.XPath("//*[@id=\"breadcrumbs\"]/div/button"));
        public static WebElements headAddDailyVitalsForm = new(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div/div[1]"));
        public static WebElements headDailyVitalsForm = new(By.XPath("/html/body/div[1]/div[3]/div/div/div[2]/div[1]"));
        public static WebElements dateField = new(By.XPath("//*[@id=\"v-date\"]/label"));
        public static WebElements dateButton = new(By.XPath("//*[@id=\"v-date\"]/span"));

        public static void AddVitalsButton() 
        {
            addVitalsButton.Click();
        }
        public static void CancelVitalsButton()
        {
            cancelVitalsButton.Click();
        }
        public static bool CheckDailyVitalsAddForm()
        {
            string headText = WebElements.GetTextWebElement(headAddDailyVitalsForm);
             if (headText == "DAILY VITALS ADD") { return true; }
            return false;
        }
        public static bool CheckDailyVitalsForm()
        {
            string headText = WebElements.GetTextWebElement(headDailyVitalsForm);
            if (headText == "DAILY VITALS") { return true; }
            return false;
        }

        public static void FillAddVitalsForm()
        { 
        dateField.Click();
        dateButton.Click();

        }
    }
}
