using DemoqQAPageObject.Pages;
using DemoqQAPageObject.Tests;
using DemoqQAPageObject.Utilities.Extensions;
using DemoqQAPageObject.Pages.SelectablePage;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Drawing;

namespace DemoqQAPageObject.Interactions
{
    [TestFixture]
    public class SelectableTest : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/selectable");
        }



        [Test]
        public void ChangeTextColor_WhenSelectedOneTime()
        {

        string colorBefore = _selectablePage.secondTextButton.GetColorBefore();
         
            _selectablePage.secondTextButton.Click();
           
            _selectablePage.AssertSelectedTextColorBeforeAndAfterWhenSingleClick(colorBefore);
        }

        [Test]
        public void SameTextColor_WhenSelected_By_DoubleClick()
        {

            string colorBefore = _selectablePage.secondTextButton.GetColorBefore();

            _selectablePage.textDoubleClick();

            _selectablePage.AssertSelectedTextColorBeforeAndAfterWhenDoubleClick(colorBefore);
        }
        [Test]
        public void SelectThreeElements()
        {
            _selectablePage.SelectThreeElements();

            _selectablePage.AssertAreElementsSelected();
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
