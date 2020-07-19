using AutomationPracticePageObject.Factories;
using AutomationPracticePageObject.Pages.AutomationPracticePage;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static AutomationPracticePageObject.Test.BaseTest;

namespace AutomationPracticePageObject.Test
{
    public class TestAutomationPracticePageObjectModel : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [TearDown]
        public void TearDown()
        { Driver.Quit(); }

        [Test]

        public void AutomationPracticeValidEmail()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            automationPractice.SignInButton.Click();

            var user = AutomationPracticeFactories.Create();
            automationPractice.WaitForLoad();
            automationPractice.EmailSelectCreatAccount.Click();
            automationPractice.FillEmail(user);
            automationPractice.CreateAccountButton.Click();

            Thread.Sleep(10000);
            automationPractice.WaitForLoad();
            automationPractice.AssertCorrectEmailDisplay(automationPractice.EmailBannerOnRegistrationForm);

        }
        [Test]
        public void RegisterWithoutFirstName()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();


            automationPractice.FillForm(user);
            automationPractice.FirstNamePanel.Clear();
            automationPractice.RegisterButton.Click();

            string msg = "firstname is required.";
            automationPractice.AssertAlertErrorMessage(msg, automationPractice.AlertMessage);

        }

        [Test]
        public void RegisterWithoutPasword()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();

            automationPractice.FillForm(user);
            automationPractice.PasswordPanel.Clear();
            automationPractice.RegisterButton.Click();

            string msg = "passwd is required.";
            automationPractice.AssertAlertErrorMessage(msg, automationPractice.AlertMessage);

        }
        [Test]
        public void RegisterLetterInZipcode()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();

            automationPractice.FillForm(user);
            automationPractice.PosteCodePanel.Clear();
            automationPractice.PosteCodePanel.SendKeys("abCd");
            automationPractice.RegisterButton.Click();

            string msg = "The Zip/Postal code you've entered is invalid. It must follow this format: 00000";
            automationPractice.AssertAlertErrorMessage(msg, automationPractice.AlertMessage);

        }

        [Test]
        public void RegisterWithoutPhoneNumber()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();

            automationPractice.FillForm(user);
            automationPractice.PhoneMobile.Clear();
            automationPractice.RegisterButton.Click();

            string msg = "You must register at least one phone number.";
            automationPractice.AssertAlertErrorMessage(msg, automationPractice.AlertMessage);

        }
        [Test]
        public void RegisterWithFirstNameStartWithSpace()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();

            automationPractice.FillForm(user);
            automationPractice.FirstNamePanel.Clear();
            automationPractice.FirstNamePanel.SendKeys(" Duman" + Keys.Tab);
            automationPractice.RegisterButton.Click();

            string msg = "firstname is required.";
            automationPractice.AssertAlertErrorMessage(msg, automationPractice.AlertMessage);

        }

    }



}