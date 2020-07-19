using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.Dragabble
{
    public partial class DragabblePage
    {
        public void AssertLocationByXBeforeAfter(int sourcePosXBefore)
        {
            Assert.AreNotEqual(sourcePosXBefore, DraggableElemment.Location.X);
      
        }
        public void AssertBoxWithRestrictionXByYLocation(int GetCoordinateOfboxWithRestrictedX)
        {

          Assert.AreEqual(GetCoordinateOfboxWithRestrictedX, BoxWithRestrictedX.Location.Y, "Fail Y change but didn't");
        }

        public void AssertIsDraggableElementMoved()
        {
            Assert.AreNotEqual(DraggableElementLocationBefore, DraggableElementLocationAfter);
        }

        public void AssertIsXAxisDraggableElementIsMovedOnlyByXAxis()
        {
            Assert.AreNotEqual(XAxisDraggableElementLocationBefore.X, XAxisDraggableElementLocationAfter.X);
            Assert.AreEqual(XAxisDraggableElementLocationBefore.Y, XAxisDraggableElementLocationAfter.Y);
        }

        public void AssertIsYAxisDraggableElementIsMovedOnlyByYAxis()
        {
            Assert.AreEqual(YAxisDraggableElementLocationBefore.X, YAxisDraggableElementLocationAfter.X);
            Assert.AreNotEqual(YAxisDraggableElementLocationBefore.Y, YAxisDraggableElementLocationAfter.Y);
        }

    }
}
