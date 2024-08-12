using FinalsurgeTestsProject.Factories;
using FinalsurgeTestsProject.Pages;


namespace FinalsurgeTestsProject.Tests
{    
    public class BaseTest
    {
        const String basePageUrl = "https://log.finalsurge.com/";
        [SetUp]
        public void Setup()
        {
            Driver.GetDriver();
            Driver.WaitDriver(Driver.GetDriver(), 30);
            BasePage.OpenPage(basePageUrl);
            BasePage.Authorization();            
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
