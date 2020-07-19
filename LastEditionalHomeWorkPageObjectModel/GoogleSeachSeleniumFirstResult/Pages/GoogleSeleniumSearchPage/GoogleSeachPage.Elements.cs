using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleSeachFirstResult.Pages.GoogleSeleniumSearchPage
{
    public partial class GooglePage :BasePage
    {



        public IWebElement SearchPanel2 => Driver.FindElement(By.Name("q"));

        public IWebElement FirstResult => Driver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div.r > a > div"));

        public IWebElement SeleniumHeadlineResult => Driver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div.r > a > h3"));

    }

}
