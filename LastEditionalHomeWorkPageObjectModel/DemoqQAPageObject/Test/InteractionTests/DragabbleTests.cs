
using DemoqQAPageObject.Pages.Dragabble;
using DemoqQAPageObject.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Test.InteractionTests
{
    [TestFixture]
    public class DragabbleTests : BaseTest
    {
        private DragabblePage _dragabblePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/dragabble");
            _dragabblePage = new DragabblePage(Driver);
        }
        [Test]
        public void DragableSimpleMove_Check_By_Position_Before_And_After()
        {
            var positionXbefore = _dragabblePage.DraggableElemment.Location.X;

            _dragabblePage.MoveByOfset();

            _dragabblePage.GetXLocation();
            _dragabblePage.AssertLocationByXBeforeAfter(positionXbefore);
            //Console.WriteLine()
        }

        [Test]
        public void DragableMoveToDifferentCoordinate_Y_will_Not_change_by_restriction()
        {
            _dragabblePage.DragabbleRestrictionsLinkToClick.Click();

            _dragabblePage.ClickAndHoldBoxWithRestrictionRelease();

            _dragabblePage.GetCoordinateYOfTheBoxWithRestrictionX();


            var sourceBoxRestrictionLocationYBefore = _dragabblePage.BoxWithRestrictedX.Location.Y;
            _dragabblePage.AssertBoxWithRestrictionXByYLocation(sourceBoxRestrictionLocationYBefore);


        }
            [Test]
        public void DragXAxisDraggableElementAndMovesOnlyByXAxis()
        {
            _dragabblePage.DragElementByXAxis();

            _dragabblePage.AssertIsXAxisDraggableElementIsMovedOnlyByXAxis();
        }

        [Test]
        public void DragYAxisDraggableElementAndMovesOnlyByYAxis()
        {
            _dragabblePage.DragElementByYAxis();

            _dragabblePage.AssertIsYAxisDraggableElementIsMovedOnlyByYAxis();
        }



        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
