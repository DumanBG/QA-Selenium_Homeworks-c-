using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleSeachFirstResult.Pages.GoogleSeleniumSearchPage
{

    public partial class GooglePage : BasePage
    {
        public void AssertHeadlineResult(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("Selenium.dev", element.Text);
        }


    }

}