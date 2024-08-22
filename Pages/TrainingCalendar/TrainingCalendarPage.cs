using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsurgeTestsProject.Pages.TrainingCalendar
{
    internal class TrainingCalendarPage : BasePage
    {
        //элемент для проверки перехода на страницу TrainingCalendar
        private static WebElements trainingCalendarElement = new(By.XPath("//*[@id=\"breadcrumbs\"]/li[2]/a"));
        public static void OpenTrainingCalendarPage()
        {
            string url = "https://log.finalsurge.com/Calendar.cshtml";
            BasePage.OpenPage(url);
        }
        public static string GetTrainingCalendarPageElement()
        {
            string text = WebElements.GetTextWebElement(trainingCalendarElement);
            return text;
        }        

    }
}
