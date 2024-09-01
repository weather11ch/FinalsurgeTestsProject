using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsurgeTestsProject.Pages.Vitals
{
    internal class DailyVitalsPage : BasePage
    {
        //элемент для проверки перехода на страницу DailyVitals
        private static WebElements dailyVitalsPageElement = new(By.XPath("//*[@id=\"breadcrumbs\"]/li[3]/span"));
        //*[@id="breadcrumbs"]/li[3]/span
        public static void OpenDailyVitalsPage()
        {
            string url = "https://log.finalsurge.com/DailyVitals.cshtml";
            BasePage.OpenPage(url);
        }
        //получение текстового значения элемента DailyVitalsPage
        public static string GetTextDailyVitalsPageElement()
        {
            string text = WebElements.GetTextWebElement(dailyVitalsPageElement);
            return text;
        }
    }
}
