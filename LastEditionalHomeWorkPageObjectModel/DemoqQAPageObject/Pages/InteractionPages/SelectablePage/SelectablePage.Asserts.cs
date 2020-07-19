using DemoqQAPageObject.Utilities.Extensions;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.SelectablePage
{
    public partial class SelectablePage
    {
       

        public void AssertSelectedTextColorBeforeAndAfterWhenDoubleClick(string colorBefore)
        {
            Assert.AreEqual(colorBefore, secondTextButton.GetColorBefore());
        }

        public void AssertSelectedTextColorBeforeAndAfterWhenSingleClick(string colorBefore)
        {
            Assert.AreNotEqual(colorBefore, secondTextButton.GetColorBefore());
        }
        public void AssertAreElementsSelected()
        {
            Assert.AreNotEqual(firstElementColorBefore, firstElementColorAfter);
            Assert.AreNotEqual(secondElementColorBefore, secondElementColorAfter);
            Assert.AreNotEqual(thirdElementColorBefore, thirdElementColorAfter);
        }
    }
}
    
