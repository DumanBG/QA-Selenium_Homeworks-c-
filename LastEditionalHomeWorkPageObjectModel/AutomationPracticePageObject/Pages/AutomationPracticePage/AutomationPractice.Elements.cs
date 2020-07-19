using HomeworkPOM.Pages;
using OpenQA.Selenium;

namespace AutomationPracticePageObject.Pages.AutomationPracticePage
{
    public partial class AutomationPractice : BasePage

    {
        public IWebElement SignInButton => Driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a"));

        public IWebElement EmailSelectCreatAccount => Driver.FindElement(By.Id("email_create"));

        public IWebElement CreateAccountButton => Driver.FindElement(By.CssSelector("#SubmitCreate"));

        public IWebElement EmailBannerOnRegistrationForm => Driver.FindElement(By.CssSelector("#email"));

        public IWebElement LastNamePanel => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement FirstNamePanel => Driver.FindElement(By.Id("firstname"));

        public IWebElement PasswordPanel => Driver.FindElement(By.Id("passwd"));

        public IWebElement AddressPanel => Driver.FindElement(By.Id("address1"));

        public IWebElement CityPanel => Driver.FindElement(By.Id("city"));

        public IWebElement IdStatePanel => Driver.FindElement((By.Id("id_state")));

        public IWebElement PhoneMobile => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement PosteCodePanel => Driver.FindElement(By.Id("postcode"));

        public IWebElement RegisterButton => Driver.FindElement(By.XPath("//*[@id='submitAccount']/span/i"));

        public IWebElement AlertMessage => Driver.FindElement(By.XPath("//*[@id='center_column']/div"));





    }

}
