using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages
{
    public partial class SortablePage
    {
        public void AssertTextByIndex(string expectedText, int index)
        {
            Assert.AreEqual(expectedText, ListOfOptions[index].Text);
        }
        public void AssertAreElementsSortedAfterMoveOtherTwoElements()
        {
            Assert.AreEqual("Four", AllSortableElements[2].Text);
        }
    }
}
