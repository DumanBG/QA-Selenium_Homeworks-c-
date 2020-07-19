using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoqQAPageObject.Pages.SelectablePage
{
    public partial class SelectablePage
    {
       
     public IWebElement secondTextButton => Driver.FindElement(By.XPath("//*[@id='verticalListContainer']/li[2]"));
        public List<IWebElement> AllElementsToSelect => Driver.
            FindElements(By.XPath("//div[@class='fade tab-pane active show']//ul[@class='vertical-list-container mt-4 list-group']//li")).ToList();

        public string firstElementColorBefore { get; set; }

        public string firstElementColorAfter { get; set; }

        public string secondElementColorBefore { get; set; }

        public string secondElementColorAfter { get; set; }

        public string thirdElementColorBefore { get; set; }

        public string thirdElementColorAfter { get; set; }


    }
}
