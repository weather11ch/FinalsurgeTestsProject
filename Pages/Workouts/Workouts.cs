using FinalsurgeTestsProject.Factories;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace FinalsurgeTestsProject.Pages.Workouts
{
    internal class Workouts : BasePage
    {
        //элемент для проверки перехода на страницу Add Workout
        private static WebElements addWorkoutPageElement = new(By.XPath("//*[@id=\"breadcrumbs\"]/li[3]/a"));
        //элементы для выбора пункта меню Activity Type 
        public static WebElements run = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[1]/div[1]/a"));
        private static WebElements bike = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[2]/div[1]/a"));
        private static WebElements swim = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[3]/div[1]/a"));
        private static WebElements crossTraining = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[4]/div[1]/a"));
        private static WebElements walk = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[5]/div[1]/a"));
        private static WebElements restDay = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[6]/div[1]/a"));
        private static WebElements strenghTraining = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[7]/div[1]/a"));
        private static WebElements recoveryRehub = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[8]/div[1]/a"));
        private static WebElements other = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[9]/div[1]/a"));
        private static WebElements transition = new(By.XPath("//*[@id=\"blog_accordion_left\"]/div[10]/div[1]/a"));
        private static WebElements element;
        //элементы окна ADD NEW WORKOUT
        private static WebElements timeOfDay = new(By.XPath("//*[@id=\"WorkoutTime\"]"));
        private static WebElements time = new(By.XPath("/html/body/ul/li[29]"));

        private static WebElements workoutName = new(By.XPath("//*[@id=\"Name\"]"));
        private static WebElements workoutDescription = new(By.XPath("//*[@id=\"Desc\"]"));
        private static WebElements addWorkoutButton = new(By.Id("saveButton"));
        private static WebElements showPlannedDistanceDuration = new(By.XPath("//*[@id=\"col1\"]/div[2]/div[2]/div[3]/label/span"));
        private static WebElements plannedDistance = new(By.XPath("//*[@id=\"PDistance\"]"));
        private static WebElements plannedDuration = new(By.XPath("//*[@id=\"PDuration\"]"));
        private static WebElements goodFeel = new(By.XPath("//*[@id=\"col1\"]/div[2]/div[2]/div[8]/div[1]/div/div/label[2]"));
        private static WebElements perceivedEffort = new(By.XPath("//*[@id=\"PerEffort\"]"));
        private static WebElements selectPerceivedEffort = new(By.XPath("//*[@id=\"PerEffort\"]/option[5]"));
        private static WebElements minHR = new(By.XPath("//*[@id=\"MinHR\"]"));
        private static WebElements AvgHR = new(By.XPath("//*[@id=\"AvgHR\"]"));
        private static WebElements MaxHR = new(By.XPath("//*[@id=\"MaxHR\"]"));
        private static WebElements caloriesBurned = new(By.XPath("//*[@id=\"kCal\"]"));

        //элементы окна workout details
        private static WebElements workoutDetails = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/div/div[2]/span"));
        private static WebElements activityType = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/div/div[2]/span"));
        private static WebElements activityTypeName = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/div/div[3]"));
        private static readonly WebElements savedWorkoutDescription  = new(By.XPath("//*[@class=\" testme dont-break-out\"]"));

        private static readonly WebElements savedHowIfelt = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/div[2]/span"));                     
        private static readonly WebElements s = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/div[4]/span"));                     
        private static readonly WebElements savedMinHR = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/p/small[2]"));                     
        private static readonly WebElements savedAvgHR = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/p/small[2]"));                     
        private static readonly WebElements savedMaxHR = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/div[4]/span"));                     
        private static readonly WebElements savedCalories = new(By.XPath("//*[@id=\"EditProfile\"]/div/div[1]/div[4]/span"));                     

        //получение текстового значения элемента addWorkoutPageElement
        public static string GetTextAddWorkoutPageElement() 
        {
            string text = WebElements.GetTextWebElement(addWorkoutPageElement);            
            return text;
        }        
        public static bool CheckNewdWorkoutDetails(string name, string description)
        {
            string nametest1 = WebElements.GetTextWebElement(activityTypeName);
            savedWorkoutDescription.WaitElement();
            //Thread.Sleep(1000);            
            string nametest2 =  savedWorkoutDescription.GetText().Substring(22);
            
            if (name == nametest1 && description == nametest2)
                {return true;} else { return false; };
        }
        //добавление нового workout в переменной element передается activity type
        public static void AddNewWorkout(string elem, string name, string description)
        {
            
            switch (elem)
                {
                case "run": element = run; break;
                case "bike": element = bike; break;
                case "swim": element = swim; break;
                case "crossTraining": element = crossTraining; break;
                case "walk": element = walk; break;
                case "restDay": element = restDay; break;
                case "strenghTraining": element = strenghTraining; break;
                case "recoveryRehub": element = recoveryRehub; break;
                case "other": element = other; break;
                case "transition": element = transition; break;
            }
            element.Click();
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

        public static void AddNewBasicWorkout(string elem, string name, string description, int mi)
        {
            switch (elem)
            {
                case "run": element = run; break;
                case "bike": element = bike; break;
                case "swim": element = swim; break;
                case "crossTraining": element = crossTraining; break;
                case "walk": element = walk; break;               
                case "transition": element = transition; break;
            }
            element.Click();
            Thread.Sleep(1000);
            timeOfDay.Click();
            time.Click();
            workoutName.WaitElement();
            workoutName.Click();
            workoutName.SendKeys($"{name}");
            workoutDescription.Click();
            workoutDescription.SendKeys($"{description}");
            showPlannedDistanceDuration.Click();
            plannedDistance.Click();
            plannedDistance.SendKeys($"{mi}");
            plannedDuration.Click();
            plannedDuration.SendKeys("01:00:00");
            goodFeel.Click();
            perceivedEffort.Click();
            selectPerceivedEffort.Click();
            ((IJavaScriptExecutor)Driver.GetDriver()).ExecuteScript("window.scrollBy(0,200)", "");
            if (elem != "swim")
            {
                minHR.Click();
                minHR.SendKeys("100");
                AvgHR.Click();
                AvgHR.SendKeys("120");
                MaxHR.Click();
                MaxHR.SendKeys("160");
            }

            caloriesBurned.Click();
            caloriesBurned.SendKeys("200");

            ((IJavaScriptExecutor)Driver.GetDriver()).ExecuteScript("window.scrollBy(0,600)", "");
            addWorkoutButton.ScrollToElement();
            addWorkoutButton.Click();
        }

        public static bool CheckNewBasicdWorkoutDetails(string element, string name, string description, int mi)
        {
            string nametest1 = WebElements.GetTextWebElement(activityTypeName);
            savedWorkoutDescription.WaitElement();
            //Thread.Sleep(1000);            
            string nametest2 = savedWorkoutDescription.GetText().Substring(22);
            string savedDescriptiom = nametest2.Substring(0, description.Length);
            string savedPlanned = nametest2.Substring(description.Length+2);
            
            string head = WebElements.GetTextWebElement(workoutDetails);
            string activitytype = WebElements.GetTextWebElement(activityType);
            string howIfelt = WebElements.GetTextWebElement(savedHowIfelt);

            string replacement = "";
            string pattern = @"\s";
            activitytype = Regex.Replace(activitytype, pattern, replacement, RegexOptions.IgnoreCase);
            
            if (name == nametest1 && description == savedDescriptiom
                && howIfelt == "Good" && activitytype.ToLower() == element.ToLower()
                && savedPlanned == "Planned: 2.00 mi ~ 1:00:00")
            { return true; }
            else { return false; };
        }
    }
}
