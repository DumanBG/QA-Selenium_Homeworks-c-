using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.NavigationPage
{
    public partial class NavigationToPage : BasePage
    {
        public NavigationToPage(IWebDriver driver) : base(driver)
        {
        }
        // елементите тук са пропърти и трябва да са с главна

        public IWebElement naviagationToWidgets => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Widgets']//ancestor::div[@class='card mt-4 top-card']"));


        public IWebElement interactions => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Date Picker']"));

        public IWebElement interactionsSideBar(string sectionName) => Driver.FindElement(By.XPath($"//*[normalize-space(text()) = '{sectionName}']"));

        public IWebElement pageHeader => Wait.Until(d => d.FindElement(By.ClassName("main-header")));

    }
}
