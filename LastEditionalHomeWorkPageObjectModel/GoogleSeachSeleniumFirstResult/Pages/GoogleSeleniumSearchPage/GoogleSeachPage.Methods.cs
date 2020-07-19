using GoogleSeachFirstResult.Models;
using OpenQA.Selenium;

namespace GoogleSeachFirstResult.Pages.GoogleSeleniumSearchPage
{
    public partial class GooglePage : BasePage

    {


        public GooglePage(IWebDriver driver)
         : base(driver)
        {
        }

        public void FillGoogleSearch(GoogleFromModel user)
        {
            SearchPanel2.SendKeys(user.SearchWord + Keys.Enter);

        }
    }

}
