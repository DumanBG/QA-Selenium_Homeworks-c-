

using OpenQA.Selenium;
using System;

namespace DemoqQAPageObject.Pages.Dragabble
{
    public partial class DragabblePage : BasePage
    {
        

        public void GetXLocation()
        {
            var sourcePosX = DraggableElemment.Location.X;

           
        }
        public void MoveByOfset()
        {
            Builder
                  .ClickAndHold(DraggableElemment)
                  .MoveByOffset(100, 100)
                  .Release()
                  .Perform();
        }
        public void ClickOndragabbleRestriction()
        {
            DragabbleRestrictionsLinkToClick.Click();
}
        public void BoxWhitrestrictionCoordinateX()
        {
            DragabbleRestrictionsLinkToClick.Click();
        }

        public void GetCoordinateYOfTheBoxWithRestrictionX()
        {
           var GetCoordinateOfboxWithRestrictedX=BoxWithRestrictedX.Location.Y;
        }

        public void ClickAndHoldBoxWithRestrictionRelease()
        {
            Builder
               .ClickAndHold(BoxWithRestrictedX)
               .MoveByOffset(300, 300)
               .Release()
               .Perform();
        }
        public void DragElement()
        {
            DraggableElementLocationBefore = DraggableElemment.Location;
            Builder.DragAndDropToOffset(DraggableElemment, 100, 40).Perform();
            DraggableElementLocationAfter = DraggableElemment.Location;
        }

        public void DragElementByXAxis()
        {
            AxisDraggableSection.Click();
            WaitForLoad();
            XAxisDraggableElementLocationBefore = XAxisDragableElement.Location;
            Builder.DragAndDropToOffset(XAxisDragableElement, 100, 40).Perform();
            XAxisDraggableElementLocationAfter = XAxisDragableElement.Location;
        }

        public void DragElementByYAxis()
        {
            AxisDraggableSection.Click();
            WaitForLoad();
            YAxisDraggableElementLocationBefore = YAxisDragableElement.Location;
            Builder.DragAndDropToOffset(YAxisDragableElement, 100, 40).Perform();
            YAxisDraggableElementLocationAfter = YAxisDragableElement.Location;
        }

    }
}