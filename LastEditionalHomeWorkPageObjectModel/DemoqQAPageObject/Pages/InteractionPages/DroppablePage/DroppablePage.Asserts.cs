using DemoqQAPageObject.Utilities.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.DroppablePage
{
    public partial class DroppablePage
    {
        public void AssertColorBeforeAndAfterAreNotEqual(string colorBefore)
        {
            Assert.AreNotEqual(colorBefore, DropHere.GetColorBefore());
        }

        public void ColorChanged_Assertion(string classAfterAction)
        {

            StringAssert.Contains("ui-state-highlight", classAfterAction);
        }
    }
}

