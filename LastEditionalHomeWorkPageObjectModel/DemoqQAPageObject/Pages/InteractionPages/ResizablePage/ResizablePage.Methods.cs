using DemoqQAPageObject.Pages;
using DemoqQAPageObject.Utilities.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver)
           : base(driver)
        {
        }
        public void ClickAndHoldAndResizeToMinimum()
        {
            Builder.ClickAndHold(sizeButton).MoveByOffset( 1, 1).Release().Perform();
        }
        
        public void ResizeByOffset()
        {
            Builder.ClickAndHold(sizeButton).MoveByOffset(10, 10).Release().Perform();
        }
        public void ResizeElementByX()
        {
            ScrollTo(ResizableElement);
            ResizableElementWidhtBefore = ResizableElement.GetCssValue("width");
            Builder.ClickAndHold(ResizableElementToDrag)
                .MoveByOffset(120, 60)
                .Release()
                .Perform();
            ResizableElementWidthAfter = ResizableElement.GetCssValue("width");
        }
        public void ResizeElementByY()
        {
            ScrollTo(ResizableElement);
            ResizableElementHeightBefore = ResizableElement.GetCssValue("height");
            Builder.ClickAndHold(ResizableElementToDrag)
                .MoveByOffset(120, 60)
                .Release()
                .Perform();
            ResizableElementHeightAfter = ResizableElement.GetCssValue("height");
        }
      

    }
}
