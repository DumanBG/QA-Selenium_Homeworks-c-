
using DemoqQAPageObject.Pages.InteractionPages.DatePicker;
using DemoqQAPageObject.Pages.NavigationPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Tests.Navigation
{
    [TestFixture]
    public class NavigateTests : BaseTest
    {
        private NavigationToPage _navigationToPage;
        private DatePickerPage _datePickerPage;
        private String randomDate = "07/06/2020";
        String datePicker = "Date Picker";

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");
            _navigationToPage = new NavigationToPage(Driver);
        }

        [Test]
        //[TestCase("Date Picker")]
        public void NavigateTo()
        {
            String month = "03";
            String day = "12";
            String year = "2020";

            _navigationToPage.NavigateTo(datePicker);

            _datePickerPage.RemoveDateFromDateField();
            _datePickerPage.FillDateInDateFiled(month, day, year);



        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
