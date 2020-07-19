using GoogleSeachFirstResult.Factory;
using GoogleSeachFirstResult.Pages.GoogleSeleniumSearchPage;
using NUnit.Framework;


namespace GoogleSeachFirstResult.Tests
{
    class GoogleSearchSeleniumTest : BaseTest
    {
        public class GoogleTest : BaseTest
        {
            [SetUp]
            public void Setup()
            {
                Initialize();
                Driver.Navigate().GoToUrl("https://www.google.com/");
                GooglePage googlePageTry = new GooglePage(Driver);
            }

            [Test]

            public void GoogleSearch()
            {
                GooglePage googlePageTry = new GooglePage(Driver);

                var user = GoogleFromFactories.Create();
                googlePageTry.FillGoogleSearch(user);

                googlePageTry.WaitForLoad();
                googlePageTry.AssertHeadlineResult(googlePageTry.SeleniumHeadlineResult);
            }

            [TearDown]
            public void TearDown()
            { 
                Driver.Quit();
            }

        }
    }
}