using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoqQAPageObject.Pages
{
    public partial class SortablePage
    {
        public List<IWebElement> ListOfOptions => Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]")).ToList();

        public IWebElement Container => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div"));
        public IWebElement FirstSortableElement(string firstElement) => Driver.FindElement(By.XPath($"//*[@class='vertical-list-container mt-4']//*[normalize-space(text()) = '{firstElement}']"));

        public IWebElement SecondSortableElement(string secondElement) => Driver.FindElement(By.XPath($"//*[@class='vertical-list-container mt-4']//*[normalize-space(text()) = '{secondElement}']"));
        public List<IWebElement> AllSortableElements => Driver.FindElements(By.XPath($"//*[@class='vertical-list-container mt-4']//*")).ToList();
    }
}
