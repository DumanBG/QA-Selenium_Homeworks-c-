using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DemoqQAPageObject.Pages.ResizablePage
{
    public partial class ResizablePage
    {
        public void BoxSize_Assertion(Size resizableBoxSize)
        {
            Assert.AreNotEqual(resizableBoxSize, resizableBoxSize.Height);
        }
        public void BoxSize_AssertionMaximum(Size resizableBoxSize)
        {
            Assert.AreNotEqual(resizableBoxSize, resizableBoxSize.Height);
        }
        public void AssertAreElementResizeByY()
        {
            Assert.AreNotEqual(ResizableElementHeightBefore, ResizableElementHeightAfter);
        }
        public void AssertAreElementResizeByX()
        {
            Assert.AreNotEqual(ResizableElementWidhtBefore, ResizableElementWidthAfter);
        }
    }
}
