﻿using System;
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

            driver.Url = "http://www.google.com";

        }
    }
}
