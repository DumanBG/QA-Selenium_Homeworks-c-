using AutomationPracticePageObject.Models;
using HomeworkPOM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AutomationPracticePageObject.Pages.AutomationPracticePage
{
    public partial class AutomationPractice :BasePage
    {
        public void AssertCorrectEmailDisplay(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("dumanTester@abv.bg", element.GetProperty("value"));

        }
        public void AssertAlertErrorMessage(string text, IWebElement element)
        {

            this.WaitForLoad();
            StringAssert.Contains(text, element.Text);
        }

     
    }

}
