using DemoqQAPageObject.Pages;
using DemoqQAPageObject.Utilities.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.SelectablePage
{
  public partial class SelectablePage :BasePage
    {
      


        public SelectablePage(IWebDriver driver)
               : base(driver)
        {

            
        }
        
        public string GetColorBefore()
        {
            return secondTextButton.GetColorBefore();
        }
        public void textSingleClick()
        {
            secondTextButton.Click();
        }
        public void textDoubleClick()
        {
            Builder.DoubleClick(secondTextButton);
        }
        public void SelectThreeElements()
        {
            firstElementColorBefore = AllElementsToSelect[1].GetCssValue("background-color");
            secondElementColorBefore = AllElementsToSelect[2].GetCssValue("background-color");
            thirdElementColorBefore = AllElementsToSelect[3].GetCssValue("background-color");
            AllElementsToSelect[1].Click();
            AllElementsToSelect[2].Click();
            AllElementsToSelect[3].Click();
            firstElementColorAfter = AllElementsToSelect[1].GetCssValue("background-color");
            secondElementColorAfter = AllElementsToSelect[2].GetCssValue("background-color");
            thirdElementColorAfter = AllElementsToSelect[3].GetCssValue("background-color");
        }



    }
}
