using FinalsurgeTestsProject.Factories;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FinalsurgeTestsProject.Pages.Workouts
{
    internal class Workouts : BasePage
    {
        //элемент для проверки перехода на страницу Add Workout
        private static WebElements addWorkoutPageElement = new(By.XPath("//*[@id=\"breadcrumbs\"]/li[3]/a"));
        //элемент для выбора пункта меню Run 
        private static WebElements run = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[1]/div[1]/a"));
        //элементы окна ADD NEW WORKOUT
        private static WebElements timeOfDay = new(By.XPath("//*[@id=\"WorkoutTime\"]"));
        private static WebElements workoutName = new(By.XPath("//*[@id=\"Name\"]"));
        private static WebElements workoutDescription = new(By.XPath("//*[@id=\"Desc\"]"));
        private static WebElements addWorkoutButton = new(By.Id("saveButton"));
        //элементы окна workout details
        private static WebElements workoutDetails = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/div/div[2]/span"));
        private static WebElements activityType = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/div/div[2]/span"));
        private static WebElements activityTypeName = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/div/div[3]"));
        private static readonly WebElements savedWorkoutDescription  = new(By.XPath("//*[@class=\"muted\"]/following-sibling::*"));
        private static readonly WebElements savedWorkoutDescription1 = new(By.XPath(" //*[@class=\" testme dont-break-out\"]"));
                

        //пока не нужные
        private static WebElements workOutsMenu = new(By.Id("selectnav1"));
        private static WebElements addWorkOuts = new(By.XPath("//*[@id=\"selectnav1\"]/option[3]"));
        private static WebElements testChuuseElement = new(By.Id("fade-menu"));

        //получение текстового значения элемента addWorkoutPageElement
        public static string GetTextAddWorkoutPageElement() 
        {
            string text = WebElements.GetTextWebElement(addWorkoutPageElement);            
            return text;
        }
        //
        public static void AddNewWorkoutRun(string name, string description)
        {            
            run.Click();
            Thread.Sleep(1000);
            workoutName.WaitElement();
            workoutName.Click();
            workoutName.SendKeys($"{name}");
            workoutDescription.Click();
            workoutDescription.SendKeys($"{description}");
            
            ((IJavaScriptExecutor)Driver.GetDriver()).ExecuteScript("window.scrollBy(0,600)", "");
            
            addWorkoutButton.ScrollToElement();
            addWorkoutButton.Click();
        }    
        public static bool CheckNewdWorkoutDetails(string name, string description)
        {
            string nametest1 = WebElements.GetTextWebElement(activityTypeName);
            savedWorkoutDescription.WaitElement();
            //Thread.Sleep(1000);            
            string nametest2 =  savedWorkoutDescription1.GetText().Substring(22);
            
            if (name == nametest1 && description == nametest2)
                {return true;} else { return false; };
        }
    }
}
