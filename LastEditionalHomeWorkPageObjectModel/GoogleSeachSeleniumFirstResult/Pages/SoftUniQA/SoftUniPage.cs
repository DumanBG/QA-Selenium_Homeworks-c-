using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleSeachFirstResult.Pages.SoftUniQA
{
    public class SoftUniPage : BasePage

    {


        public SoftUniPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        // public IWebElement TeachingNavBar => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/a/span"));

        public IWebElement SerchButton => Driver.FindElement(By.CssSelector("# search-icon-container > a > span > i")); //click wait
        public IWebElement SearchPlaceToWrite => Driver.FindElement(By.Id("search-input")); //sendkey
        public IWebElement QaAutomationCourseNavBar => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul[2]/div[1]/ul/li/a"));

        public object H1Tag { get; internal set; }

        public void ClickSearchWriteToNavigate(IWebDriver webDriver)
        {
            SerchButton.Click();
            SearchPlaceToWrite.SendKeys("QA Automation - май 2020");
            SearchPlaceToWrite.Submit();

        }
    }
}
