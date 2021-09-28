using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoForActionClass
{
    public class BaseClass
    {
        public static IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/test/drag_drop.html";
            //Used to maximize the window
            driver.Manage().Window.Maximize();

        }
            
        [TearDown]
        public void TearDown()
        {
            //Used to close the opened session
            driver.Quit();
        }
    }
}
