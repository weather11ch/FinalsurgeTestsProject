using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V125.FedCm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsurgeTestsProject.Pages
{
    internal class Authorization : BasePage
    {
        private static WebElements emailField = new(By.Id("login_name"));        
        private static WebElements passwordField = new(By.Id("login_password"));
        private static WebElements signIn = new(By.XPath("//*[@id=\"login-validate\"]/div[2]/button"));
        private static WebElements welcomeNickname = new(By.XPath("/html/body/div[1]/header/div/div/div[3]/div/div/div/strong"));

        public static void LoginPasswordEnter()
        {
            emailField.Click();
            emailField.SendKeys("petijom149@alientex.com");
            passwordField.Click();
            passwordField.SendKeys("12345Tt12345!");
            signIn.Click();

        }                          
        public static string GetWelcomeNickname()
        {        
            string message = welcomeNickname.GetText();

            return message;
        }
    }
}
