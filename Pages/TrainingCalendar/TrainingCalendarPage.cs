using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsurgeTestsProject.Pages.TrainingCalendar
{
    internal class TrainingCalendarPage : BasePage
    {       
        public static void OpenTrainingCalendarPage()
        {
            string url = "https://log.finalsurge.com/Calendar.cshtml";
            BasePage.OpenPage(url);
        }
    }
}
