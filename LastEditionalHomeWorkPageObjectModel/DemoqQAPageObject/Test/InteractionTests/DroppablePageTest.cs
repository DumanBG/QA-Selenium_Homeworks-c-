using DemoqQAPageObject.Pages.DroppablePage;
using DemoqQAPageObject.Tests;
using DemoqQAPageObject.Utilities.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqQAPageObject.Interactions
{
    [TestFixture]
    public class DroppableTest : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void Setup()
        {

            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/droppable");
            _droppablePage = new DroppablePage(Driver);

        }

        [Test]
        public void DropElementChangeColorOfTarget_When_DragAndDropDragMe()
        {
            string colorBefore = _droppablePage.GetColorBefore();

            _droppablePage.DragAndDrop();

            _droppablePage.AssertColorBeforeAndAfterAreNotEqual(colorBefore);
        }

       

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
