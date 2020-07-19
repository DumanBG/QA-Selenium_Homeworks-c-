using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.ResizablePage
{
    public partial class ResizablePage
    {

        public IWebElement sizeButton => Driver.FindElement(By.XPath("//*[@id='resizable']/span"));
        public IWebElement resizableBoxSize => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[1]/div"));
        public IWebElement ResizableElement => Driver.FindElement(By.XPath("//div[normalize-space(text()) = 'Resizable']//ancestor::div[@class='box react-resizable']"));
        public IWebElement ResizableElementToDrag => ResizableElement.FindElement(By.TagName("span"));
        public string ResizableElementWidhtBefore { get; set; }

        public string ResizableElementWidthAfter { get; set; }

        public string ResizableElementHeightBefore { get; set; }

        public string ResizableElementHeightAfter { get; set; }
    }
}
