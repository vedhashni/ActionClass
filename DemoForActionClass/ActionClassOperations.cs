using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoForActionClass
{
    public class ActionClassOperations:BaseClass
    {
        public void DragandDropMethod()
        {
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='credit2']/a"));
            IWebElement element2 = driver.FindElement(By.XPath("//*[@id='bank']/li"));
            Actions actions = new Actions(driver);
            actions.DragAndDrop(element1, element2).Build().Perform();
        }

        public void ToScroll()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,1500)");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
