using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Robo_Selenium
{
    public class AutomationWeb
    {
        public IWebDriver Driver;
        public AutomationWeb()
        {
            Driver = new EdgeDriver();
        }
        public void TestWeb()
        {
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("teste");
            Driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Console.ReadLine();
            Driver.Quit();

        }

    }
}