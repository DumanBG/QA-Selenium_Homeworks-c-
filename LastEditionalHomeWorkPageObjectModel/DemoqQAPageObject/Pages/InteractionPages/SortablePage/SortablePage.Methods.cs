using OpenQA.Selenium;

namespace DemoqQAPageObject.Pages
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver)
            : base(driver)
        {
        }
        // горното е равно на това :
        ////public BasePage(IWebDriver driver)
        ////{
        ////    this.Driver = driver;
        ////    this.Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        ////    this.Builder = new Actions(Driver);
        ////}






        public void MoveTwoElementsAndCheckIsOthersSorted(string firstElement, string secondElement)
        {
            Builder
                .DragAndDrop(FirstSortableElement(firstElement), SecondSortableElement(secondElement))
                .Perform();

        }
    }
}
