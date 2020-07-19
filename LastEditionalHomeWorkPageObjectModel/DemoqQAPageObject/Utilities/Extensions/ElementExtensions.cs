using OpenQA.Selenium;
using System.Threading;

namespace DemoqQAPageObject.Utilities.Extensions
{
    public static class DriverExtensionss
    {
        public static void ScrollTo(this IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void HighLight(this IWebDriver driver, IWebElement element)
        {
            var colorBefore = element.GetCssValue("background-color");
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.backgroundColor = 'red';", element);
            Thread.Sleep(500);
            ((IJavaScriptExecutor)driver).ExecuteScript($"arguments[0].style.backgroundColor = '{colorBefore}';", element);
        }
    }
}
