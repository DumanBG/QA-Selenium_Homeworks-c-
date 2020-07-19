using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.NavigationPage
{
    public partial class NavigationToPage : BasePage
    {

        public void NavigateTo(string sectionName)
        {
            naviagationToWidgets.Click();
            ScrollTo(interactions);
            interactionsSideBar(sectionName).Click();
        }

    }
}
