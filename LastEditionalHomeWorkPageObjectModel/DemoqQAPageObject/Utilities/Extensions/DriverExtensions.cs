using OpenQA.Selenium;
using System.Threading;

namespace DemoqQAPageObject.Utilities.Extensions
{
    public static class DriverExtensions
    {
        public static string GetColorBefore(this IWebElement element)
        {
            return element.GetCssValue("background-color");
        }
    }
}
