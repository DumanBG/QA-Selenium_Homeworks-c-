using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages
{   
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            this.Builder = new Actions(Driver);
        }
        public IWebDriver Driver { get; }
        public WebDriverWait Wait { get; }
        public Actions Builder { get; }

        public IWebElement FindElement(By locator)
        {
            return Driver.FindElement(locator);
        }

        protected void FindElementAndClick(By locator)
        {
            FindElement(locator).Click();
        }

        protected void FindElementAndTypeText(By selector, string text)
        {
            FindElement(selector).SendKeys(text);
        }
        public IWebElement ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
        public void WaitForLoad(int timeoutSec = 15) // kogato e ravno moga da go promenq kogato go vikna v ()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}


