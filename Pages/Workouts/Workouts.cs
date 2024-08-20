using FinalsurgeTestsProject.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using System.Xml.Linq;
using System;
using OpenQA.Selenium.Interactions;

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

        //пока не нужные
        private static WebElements workOutsMenu = new(By.Id("selectnav1"));
        private static WebElements addWorkOuts = new(By.XPath("//*[@id=\"selectnav1\"]/option[3]"));

        private static WebElements testChuuseElement = new(By.Id("fade-menu"));

        //получение текстового значения элемента
        public static string GetTextAddWorkoutPageElement() 
        {
            string text = addWorkoutPageElement.GetText();
            return text;
        }

        //
        public static void AddNewWorkOutRun()
        {
            run.Click();
            //workoutName.Click();
            workoutName.SendKeys("first run");
            workoutDescription.Click();
            workoutDescription.SendKeys("running");
            addWorkoutButton.ScrollToElement();
            addWorkoutButton.Click();
        }    
    }
}
