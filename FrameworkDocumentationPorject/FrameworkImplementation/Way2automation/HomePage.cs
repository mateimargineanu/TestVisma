using FrameworkImplementation.Utilities;
using OpenQA.Selenium;

namespace FrameworkImplementation.Way2automation
{
    public class HomePage: BasePage
    {
        private string url = "http://way2automation.com/way2auto_jquery/index.php";

        private By EnterTestingWebsite => By.XPath("//div[contains(@class, 'fancybox-inner')]//a[contains(text(), 'ENTER TO THE TESTING WEBSITE')]");
        public void GotoHomePage()
        {
            Browser2.Goto(url);
        }
        public void ClickEnterTestingWebsite() => WaitUtils.WaitForAndClick(EnterTestingWebsite);

    }
}
