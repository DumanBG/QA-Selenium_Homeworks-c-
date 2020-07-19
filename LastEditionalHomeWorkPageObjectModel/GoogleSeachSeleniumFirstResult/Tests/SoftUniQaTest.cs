

using GoogleSeachFirstResult.Pages.SoftUniQA;
using GoogleSeachFirstResult.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Net.Http.Headers;
using System.Threading;

namespace SoftUniQaTest.Tests
{
    public class SoftUniQaTest : BaseTest
    {




        [SetUp]
        public void Init()
        {
            
            Initialize();
            Driver.Navigate().GoToUrl("https://softuni.bg/");
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void ThereAreHeadingTagH1()
        {


            IWebElement SerchButton = Driver.FindElement(By.Id("search-icon-container"));
            SerchButton.Click();
            IWebElement SearchPlaceToWrite = Driver.FindElement(By.Id("search-input"));
            SearchPlaceToWrite.SendKeys("QA Automation - май 2020");
            SearchPlaceToWrite.Submit();


            var resultatOfSearch = Driver.FindElement(By.XPath("//*[@id='fast-track-instance-results']/ul/li[1]/div/a"));
            resultatOfSearch.Click();
         
        

            //..String actualtitle = Driver.FindElement(By.Id("course-description-no-video")).Text.ToString();

         //   string actualTitle = Driver.FindElement(By.CssSelector("header h1")).ToString().Trim();

         //  Assert.AreEqual(expectedtitle, actualTitle);

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

        }
    }
}
