using DemoqQAPageObject.Utilities.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public string GetColorBefore()
        {
            return DropHere.GetColorBefore();
        }

        public void DragAndDrop(IWebElement dragElement, IWebElement dropElement)
        {
            Builder.DragAndDrop(dragElement, dropElement).Perform();
        }

        public void DragAndDrop()
        {
            Builder.DragAndDrop(DragMe, DropHere).Perform();
        }
   

    }
}

