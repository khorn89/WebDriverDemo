using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;


namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initilize Driver
            IWebDriver driver = new ChromeDriver();

            //Set URL
            driver.Url = "http://www.google.com";

            //Find element
            var searchbox = driver.FindElement(By.Id("lst-ib"));

            //enter text into field 
            searchbox.SendKeys("pluralsight");

            //click search
            var GoogleSearch = driver.FindElement(By.Id("gsr"));
            GoogleSearch.Click();

            //call timeout
            driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));

            //image link
            var imageLink = driver.FindElements(By.ClassName("hdtb-mitem hdtb-msel hdtb-imb"))[0];
            imageLink.Click();


        }
    }
}
