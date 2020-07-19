using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DemoqQAPageObject.Pages.Dragabble
{
    public partial class DragabblePage : BasePage
    {
        public DragabblePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement DraggableElemment => Driver.FindElement(By.Id( "dragBox"));
        public IWebElement  DragabbleRestrictionsLinkToClick => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));
        //public IWebElement ElementToFormatRestrictionX =>Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));
        public IWebElement BoxWithRestrictedX => Driver.FindElement(By.Id("restrictedX"));
        public IWebElement AxisDraggableSection => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));

        public IWebElement XAxisDragableElement => Driver.FindElement(By.XPath("//div[@class='axis-restriction-container mt-4']//div[normalize-space(text()) = 'Only X']"));

        public IWebElement YAxisDragableElement => Driver.FindElement(By.XPath("//div[@class='axis-restriction-container mt-4']//div[normalize-space(text()) = 'Only Y']"));
        public Point DraggableElementLocationBefore { get; set; }

        public Point DraggableElementLocationAfter { get; set; }

        public Point XAxisDraggableElementLocationBefore { get; set; }

        public Point XAxisDraggableElementLocationAfter { get; set; }

        public Point YAxisDraggableElementLocationBefore { get; set; }

        public Point YAxisDraggableElementLocationAfter { get; set; }
    }
}
