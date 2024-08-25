using FinalsurgeTestsProject.Factories;
using FinalsurgeTestsProject.Pages;
using NUnit.Allure.Core;


namespace FinalsurgeTestsProject.Tests
{
    [AllureNUnit]
    public class BaseTest
    {
        const String basePageUrl = "https://log.finalsurge.com/";
        [SetUp]
        public void Setup()
        {
            Driver.GetDriver();
            Driver.WaitDriver(Driver.GetDriver(), 30);
            BasePage.OpenPage(basePageUrl);
            Authorization.LoginPasswordEnter();            
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
