using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsurgeTestsProject.Pages
{
    internal class ButtonMenu : BasePage
    {
        public static WebElements calendarButton = new(By.XPath("//*[@class=\"icsw16-day-calendar\"]"));
        public static WebElements trainigCalendarMenu = new(By.XPath("//*[@id=\"breadcrumbs\"]/li[2]/a"));
        public static void CalendarOpenByButton()
        {
            calendarButton.Click();
            string text = trainigCalendarMenu.GetText();

        }
    }
}
