using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsurgeTestsProject.Pages.Vitals
{
    internal class DailyVitalsPage : BasePage
    {
        public static void OpenDailyVitalsPage()
        {
            string url = "https://log.finalsurge.com/DailyVitals.cshtml";
            BasePage.OpenPage(url);
        }
    }
}
