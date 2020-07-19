using DemoqQAPageObject.Pages;
using DemoqQAPageObject.Tests;
using DemoqQAPageObject.Utilities.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace DemoqQAPageObject.Interactions
{
    [TestFixture]
    public class Sortable : BaseTest
    {
        private SortablePage _sortablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/sortable");
            _sortablePage = new SortablePage(Driver);
     
        }

        

        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropOverOtherOption()
        {
            var index = 4;

            Builder.DragAndDropToOffset(_sortablePage.ListOfOptions[index], 100, 50).Perform();

            _sortablePage.AssertTextByIndex("Five", index + 1);
        }

        [Test]
        public void AllOptionsAreOrdered_When_DragAndDropSingleOption()
        {
            Builder.DragAndDropToOffset(_sortablePage.ListOfOptions[4], 100, 50).Perform();

            Assert.IsTrue(_sortablePage.ListOfOptions.All(o => o.Location.X == _sortablePage.Container.Location.X));
        }
        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropUnderOtherOption()
        {

            var index = 1;

            Builder.DragAndDropToOffset(_sortablePage.ListOfOptions[index], 0, 50).Perform();  //DragAndDropToOffset метод от библ билдер

            _sortablePage.AssertTextByIndex("Two", index + 1);
        }

        [TestCase("Three", "Five")]
        public void SortOtherElements(string firstElement, string secondElement)
        {
            _sortablePage.MoveTwoElementsAndCheckIsOthersSorted(firstElement, secondElement);

            _sortablePage.AssertAreElementsSortedAfterMoveOtherTwoElements();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
