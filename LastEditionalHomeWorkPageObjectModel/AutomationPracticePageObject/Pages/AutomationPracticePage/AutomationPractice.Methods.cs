
using AutomationPracticePageObject.Models;

using HomeworkPOM.Pages;
using OpenQA.Selenium;


namespace AutomationPracticePageObject.Pages.AutomationPracticePage
{
    public partial class AutomationPractice : BasePage

    {


        public AutomationPractice(IWebDriver driver)
            : base(driver)
        {
        }


        public void FillEmail(AutomationPracticeFromModel user)
        {
            EmailSelectCreatAccount.SendKeys(user.Email);

        }
        public void FillForm(AutomationPracticeFromModel user)
        {
            SignInButton.Click();
            WaitForLoad();
            EmailSelectCreatAccount.Click();
            FillEmail(user);
            WaitForLoad();
            CreateAccountButton.Click();
            WaitForLoad();
            LastNamePanel.SendKeys(user.LastNamePanel + Keys.Tab);
            FirstNamePanel.SendKeys(user.FirstNamePanel + Keys.Tab);
            PasswordPanel.SendKeys(user.PasswordPanel + Keys.Tab);
            AddressPanel.SendKeys(user.AddressPanel + Keys.Tab);
            CityPanel.SendKeys(user.CityPanel + Keys.Tab);
            IdStatePanel.SendKeys(user.IdStatePanel + Keys.Tab);
            PhoneMobile.SendKeys(user.PhoneMobile + Keys.Tab);
            PosteCodePanel.SendKeys(user.PosteCodePanel + Keys.Tab);

        }

    }
}

