
using DemoqQAPageObject.Pages.ResizablePage;
using DemoqQAPageObject.Tests;
using NUnit.Framework;
using System;
using System.Drawing;

namespace DemoqQAPageObject.ResizablTest

{
    [TestFixture]
    public class ResizableTest : BaseTest
    {
        public ResizablePage _resizablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _resizablePage = new ResizablePage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/resizable");
        }

       

        [Test]
        public void Size_When_Minimize_ClickAndHoldRelease()
        {
            var SizeBefore = _resizablePage.resizableBoxSize.Size;

            _resizablePage.ClickAndHoldAndResizeToMinimum();

            _resizablePage.BoxSize_Assertion(SizeBefore); 

        }
        //[Test]
        //public void Size_When_Maximize_ClickAndHoldRelease()
        //{
        //    var SizeBefore = _resizablePage.resizableBoxSize.Size;

        //    _resizablePage.ResizeByOffset();

        //    _resizablePage.BoxSize_AssertionMaximum(SizeBefore);
           

        //}
        [Test]
        public void ResizeElementByY()
        {
            _resizablePage.ResizeElementByY();

            _resizablePage.AssertAreElementResizeByY();
        }
        [Test]
        public void ResizeElementByX()
        {
            _resizablePage.ResizeElementByX();

            _resizablePage.AssertAreElementResizeByX();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        
    }
    }

