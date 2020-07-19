using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoqQAPageObject.Pages.InteractionPages.DatePicker
{
    class DatePickerPage : BasePage
    {
        private By SelectDateField => By.CssSelector("#datePickerMonthYearInput");
        private By Month => By.CssSelector(".react-datepicker__current-month");
        private By Day = By.CssSelector(".react-datepicker__day--selected");

        public DatePickerPage(IWebDriver driver) : base(driver)
        {
        }

        public void RemoveDateFromDateField()
        {
            FindElementAndClick(SelectDateField);
            for (int i = 1; i <= 10; i++)
            {
                FindElement(SelectDateField).SendKeys(Keys.Backspace);
            }
        }

        public void FillDateInDateFiled(string month, string day, string year)
        {
            FindElementAndTypeText(SelectDateField, $"{month}/{day}/{year}");
        }

        public string SelectedMonthAndYear => FindElement(Month).Text;

        public string SelectedDay => FindElement(Day).Text;
    }
}
