using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.DroppablePage
{
    public partial class DroppablePage
    {
        public IWebElement DragMe => Driver.FindElement(By.Id("draggable"));

        public IWebElement DropHere => Driver.FindElement(By.Id("droppable"));

        public IWebElement AcceptTab => Driver.FindElement(By.Id("droppableExample-tab-accept"));

        public IWebElement PreventPropogationTab => Driver.FindElement(By.Id("droppableExample-tab-preventPropogation"));

        public IWebElement RevertDraggableTab => Driver.FindElement(By.Id("droppableExample-tab-revertable"));

        public IWebElement Acceptable => Driver.FindElement(By.Id("acceptable"));

        public IWebElement NotAcceptable => Driver.FindElement(By.Id("notAcceptable"));

  
       

    }
}
